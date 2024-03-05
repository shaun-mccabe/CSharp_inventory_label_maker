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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.ts_mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ts_settings = new System.Windows.Forms.ToolStripButton();
            this.lbl_for_PhotoPath = new System.Windows.Forms.Label();
            this.txt_photopath = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_modelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_trackingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBox_Camera_image = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ts_mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Camera_image)).BeginInit();
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
            this.btn_submit.Location = new System.Drawing.Point(59, 209);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(101, 23);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Record Item";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(61, 238);
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
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(61, 267);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // ts_mainToolStrip
            // 
            this.ts_mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_settings});
            this.ts_mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ts_mainToolStrip.Name = "ts_mainToolStrip";
            this.ts_mainToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ts_mainToolStrip.Size = new System.Drawing.Size(1143, 25);
            this.ts_mainToolStrip.TabIndex = 100;
            // 
            // ts_settings
            // 
            this.ts_settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_settings.Image = global::IT_Assets.Properties.Resources.Gear_icon;
            this.ts_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_settings.Name = "ts_settings";
            this.ts_settings.Size = new System.Drawing.Size(23, 22);
            this.ts_settings.Text = "Settings";
            // 
            // lbl_for_PhotoPath
            // 
            this.lbl_for_PhotoPath.AutoSize = true;
            this.lbl_for_PhotoPath.Location = new System.Drawing.Point(753, 15);
            this.lbl_for_PhotoPath.Name = "lbl_for_PhotoPath";
            this.lbl_for_PhotoPath.Size = new System.Drawing.Size(60, 13);
            this.lbl_for_PhotoPath.TabIndex = 102;
            this.lbl_for_PhotoPath.Text = "Photo Path";
            // 
            // txt_photopath
            // 
            this.txt_photopath.Location = new System.Drawing.Point(819, 12);
            this.txt_photopath.Name = "txt_photopath";
            this.txt_photopath.ReadOnly = true;
            this.txt_photopath.Size = new System.Drawing.Size(216, 20);
            this.txt_photopath.TabIndex = 101;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.item_name,
            this.item_type,
            this.item_serial,
            this.item_modelNumber,
            this.item_description,
            this.item_photo,
            this.item_trackingNumber});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 344);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 165);
            this.dataGridView1.TabIndex = 103;
            // 
            // id
            // 
            this.id.HeaderText = "RecordID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Name";
            this.item_name.Name = "item_name";
            // 
            // item_type
            // 
            this.item_type.HeaderText = "Type";
            this.item_type.Name = "item_type";
            // 
            // item_serial
            // 
            this.item_serial.HeaderText = "Serial Number";
            this.item_serial.Name = "item_serial";
            // 
            // item_modelNumber
            // 
            this.item_modelNumber.HeaderText = "Model Number";
            this.item_modelNumber.Name = "item_modelNumber";
            // 
            // item_description
            // 
            this.item_description.HeaderText = "Description";
            this.item_description.Name = "item_description";
            // 
            // item_photo
            // 
            this.item_photo.HeaderText = "Photo Path";
            this.item_photo.Name = "item_photo";
            this.item_photo.Visible = false;
            // 
            // item_trackingNumber
            // 
            this.item_trackingNumber.HeaderText = "Internal Tracking Number";
            this.item_trackingNumber.Name = "item_trackingNumber";
            // 
            // picBox_Camera_image
            // 
            this.picBox_Camera_image.Location = new System.Drawing.Point(664, 41);
            this.picBox_Camera_image.Name = "picBox_Camera_image";
            this.picBox_Camera_image.Size = new System.Drawing.Size(321, 248);
            this.picBox_Camera_image.TabIndex = 104;
            this.picBox_Camera_image.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 105;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBox_Camera_image);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_for_PhotoPath);
            this.Controls.Add(this.txt_photopath);
            this.Controls.Add(this.ts_mainToolStrip);
            this.Controls.Add(this.btn_Delete);
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
            this.ts_mainToolStrip.ResumeLayout(false);
            this.ts_mainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Camera_image)).EndInit();
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
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ToolStrip ts_mainToolStrip;
        private System.Windows.Forms.ToolStripButton ts_settings;
        private System.Windows.Forms.Label lbl_for_PhotoPath;
        private System.Windows.Forms.TextBox txt_photopath;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_modelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_trackingNumber;
        private System.Windows.Forms.PictureBox picBox_Camera_image;
        private System.Windows.Forms.Button button1;
    }
}

