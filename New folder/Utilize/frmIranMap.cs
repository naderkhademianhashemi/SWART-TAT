using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilize.Maps.IranMap;

namespace Utilize
{
    public partial class frmIranMap : Form
    {
        private MapInfo mapInfo;

        public frmIranMap()
        {
            InitializeComponent();
        }

        public DataTable Calculate_Amount_FncRatio_AllState()
        {
            var ds = new DataSet();

            var cmd = new SqlCommand("Calculate_Amount_FncRatio_AllState", new SqlConnection(@"Data Source=192.168.20.100\compuco;Initial Catalog=Risk_Mng_Mehr;Persist Security Info=True;User ID=swart;Password=swart1234;Connect Timeout=4000;"))
                          {CommandType = CommandType.StoredProcedure};

            cmd.Parameters.Add(new SqlParameter("@formulaID", 37));

            var sda = new SqlDataAdapter {SelectCommand = cmd};

            sda.SelectCommand.CommandTimeout = 600;

            sda.Fill(ds);


            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            else
                return null;
        }

        private void frmIranMap_Load(object sender, EventArgs e)
        {
            iranMapControl1.NameOfAmountColumn = "Amount";
            iranMapControl1.NameOfStateIdColumn = "State_Id";
            iranMapControl1.DataTable = Calculate_Amount_FncRatio_AllState();
            iranMapControl1.showMap(1, 3, 3.01, 10, 10.01, 9999);
            //mapInfo=new Maps.IranMap.MapInfo();
            //picMap.Image = mapInfo.Main;
            //var intValue=new Dictionary<int, int>();
            //var random= new Random(100);
            //foreach (var IndexByName in mapInfo.GetIndexsByName())
            //{
            //    picMap.Image = mapInfo.SetValu(IndexByName.Key, random.Next(0,15), (Bitmap)picMap.Image);
                
            //}
            
        }
    }
}
