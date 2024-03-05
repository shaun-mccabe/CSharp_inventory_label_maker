using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

//using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace IT_Assets
{
    public partial class frm_main : Form

    {

       //Globals

        data data = new data();
        
        //Form Constructor and Load Events
        public frm_main()
        {
            InitializeComponent();
            picBox_Camera_image.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            //load datagrid data
            load_data_gridview();
            //loading the Camera Selection into the camera Combobox
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
            {
                cbo_VideoInputDevice.Items.Add(filterInfo.Name);
                cbo_VideoInputDevice.SelectedIndex = 0;

                videoCaptureDevice = new VideoCaptureDevice();
            }
            //Starting the Camera
            startCamera();

            //Attempting to Retrieve the photo save Path from Settings to load it into the TxtBox so the user knows where he/she is saving the photos
            string filePath = GetAppSetting("FilePath");

            if (!string.IsNullOrEmpty(filePath))
            {
                txt_photopath.Text = filePath;
            }
            else
            {
                txt_photopath.Text = "No file path found in app.config.";
            }
            

        }
       

       //generating a internal tracking number
       //This section will need to have a function in between that checks with the database as to whether the tracking number exists.
       //during the initial development of the application, I am very new to the SQLite tech, so the DB is extremely basic and doesn't have any procedures 
       //in it.

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
        

        //submitting the form data, sending the data to the DB Via the Model class, then saving the photo where the file goes
        //I want to check to see if the photo can be saved to the database once I've gota Proof of Concept done.
        private void btn_submit_Click(object sender, EventArgs e)
        {
            item obj_items = new item(txtType.Text, txtName.Text, txt_serialNumber.Text, txt_modelNumber.Text, txt_description.Text, txt_photopath.Text, txt_trackingNumber.Text);

            item_model model = new item_model();
            var inserted = model.insert(obj_items);
            if (inserted > -1)
            {
                string photoFileName = $"DBID{inserted}-T{obj_items.str_type}-MN{obj_items.str_model}";

                //savePicture();
                load_data_gridview();
            }

    }
        
        
             

        
        //loading-reloading the data grid
        private void load_data_gridview()
        {
                if (data.status)
                {
                    Console.WriteLine(data.status);
                    item_model item_Model = new item_model();
                    
                    List<item> das_Items = item_Model.select();

                    dataGridView1.Rows.Clear();
                    //dataGridView1.Columns.Clear();



                    foreach (item currentItem in das_Items)
                    {
                        dataGridView1.Rows.Add(
                    currentItem.int_Id,
                    currentItem.str_name,
                    currentItem.str_type,
                    currentItem.str_serial,
                    currentItem.str_model,
                    currentItem.str_description,
                    currentItem.str_photo_path,
                    currentItem.str_company_tracking_number);

                    }
                }
                else
                {
                    Console.WriteLine(data.status);
                }

            }

       
        // Camera Features, utilizing the webcam on the machine to take and save the pictures of all of the items. Showing the images in a picture box in the interface
        // then saving the photo to a file/db

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void startCamera()
        {
            VideoCaptureDevice videoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[cbo_VideoInputDevice.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoResolution;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            picBox_Camera_image.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
                Application.Exit(); 
            }
            
        }

        private void cbo_VideoInputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            startCamera()
;        }

        private void savePicture(string savePath, string fileName)
        {
            Bitmap varBmp = new Bitmap(picBox_Camera_image.Image);
            Bitmap newBitmap = new Bitmap(varBmp);
            varBmp.Save($"{savePath}{fileName}.png", ImageFormat.Png);
            //Now Dispose to free the memory
            varBmp.Dispose();
            varBmp = null;

        }


        //Picture path. These blocks are for selecting, saving and retrieving the Picture save path for the application.
        private void btn_BrowsePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Set properties to configure the dialog.
            saveFileDialog1.Title = "Select a folder";
            saveFileDialog1.FileName = "Select";
            saveFileDialog1.Filter = "Folders|*.";

            // Show the dialog and check if the user selects a folder.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path.
                string folderPath = System.IO.Path.GetDirectoryName(saveFileDialog1.FileName);
                txt_photopath.Text = folderPath+"\\";
                UpdateAppSettings("PhotoSavePath", folderPath);
            }
        }

        static void UpdateAppSettings(string key, string value)
        {
            // Open the configuration file
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Add or update the key-value pair in the appSettings section
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }

            // Save the changes to the configuration file
            config.Save(ConfigurationSaveMode.Modified);

            // Refresh the ConfigurationManager to reflect the changes
            ConfigurationManager.RefreshSection("appSettings");
        }

        static string GetAppSetting(string key)
        {
            // Retrieve the value from the appSettings section in app.config
            return ConfigurationManager.AppSettings[key];
        }
    }



}

