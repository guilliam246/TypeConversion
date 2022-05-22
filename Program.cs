using System;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "True";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number cant be converted to a byte");
                Console.WriteLine("this is a test to see changes in GIT");
            }


         }

            
     }

 }


