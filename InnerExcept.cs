using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabPrograms
{
    class Innerexcept
    {
        static void Main()
        {
            try
            {


                try
                {
                    Console.WriteLine("enter first number");
                    int FN = int.Parse(Console.ReadLine());

                    Console.WriteLine("enter second number");
                    int SN = int.Parse(Console.ReadLine());

                    int Result = FN / SN;
                }

                catch (Exception e)
                {
                    string filepath = @"D:\temp\log.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(e.GetType().Name);
                        Console.WriteLine("check in log file {0}", filepath);
                        sw.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException("file no found in" + e);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("file not found " + ex.GetType().Name);
                if (ex.InnerException !=null)
                {
                    Console.WriteLine("file not found " + ex.InnerException.GetType().Name);
                }
               
            }



        }
    }
}
