using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

//using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;


namespace IT_Assets
{
    public partial class frm_main : Form
        /*
         * TODO:
         * 
         * Export to CSV
         * Set Printer Combo box to default printer.
         * 
         * 
         * 
         * */

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

                Camera = new VideoCaptureDevice();
            }
            //Starting the Camera
            //startCamera();

            //Attempting to Retrieve the photo save Path from Settings to load it into the TxtBox so the user knows where he/she is saving the photos
            string filePath = GetFilePath();

            if (!string.IsNullOrEmpty(filePath))
            {
                txt_photopath.Text = filePath;
            }
            else
            {
                txt_photopath.Text = "No file path found in app.config.";
            }
            string installedPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                installedPrinters = PrinterSettings.InstalledPrinters[i];
                cbo_PrinterSelection.Items.Add(installedPrinters);
            }



        }


        //generating a internal tracking number
        //This section will need to have a function in between that checks with the database as to whether the tracking number exists.
        //during the initial development of the application, I am very new to the SQLite tech, so the DB is extremely basic and doesn't have any procedures 
        //in it.

        private void btn_generateTracking_Click(object sender, EventArgs e)
        {
            int trackingNumber = new Random().Next(1000, 5000);
            if (!data.TrackingExists(trackingNumber.ToString()))
            {
                txt_trackingNumber.Text = trackingNumber.ToString();
            }
            else
            {
                MessageBox.Show("Error, Generate another Tracking Number");
            }

           

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
        //I want to check to see if the photo can be saved to the database once I've got a Proof of Concept done.
        private void btn_submit_Click(object sender, EventArgs e)
        {
            item obj_items = new item(txtType.Text, txtName.Text, txt_serialNumber.Text, txt_modelNumber.Text, txt_description.Text, txt_photopath.Text, txt_trackingNumber.Text);

            item_model model = new item_model();
            var inserted = model.insert(obj_items);
            if (inserted > -1)
            {
                string photoFileName = $"DBID{inserted}-T{obj_items.str_type}-MN{obj_items.str_model}";

                savePicture(photoFileName);
                load_data_gridview();
                if (cbo_PrinterSelection.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a Printer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    printLabel pl = new printLabel(cbo_PrinterSelection.SelectedItem.ToString(), obj_items);
                    pl.printing();
                }
            }

    }
        
        
             

        
        //loading-reloading the data grid
        private void load_data_gridview()
        {
                if (data.status)
                {
                    item_model item_Model = new item_model();
                    
                    List<item> das_Items = item_Model.Select();

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
        VideoCaptureDevice Camera;

        private void startCamera()
        {
            Camera = new VideoCaptureDevice(FilterInfoCollection[cbo_VideoInputDevice.SelectedIndex].MonikerString);
            Camera.NewFrame += VideoCaptureDevice_NewFrame;
            Camera.VideoResolution = Camera.VideoResolution;
            Camera.Start();
        }

        private void stopCamera()
        {
            Console.WriteLine("Disposing of picture box.");
            picBox_Camera_image.Image= null;
            if (Camera != null)
            {
                Camera.SignalToStop();
            }
            else
            {
                return;
            }
           


            if (Camera.IsRunning)

            {
                Console.WriteLine("Running");
                
                
            }
            Camera.Stop();


            if (Camera.IsRunning)
            {
                Console.WriteLine("still Running");
            }
        }
        private void VideoCaptureDevice_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            picBox_Camera_image.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCamera();
        }
        

        private string savePicture(string fileName)
        {
            if (picBox_Camera_image.Image != null)
            {
                Bitmap varBmp = new Bitmap(picBox_Camera_image.Image);
                Bitmap newBitmap = new Bitmap(varBmp);
                string savePath = Properties.Settings.Default.FilePath;
                string fullpath = $"{savePath}{fileName}.png";
                varBmp.Save(fullpath, ImageFormat.Png);
                //Now Dispose to free the memory
                varBmp.Dispose();
                varBmp = null;

                return fullpath;
            }
            else
            {
                MessageBox.Show("Error Saving Picture");
                return null;
            }
           

        }


        //Picture path. These blocks are for selecting, saving and retrieving the Picture save path for the application.
        private void btn_BrowsePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Set properties to configure the dialog.
            saveFileDialog1.Title = "Select a folder";
            saveFileDialog1.FileName = " ";
            saveFileDialog1.Filter = "Folders|*.";

            // Show the dialog and check if the user selects a folder.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path.
                string folderPath = System.IO.Path.GetDirectoryName(saveFileDialog1.FileName);
                txt_photopath.Text = folderPath+"\\";
                try
                {
                    LogSetting("FilePath", folderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving setting: " + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Settings File Says: " + GetFilePath() );
                }
               
            }
        }
         void LogSetting(string key, string path)
        {
           
            Properties.Settings.Default[key] = path;
            Properties.Settings.Default.Save();
        }
        
        static string GetFilePath()
        {
            string setting = Properties.Settings.Default.FilePath;
            // Retrieve the value from the settings File
            return setting;
        }

        private void btn_startCamera_Click(object sender, EventArgs e)
        {
            startCamera();
        }

        private void btn_StopCamera_Click(object sender, EventArgs e)
        {
            stopCamera();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int rowidx = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowidx];
                int cellValue = (int)(selectedRow.Cells["id"].Value);
                item_model im = new item_model();
                int effected_rows = im.delete_item(cellValue);
                Console.WriteLine(effected_rows);
                load_data_gridview();
                if (effected_rows < 0) {
                    throw new Exception();
                   
                }

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: {err}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //Print the Label for the Asset

            int rowidx = dataGridView1.SelectedCells[0].RowIndex; 
            DataGridViewRow selectedRow = dataGridView1.Rows[rowidx];
            int cellValue= (int)(selectedRow.Cells["id"].Value);


            item_model im = new item_model();
            item SelectedItem = im.selectAnItem(cellValue);
          if(cbo_PrinterSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Printer!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                printLabel pl = new printLabel(cbo_PrinterSelection.SelectedItem.ToString(), SelectedItem);
               pl.printing();
            }
          




        }

        private void cboPrinterSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }



}

