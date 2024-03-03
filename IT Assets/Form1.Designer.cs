namespace IT_Assets
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtType = new System.Windows.Forms.TextBox();
            this.txt_serialNumber = new System.Windows.Forms.TextBox();
            this.txt_modelNumber = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_trackingNumber = new System.Windows.Forms.TextBox();
            this.lbl_for_txtType = new System.Windows.Forms.Label();
            this.lbl_for_txtSerial = new System.Windows.Forms.Label();
            this.lbl_for_txtModelNum = new System.Windows.Forms.Label();
            this.lbl_for_txtDescription = new System.Windows.Forms.Label();
            this.lbl_for_txtCompTrackingNumber = new System.Windows.Forms.Label();
            this.btn_generateTracking = new System.Windows.Forms.Button();
            this.chk_OverrideTrackingGenerator = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.lbl_for_txtName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.assetsDataSet = new IT_Assets.AssetsDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(214, 41);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(216, 20);
            this.txtType.TabIndex = 0;
            // 
            // txt_serialNumber
            // 
            this.txt_serialNumber.Location = new System.Drawing.Point(214, 93);
            this.txt_serialNumber.Name = "txt_serialNumber";
            this.txt_serialNumber.Size = new System.Drawing.Size(216, 20);
            this.txt_serialNumber.TabIndex = 2;
            // 
            // txt_modelNumber
            // 
            this.txt_modelNumber.Location = new System.Drawing.Point(214, 119);
            this.txt_modelNumber.Name = "txt_modelNumber";
            this.txt_modelNumber.Size = new System.Drawing.Size(216, 20);
            this.txt_modelNumber.TabIndex = 3;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(214, 145);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(216, 20);
            this.txt_description.TabIndex = 4;
            // 
            // txt_trackingNumber
            // 
            this.txt_trackingNumber.Location = new System.Drawing.Point(214, 171);
            this.txt_trackingNumber.Name = "txt_trackingNumber";
            this.txt_trackingNumber.ReadOnly = true;
            this.txt_trackingNumber.Size = new System.Drawing.Size(216, 20);
            this.txt_trackingNumber.TabIndex = 5;
            // 
            // lbl_for_txtType
            // 
            this.lbl_for_txtType.AutoSize = true;
            this.lbl_for_txtType.Location = new System.Drawing.Point(56, 44);
            this.lbl_for_txtType.Name = "lbl_for_txtType";
            this.lbl_for_txtType.Size = new System.Drawing.Size(31, 13);
            this.lbl_for_txtType.TabIndex = 7;
            this.lbl_for_txtType.Text = "Type";
            // 
            // lbl_for_txtSerial
            // 
            this.lbl_for_txtSerial.AutoSize = true;
            this.lbl_for_txtSerial.Location = new System.Drawing.Point(56, 96);
            this.lbl_for_txtSerial.Name = "lbl_for_txtSerial";
            this.lbl_for_txtSerial.Size = new System.Drawing.Size(73, 13);
            this.lbl_for_txtSerial.TabIndex = 8;
            this.lbl_for_txtSerial.Text = "Serial Number";
            // 
            // lbl_for_txtModelNum
            // 
            this.lbl_for_txtModelNum.AutoSize = true;
            this.lbl_for_txtModelNum.Location = new System.Drawing.Point(56, 122);
            this.lbl_for_txtModelNum.Name = "lbl_for_txtModelNum";
            this.lbl_for_txtModelNum.Size = new System.Drawing.Size(76, 13);
            this.lbl_for_txtModelNum.TabIndex = 9;
            this.lbl_for_txtModelNum.Text = "Model Number";
            // 
            // lbl_for_txtDescription
            // 
            this.lbl_for_txtDescription.AutoSize = true;
            this.lbl_for_txtDescription.Location = new System.Drawing.Point(56, 148);
            this.lbl_for_txtDescription.Name = "lbl_for_txtDescription";
            this.lbl_for_txtDescription.Size = new System.Drawing.Size(60, 13);
            this.lbl_for_txtDescription.TabIndex = 4;
            this.lbl_for_txtDescription.Text = "Description";
            // 
            // lbl_for_txtCompTrackingNumber
            // 
            this.lbl_for_txtCompTrackingNumber.AutoSize = true;
            this.lbl_for_txtCompTrackingNumber.Location = new System.Drawing.Point(56, 174);
            this.lbl_for_txtCompTrackingNumber.Name = "lbl_for_txtCompTrackingNumber";
            this.lbl_for_txtCompTrackingNumber.Size = new System.Drawing.Size(136, 13);
            this.lbl_for_txtCompTrackingNumber.TabIndex = 11;
            this.lbl_for_txtCompTrackingNumber.Text = "Company Tracking Number";
            // 
            // btn_generateTracking
            // 
            this.btn_generateTracking.Location = new System.Drawing.Point(436, 169);
            this.btn_generateTracking.Name = "btn_generateTracking";
            this.btn_generateTracking.Size = new System.Drawing.Size(121, 23);
            this.btn_generateTracking.TabIndex = 6;
            this.btn_generateTracking.Text = "Generate Tracking";
            this.btn_generateTracking.UseVisualStyleBackColor = true;
            this.btn_generateTracking.Click += new System.EventHandler(this.btn_generateTracking_Click);
            // 
            // chk_OverrideTrackingGenerator
            // 
            this.chk_OverrideTrackingGenerator.AutoSize = true;
            this.chk_OverrideTrackingGenerator.Location = new System.Drawing.Point(563, 173);
            this.chk_OverrideTrackingGenerator.Name = "chk_OverrideTrackingGenerator";
            this.chk_OverrideTrackingGenerator.Size = new System.Drawing.Size(66, 17);
            this.chk_OverrideTrackingGenerator.TabIndex = 7;
            this.chk_OverrideTrackingGenerator.Text = "Override";
            this.chk_OverrideTrackingGenerator.UseVisualStyleBackColor = true;
            this.chk_OverrideTrackingGenerator.CheckedChanged += new System.EventHandler(this.chk_OverrideTrackingGenerator_CheckedChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(554, 209);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(101, 23);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Record Item";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(661, 209);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(99, 23);
            this.btn_print.TabIndex = 9;
            this.btn_print.Text = "Print Label";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // lbl_for_txtName
            // 
            this.lbl_for_txtName.AutoSize = true;
            this.lbl_for_txtName.Location = new System.Drawing.Point(56, 70);
            this.lbl_for_txtName.Name = "lbl_for_txtName";
            this.lbl_for_txtName.Size = new System.Drawing.Size(35, 13);
            this.lbl_for_txtName.TabIndex = 16;
            this.lbl_for_txtName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 1;
            // 
            // dgv_items
            // 
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Location = new System.Drawing.Point(29, 267);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.Size = new System.Drawing.Size(1084, 136);
            this.dgv_items.TabIndex = 17;
            // 
            // assetsDataSet
            // 
            this.assetsDataSet.DataSetName = "AssetsDataSet";
            this.assetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 650);
            this.Controls.Add(this.dgv_items);
            this.Controls.Add(this.lbl_for_txtName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.chk_OverrideTrackingGenerator);
            this.Controls.Add(this.btn_generateTracking);
            this.Controls.Add(this.lbl_for_txtCompTrackingNumber);
            this.Controls.Add(this.lbl_for_txtDescription);
            this.Controls.Add(this.lbl_for_txtModelNum);
            this.Controls.Add(this.lbl_for_txtSerial);
            this.Controls.Add(this.lbl_for_txtType);
            this.Controls.Add(this.txt_trackingNumber);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_modelNumber);
            this.Controls.Add(this.txt_serialNumber);
            this.Controls.Add(this.txtType);
            this.Name = "frm_main";
            this.Text = "IT Asset Label Printer";
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txt_serialNumber;
        private System.Windows.Forms.TextBox txt_modelNumber;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_trackingNumber;
        private System.Windows.Forms.Label lbl_for_txtType;
        private System.Windows.Forms.Label lbl_for_txtSerial;
        private System.Windows.Forms.Label lbl_for_txtModelNum;
        private System.Windows.Forms.Label lbl_for_txtDescription;
        private System.Windows.Forms.Label lbl_for_txtCompTrackingNumber;
        private System.Windows.Forms.Button btn_generateTracking;
        private System.Windows.Forms.CheckBox chk_OverrideTrackingGenerator;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_for_txtName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgv_items;
        private AssetsDataSet assetsDataSet;
    }
}

