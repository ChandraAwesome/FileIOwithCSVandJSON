using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class LearnFileIO
    {
        public static void FileExisted()
        {
            string path = "C:\\Users\\SARAT CHANDRA\\OneDrive\\Desktop\\Assignments\\FileIO\\Test.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Existed in the System");
            }
            else
            {
                Console.WriteLine("File is not available or change the path directory");
            }
        }

        public static void ReadFileData() 
        {
            string path = "C:\\Users\\SARAT CHANDRA\\OneDrive\\Desktop\\Assignments\\FileIO\\Test.txt";
            Console.WriteLine(File.ReadAllText(path));
        }

        public static void CopyFileData()
        {
            string path = "C:\\Users\\SARAT CHANDRA\\OneDrive\\Desktop\\Assignments\\FileIO\\Test.txt";

            string copypathh = "C:\\Users\\SARAT CHANDRA\\OneDrive\\Desktop\\Assignments\\FileIO\\coppy.txt";

            try
            {

                File.Copy(path, copypathh);
                Console.WriteLine("Successfully copied to the destination file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void WriteFileData() 
            
        {
            string path = "C:\\Users\\SARAT CHANDRA\\OneDrive\\Desktop\\Assignments\\FileIO\\Test.txt";
            using (StreamWriter write = new StreamWriter(path))
            {
                write.WriteLine("I am here finallly yay");
                write.Close();
                //File.ReadAllText(path);
                Console.WriteLine("Finally you written a data into a file");
            }
        }

        public static void ReadFileDatafromStream()
        {
            string path = "C:\\Users\\SARAT CHANDRA\\OneDrive\\Desktop\\Assignments\\FileIO\\Test.txt";

            using(StreamReader read = new StreamReader(path)) 
            {
                Console.WriteLine(read.ReadLine());
                read.Close();
            }
        }
    }
}
