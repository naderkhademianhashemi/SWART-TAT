using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace Presentation.Public
{
    public class FTPHelper : BackgroundWorker
    {
        public FTPHelper()
        {
            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;
            this.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FtpProgress_DoWork);
        }

        private void FtpProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
             FTPSetting settings = e.Argument as FTPSetting;

            // set up the host string to request.  this includes the target folder and the target file name (based on the source filename)
            string upFilename = "CRP.data"; //Path.GetFileName(settings.SourceFile);
            string UploadPath = String.Format("{0}/{1}{2}", settings.Host, settings.TargetDir == "" ? "" : settings.TargetDir + "/", upFilename);
            if (!UploadPath.ToLower().StartsWith("ftp://"))
                UploadPath = "ftp://" + UploadPath;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(UploadPath);
            request.UseBinary = true;
            request.UsePassive = settings.Passive;
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(settings.Username, settings.Password);

            // Copy the contents of the file to the request stream.
            long FileSize = new FileInfo(settings.SourceFile).Length;
            string FileSizeDescription = GetFileSize(FileSize); // e.g. "2.4 Gb" instead of 240000000000000 bytes etc...			
            int ChunkSize = 1048576, NumRetries = 0, MaxRetries = 50;
            long SentBytes = 0;
            byte[] Buffer = new byte[ChunkSize];    // this buffer stores each chunk, for sending to the web service via MTOM
            using (Stream requestStream = request.GetRequestStream())
            {
                using (FileStream fs = File.Open(settings.SourceFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    int BytesRead = fs.Read(Buffer, 0, ChunkSize);	// read the first chunk in the buffer
                    // send the chunks to the web service one by one, until FileStream.Read() returns 0, meaning the entire file has been read.
                    while (BytesRead > 0)
                    {
                        try
                        {
                            if (bw.CancellationPending)
                                return;

                            // send this chunk to the server.  it is sent as a byte[] parameter, but the client and server have been configured to encode byte[] using MTOM. 
                            requestStream.Write(Buffer, 0, BytesRead);

                            // sentBytes is only updated AFTER a successful send of the bytes. so it would be possible to build in 'retry' code, to resume the upload from the current SentBytes position if AppendChunk fails.
                            SentBytes += BytesRead;

                            // update the user interface
                            string SummaryText = String.Format("Transferred {0} / {1}", GetFileSize(SentBytes), FileSizeDescription);
                            bw.ReportProgress((int)(((decimal)SentBytes / (decimal)FileSize) * 100), SummaryText);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("Exception: " + ex.ToString());
                            if (NumRetries++ < MaxRetries)
                            {
                                // rewind the filestream and keep trying
                                fs.Position -= BytesRead;
                            }
                            else
                            {
                                throw new Exception(String.Format("Error occurred during upload, too many retries. \n{0}", ex.ToString()));
                            }
                        }
                        BytesRead = fs.Read(Buffer, 0, ChunkSize);	// read the next chunk (if it exists) into the buffer.  the while loop will terminate if there is nothing left to read
                    }
                }
            }

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                System.Diagnostics.Debug.WriteLine(String.Format("Upload File Complete, status {0}", response.StatusDescription));

            
        }

        public static string GetFileSize(long numBytes)
        {
            string fileSize = "";

            if (numBytes > 1073741824)
                fileSize = String.Format("{0:0.00} Gb", (double)numBytes / 1073741824);
            else if (numBytes > 1048576)
                fileSize = String.Format("{0:0.00} Mb", (double)numBytes / 1048576);
            else
                fileSize = String.Format("{0:0} Kb", (double)numBytes / 1024);

            if (fileSize == "0 Kb")
                fileSize = "1 Kb";	// min.							
            return fileSize;
        }
    }
}