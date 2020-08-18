using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//File Processing
using System.IO;

namespace IT232Unit7CCutting
{
    class Program
    {
        //logfile Var
        static String logFileName;

        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 7 - Logging exceptions to a file");
            Console.WriteLine("");
            Console.WriteLine("All further console error messages are printed from the log file");

            //logfile with open stream

            logFileName = @"log.txt";
            TextWriter errStream = new StreamWriter(logFileName);

            //Redirect the stdERR to write in the file

            try
            {
                divideByZero();
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }

            try
            {
                FileDoesNotExist();
            }
            catch(Exception ex)
            {
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }

            //From the try portion, call the function, ArrayIsNUll()
            try
            {
                arrayOutOfBounds();

            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }

            try
            {
                arrayIsNull();
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }
            //Display log

            DisplayLogFile(logFileName);

            //Keep Console Open
            Console.ReadLine();

        }
        public static void DisplayLogFile(string logFileName)
        {
            //Close redirected error stream
            string path = (logFileName);

            //read log file contents

            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                while (streamReader.EndOfStream == false)
                {
                    Console.WriteLine(streamReader.ReadLine());
                }
            }
        }
        public static void DisplaylogFile(string logFileName)
        {
            //Close Error Stream
            Console.Error.Close();

            //set path to log file
            string path = (logFileName);

            //read log file contents 
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                while (streamReader.EndOfStream == false)
                {
                    Console.WriteLine(streamReader.ReadLine());
                
                }
            }
        }




        //I think this is where I went wrong in unit 6.
        public static void divideByZero()
        {
            //Manually produce dividebyzero
            int num1 = 15;
            int num2 = 0;
            int sum = num1 / num2;
        }
        public static void FileDoesNotExist()
        {
            //Make the error
            int lineCounter = 0;
            string line;
            using (System.IO.StreamReader file = new System.IO.StreamReader("NoFileFound.txt"))
            {
                while ((line = file.ReadLine()) != null)
                    lineCounter++;
            }
        }
        //ArrayIsNull Function
        public static void arrayIsNull()

        {
            //produce an array is null error
            string[] names = { "ed", "fred", "bill", "ted", "maurice" };
            names = null;
            string NoName = names[2];
        }
        public static void arrayOutOfBounds()
        {
            //Make an error
            string[] names = { "Ed", "Fred", "Bill", "Ted", "Maurice" };

            for (int i = 0; i <= names.Length; i++)
            {
                string SomeName = names[i];
            }
        }
    }
   //Make a function named arrayOutOfBounds()


}
