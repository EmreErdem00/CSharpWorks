﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> isimler2 = new List<string> { "Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Emre");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            Console.ReadKey();
        }
    }
}
