using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace IT_Assets
{
    internal class ItemMap : ClassMap<item>
    {
        public ItemMap()
        {
            Map(m => m.int_Id).Name("ID");
            Map(m => m.str_type).Name("Type");
            Map(m => m.str_name).Name("Name");
            Map(m => m.str_serial).Name("Serial");
            Map(m => m.str_model).Name("Model");
            Map(m => m.str_description).Name("Description");
            Map(m => m.str_photo_path).Name("PhotoPath");
            Map(m => m.str_company_tracking_number).Name("CompanyTrackingNumber");
        }
    }

    internal class FileHandler
    {
        private string filePath;
        private string fileName;
        private item_model model;

        public FileHandler(string fp, string fn)
        {
            this.filePath = fp;
            this.fileName = fn;
            this.model = new item_model(); // Initialize your item_model instance
        }

        public void export_database()
        {
            List<item> records = model.Select(); // Assuming model.Select() returns List<item>

            string path = Path.Combine(filePath, fileName);

            try
            {
                using (var writer = new StreamWriter(path))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.Context.RegisterClassMap<ItemMap>();
                    csvWriter.WriteHeader<item>();
                    csvWriter.NextRecord();

                    foreach (item currentItem in records)
                    {
                        csvWriter.WriteRecord(currentItem);
                        csvWriter.NextRecord();
                    }
                }

                Console.WriteLine($"Exported {records.Count} records to {path}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error exporting data: {ex.Message}");
                // Handle exception (log, rethrow, etc.)
            }
        }
    }
}
