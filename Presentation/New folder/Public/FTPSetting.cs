using System;
using System.Xml.Serialization;
using System.Collections;
using System.Configuration;

namespace Presentation.Public
{
    public class FTPSetting : ConfigurationSection
    {
        private string sourceFile = string.Empty;

        [ConfigurationProperty("host")]
        public string Host
        {
            get { return this["host"].ToString(); }
            set { this["host"] = value; }
        }

        [ConfigurationProperty("username")]
        public string Username
        {
            get { return this["username"].ToString(); }
            set { this["username"] = value; }
        }

        [ConfigurationProperty("password")]
        public string Password
        {
            get { return this["password"].ToString(); }
            set { this["password"] = value; }
        }

        [ConfigurationProperty("passive")]
        public bool Passive
        {
            get { return (bool)this["passive"]; }
            set { this["passive"] = value; }
        }

        [ConfigurationProperty("port")]
        public int Port
        {
            get { return (int)this["port"]; }
            set { this["port"] = value; }
        }

        [ConfigurationProperty("targetdir")]
        public string TargetDir
        {
            get { return this["targetdir"].ToString(); }
            set { this["targetdir"] = value; }
        }

        [ConfigurationProperty("sharedfolder")]
        public string SharedFolder
        {
            get { return this["sharedfolder"].ToString(); }
            set { this["sharedfolder"] = value; }
        }

        public string SourceFile
        {
            get { return sourceFile; }
            set { sourceFile = value; }
        }
    }
}
