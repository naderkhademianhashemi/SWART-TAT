using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilize.Helper;

namespace Utilize.Maps.IranMap
{
    public partial class IranMapControl : UserControl
    {
        public IranMapControl()
        {
            InitializeComponent();
            mainImag = Properties.Resources.Main;
        }

        #region Parameters

        public bool _IsShowDetails;
        public bool IsShowDetails
        {
            get { return _IsShowDetails; }
            set
            {
                _IsShowDetails = value;
                if(_IsShowDetails)
                {
                    MinimumSize = new Size(925, 600);
                    MaximumSize = new Size(925, 600);
                    Size = new Size(925, 600);
                }
                else
                {
                    MinimumSize = new Size(800, 600);
                    MaximumSize = new Size(800, 600);
                    Size = new Size(800, 600);
                }
                txtNameOfState.Visible = txtAmount.Visible = _IsShowDetails;
                lblNameOfState.Visible = lblAmount.Visible = _IsShowDetails;
            }
        }
        private readonly Image mainImag;
        private readonly IranMap mapObj=new IranMap();
        readonly ToolTip toolTip = new ToolTip();

        private DataTable dtProvinces;
        [Description("مجموعه دادۀ استان ها به همراه مقدار هر استان")]
        public DataTable DataTable
        {
            get { return dtProvinces; }
            set { dtProvinces = value; }
        }

        private string _NameOfStateIdColumn = "State_Id";
        [DefaultValue("State_Id")]
        [Description("نام ستون شمارۀ استان در مجموعه داده")]
        public string NameOfStateIdColumn
        {
            get { return _NameOfAmountColumn.IsNullOrEmptyByTrim() ? "State_Id" : _NameOfStateIdColumn; }
            set { _NameOfStateIdColumn = value; }
        }

        private string _NameOfAmountColumn = "Amount";
        [DefaultValue("Amount")]
        [Description("نام ستون مقدار استان در مجموعه داده")]
        public string NameOfAmountColumn
        {
            get { return _NameOfAmountColumn.IsNullOrEmptyByTrim() ? "Amount" : _NameOfAmountColumn; }
            set { _NameOfAmountColumn = value; }
        }

        #endregion

        public void showMap(double thresholdD, double thresholdU, double thresholdDY, double thresholdUY, double thresholdDR, double thresholdUR)
        {
            var G = Graphics.FromImage(mainImag);

            var blackPen = new Pen(Color.Black, 2);


            for (int i = 0; i < mapObj.get_nContinents(); i++)
            {
                G.DrawPolygon(blackPen, mapObj.get_PolygonPoints(i));

                var cbrush = new SolidBrush(Color.White);
                G.FillPolygon(cbrush, mapObj.get_PolygonPoints(i));
            }



            foreach (DataRow dr in dtProvinces.Rows)
            {
                int index = Convert.ToInt32(dr[_NameOfStateIdColumn]) == 36 ? 33 : Convert.ToInt32(dr[_NameOfStateIdColumn]);

                if (mapObj.groupId2Index(Convert.ToInt32(dr[1])) >= 0)
                {
                    if (dr[_NameOfAmountColumn] != DBNull.Value)
                    {
                        if (Convert.ToDouble(dr[_NameOfAmountColumn]) >= thresholdDY && Convert.ToDouble(dr[_NameOfAmountColumn]) < thresholdUY)
                        {

                            G.DrawPolygon(blackPen, mapObj.get_PolygonPoints(mapObj.groupId2Index(index)));

                            var cbrush = new SolidBrush(Color.Orange);

                            G.FillPolygon(cbrush, mapObj.get_PolygonPoints(mapObj.groupId2Index(index)));
                        }
                        else if (Convert.ToDouble(dr[_NameOfAmountColumn]) >= thresholdD && Convert.ToDouble(dr[_NameOfAmountColumn]) < thresholdU)
                        {

                            G.DrawPolygon(blackPen, mapObj.get_PolygonPoints(mapObj.groupId2Index(index)));

                            var cbrush = new SolidBrush(Color.DarkGreen);

                            G.FillPolygon(cbrush, mapObj.get_PolygonPoints(mapObj.groupId2Index(index)));
                        }
                        else if (Convert.ToDouble(dr[_NameOfAmountColumn]) >= thresholdDR && Convert.ToDouble(dr[_NameOfAmountColumn]) < thresholdUR)
                        {

                            G.DrawPolygon(blackPen, mapObj.get_PolygonPoints(mapObj.groupId2Index(index)));

                            var cbrush = new SolidBrush(Color.Red);

                            G.FillPolygon(cbrush, mapObj.get_PolygonPoints(mapObj.groupId2Index(index)));
                        }
                    }
                }
            }

            foreach (DataRow dr in dtProvinces.Rows)
            {



                if (mapObj.groupId2Index(Convert.ToInt32(dr[1])) >= 0)
                {
                    string val = "";
                    if (dr[_NameOfAmountColumn] != DBNull.Value)
                        val = String.Format("{0:0.000}", dr[_NameOfAmountColumn]);
                    else
                        if (Convert.ToInt32(dr[1]) != 33)
                            val = "N/A";

                    if (Convert.ToInt32(dr[1]).Equals(36)) 
                    {
                        G.DrawString(val, new Font("tahoma", 10 / mapObj.getScale(), FontStyle.Bold), new SolidBrush(Color.Black), mapObj.getCentroid(mapObj.groupId2Index(33)).X
     , mapObj.getCentroid(mapObj.groupId2Index(33)).Y);
                    }
                    else
                    {
                        G.DrawString(val, new Font("tahoma", 10 / mapObj.getScale(), FontStyle.Bold), new SolidBrush(Color.Black), mapObj.getCentroid(mapObj.groupId2Index(Convert.ToInt32(dr[1]))).X
                    , mapObj.getCentroid(mapObj.groupId2Index(Convert.ToInt32(dr[1]))).Y);
                    }

                }
            }
            pcbMap.Image = mainImag;
        }

        private void pcbMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (dtProvinces != null)
            {

                var indexState = mapObj.getContainerPolygon(new Point(e.X, e.Y));
                toolTip.SetToolTip(pcbMap, mapObj.getName(indexState));
                if (_IsShowDetails == false) return;
                txtNameOfState.Text = mapObj.getName(indexState);
                txtNameOfState.Refresh();
                var containerPolygon = mapObj.getStateID(mapObj.getContainerPolygon(new Point(e.X, e.Y)));
                var stateData =
                    dtProvinces.Rows.Cast<DataRow>().Where(
                        row => row[_NameOfStateIdColumn].ToString().Trim().Equals(containerPolygon.ToString().Trim())).
                        FirstOrDefault();
                txtAmount.Text = stateData != null ? stateData[_NameOfAmountColumn].ToString() : "";
                txtAmount.Refresh();
            }

        }

        public event EventHandler<MapInfoArgs> Map_DoubleClick;
        private void pcbMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dtProvinces == null) return;
            var stateID = mapObj.getStateID(mapObj.getContainerPolygon(new Point(e.X, e.Y)));
            var name = mapObj.getName(mapObj.getContainerPolygon(new Point(e.X, e.Y)));
            if (Map_DoubleClick != null)
                Map_DoubleClick.Invoke(sender, new MapInfoArgs(stateID, name));
        }
    }

    public class MapInfoArgs:EventArgs
    {
        private int _stateId;
        private string _name;
        public MapInfoArgs(int stateID,string name)
        {
            _stateId = stateID;
            _name = name;
        }
        public int StateId
        {
            get { return _stateId; }
        }
        public string StateName
        {
            get { return _name; }
        }
    }
}
