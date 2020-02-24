using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Project
{
    class Animation
    {

        //	Add to the top of the .cs file to allow file handle
        public string line;
        public string file;

        public void Animate(string file)
        {


            
            try
            {

                //Pass the file path and file name to the StreamReader constructor

                StreamReader sr = new StreamReader($"{file}");

                //Read the first line of text

                line = sr.ReadLine();

                //Continue to read until you reach end of file

                while (line != null)
                {

                    //write the line to console window

                    Console.WriteLine(line);

                    //Read the next line

                    line = sr.ReadLine();
                }

                //close the file

                sr.Close();
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("");
            }

              //Source: https://support.microsoft.com/en-us/help/816149/how-to-read-from-and-write-to-a-text-file-by-using-visual-c 

        }
    }
}
