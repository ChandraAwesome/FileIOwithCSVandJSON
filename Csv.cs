using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperAndJson
{
    internal class Csv
    {
        public static void CsvFile()
        { 
        string importpath = "C:\\Users\\SARAT CHANDRA\\OneDrive\\Desktop\\Assignments\\CSVHelperAndJson\\Utility\\Read.csv";
        string exportpath = "C:\\Users\\SARAT CHANDRA\\OneDrive\\Desktop\\Assignments\\CSVHelperAndJson\\Utility\\export.csv";

        using(var read= new StreamReader(importpath))
        using(var csv= new CsvReader(read,CultureInfo.InvariantCulture))
            {
                var records=csv.GetRecords<AddressData>().ToList();
                foreach(var data in records) 
                {
                    Console.WriteLine("\t"+data.Name);

                    Console.WriteLine("\t"+data.Branch);

                    Console.WriteLine("\t"+data.City);

                    Console.WriteLine("\t"+data.Percentage);

                    Console.WriteLine();
                }
                Console.WriteLine("-----------Reading the data from csv and writing to csv again-------------");

                // to csv

                //using( var csvs= new StreamWriter(exportpath))
                //using (var writetocsv = new CsvWriter(csvs, CultureInfo.InvariantCulture))
                //{
                //    writetocsv.WriteRecords(records);
                //}

                // to json

              JsonSerializer json= new JsonSerializer();
                using(StreamWriter write = new StreamWriter(exportpath))
                using(JsonWriter writejson=new JsonTextWriter(write))
                {
                    json.Serialize(writejson, records);
                }
            }
    }   }
}
