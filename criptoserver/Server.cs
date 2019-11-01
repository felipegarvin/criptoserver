﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptoserver
{
    public class Server
    {
        static void Main()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");

            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");

            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
