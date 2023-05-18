using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ERMS.Model;
using ERMSLib;
using ERMS.Logic;
using Presentation.Public;

namespace Presentation.Capital_Adequacy
{
    public partial class frmCapitalAdequacy : BaseForm
    {
        public frmCapitalAdequacy()
        {
            InitializeComponent();
        }

        private void frmCapitalAdequacy_Load(object sender, EventArgs e)
        {
            fdpDate.SelectedDateTime= new DAL.General_DataSet().GetLastUpdateDate();
        }

        private void cbCalculate_CButtonClicked(object sender, EventArgs e)
        {
            double layer1, layer2, creditAsset, marketAsset, operationalAsset, riskAsset, CapitalAdequacy;

            new DAL.CapitalAdequacy().Get_CapitalAdequacyRatio(fdpDate.SelectedDateTime, out layer1, out layer2, out creditAsset,
                 out marketAsset, out operationalAsset, out riskAsset, out CapitalAdequacy);

            lbllayer1.Text = layer1.ToString();
            lblLayer2.Text = layer2.ToString();
            lblSCapital.Text = (layer1 + layer2).ToString();
            lblCreditAsset.Text = creditAsset.ToString();
            lblMarketAsset.Text = marketAsset.ToString();
            lblOpAsset.Text = operationalAsset.ToString();
            lblRiskAsset.Text = riskAsset.ToString();
            lblCapitalAdequacy.Text = CapitalAdequacy.ToString();

        }
    }
}
