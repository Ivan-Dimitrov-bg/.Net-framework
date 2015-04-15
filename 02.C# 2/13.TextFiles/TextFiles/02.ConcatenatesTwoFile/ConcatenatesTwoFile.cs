//Write a program that concatenates two text files into another text file.


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConcatenatesTwoFile
{
    class ConcatenatesTwoFile
    {
        static void Main()
        {

            //string firstFileName = "/02.text files../../temp01.txt";//the dir of the .cs file
            //string secondFileName = "/02.text files../../temp02.txt"; //the dir of the .cs file
            //string newFileName = "/02.text files../../ConcatenatedFile.txt"; //the dir of the .cs file
            string firstFileName = "../../02.text files/temp01.txt";//the dir of the .cs file
            string secondFileName = "../../02.text files/temp02.txt"; //the dir of the .cs file
            string newFileName = "../../02.text files/ConcatenatedFile.txt"; //the dir of the .cs file
            
            Archive(newFileName);

            CopyFile(firstFileName, secondFileName, newFileName);

            PrintFile(newFileName); 

        }

        private static void CopyFile(string firstFileName, string secondFileName, string newFileName)
        {
            using (StreamWriter writeToNewFile = new StreamWriter(newFileName))
            {
                using (StreamReader readFirstFile = new StreamReader(firstFileName))
                {
                    string line = readFirstFile.ReadLine();
                    while (line != null)
                    {
                        writeToNewFile.WriteLine(line);
                        line = readFirstFile.ReadLine();
                    }
                }

                using (StreamReader readSecondFile = new StreamReader(secondFileName))
                {
                    string line = readSecondFile.ReadLine();
                    while (line != null)
                    {
                        writeToNewFile.WriteLine(line);
                        line = readSecondFile.ReadLine();
                    }
                }
            }

            Console.WriteLine("The files are copied!");
        }

        private static void Archive(string newFileName)
        {
            if (File.Exists(newFileName))
            {
                string archiveName = newFileName.Remove(0,6);
                string archive = "../../02.text files/archive" + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Day + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second +".txt";
                File.Copy(newFileName, archive);
                File.Delete(newFileName);

            }
            File.Create(newFileName).Close();
        }
        private static void PrintFile(string newFileName)
        {
            Console.Write("Do You want to read the concatenated file <y/n>: ");
            char answer = (char)Console.Read();

            if (answer == 'y')
            {
                using (StreamReader concatenated = new StreamReader(newFileName))
                {
                    string line = concatenated.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = concatenated.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("GoodBye");
            }
        }


    }
}
