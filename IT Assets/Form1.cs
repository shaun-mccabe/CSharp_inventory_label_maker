using IT_Assets.AssetsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Assets
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        asset_items_TableAdapter items = new asset_items_TableAdapter();
        private void btn_generateTracking_Click(object sender, EventArgs e)
        {
            int trackingNumber = new Random().Next(1000, 5000);
            txt_trackingNumber.Text = trackingNumber.ToString();

        }

        private void chk_OverrideTrackingGenerator_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_OverrideTrackingGenerator.Checked == true)
            {
                txt_trackingNumber.ReadOnly = false;
                btn_generateTracking.Enabled = false;
            }else if (chk_OverrideTrackingGenerator.Checked == false) { 
                txt_trackingNumber.ReadOnly = true;
                btn_generateTracking.Enabled = true;
            }
        }
        

        private void btn_submit_Click(object sender, EventArgs e)
        {
          item  obj_items = new item(txtType.Text, txtName.Text, txt_serialNumber.Text, txt_modelNumber.Text, txt_description.Text, txt_trackingNumber.Text);
            //items.save_item();
            data pushData = new data();
            pushData.Set(obj_items);
            dgv_items.DataSource = items.GetData();
            

        }

       
        private void frm_main_Load(object sender, EventArgs e)
        {
            

            dgv_items.DataSource = items.GetData();

        }
    }
}
