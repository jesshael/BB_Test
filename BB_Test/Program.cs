using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace BB_Test
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Jesshael Cabrera Sample, numbers 1 to 10");

            List<int> collection = new List<int>() ;
            //{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
            string arr;
            Console.WriteLine("Size of your array? only integers 1+ to 100");
            arr = Console.ReadLine();
            int arrysize;
            bool barrsize = int.TryParse(arr, out arrysize);

            if (barrsize == true)
            {
                for (int i = 1; i <= arrysize; i++)
                {
                    Console.WriteLine("get me the vaule" + i + " of " + arrysize + " <<only integers>> ");

                    string Input;
                    int valuepass;

                    Input = Console.ReadLine();

                    bool isNumeric = int.TryParse(Input, out valuepass);
                    if (isNumeric == true)
                    {
                        collection.Add(valuepass);
                    }
                    else {
                        Console.WriteLine("you dont enter interger the program is close");
                        Environment.Exit(-1);
                    }
                }
            }
            else {
                
                Console.WriteLine("you dont enter interger the program is close");
                Environment.Exit(-1);

            }


            foreach (int x in collection)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("StopTStart: FizzBuzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("stop: Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("stop: Buzz");
                }
            }

            Console.ReadLine();
        }
    }
}
