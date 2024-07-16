using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace IT_Assets
{
    internal class printLabel
    {
        private Font printFont;
        private string printerName;
        private item assetItem;


        
        public printLabel(string prntName, item prntItem) {
            this.printerName = prntName;
            this.assetItem = prntItem;
           
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            String line = null;

            // Print each property of the assetItem

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tracking Number: { assetItem.str_company_tracking_number}");
            sb.AppendLine($"Name:   {assetItem.str_name}");
            sb.AppendLine($"Type:   {assetItem.str_type}");
            sb.AppendLine($"Model:  {assetItem.str_model}");
            sb.AppendLine($"Serial: {assetItem.str_serial}");

            line =  sb.ToString();

            yPos = topMargin;

            e.Graphics.DrawString(line, printFont, Brushes.Black, 30, 5, new StringFormat());

            // If more lines exist, print another page.
            e.HasMorePages = false; // You can set this to true if you want to print multiple pages
        }

        public void printing()
        {
            try
            {
                printFont = new Font("Arial", 10);
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                pd.Print();
                printFont.Dispose();


            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());

            }
        }
    }

}
