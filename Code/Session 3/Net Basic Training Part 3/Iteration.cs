﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Basic_Training_Part_3
{
    public class Iteration
    {
        public void SimpleForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number is :{0}", i);
            }
        }

        public void SimpleForEachLoop()
        {
            string[] books = {"Data Structure", "Logical Design", "Data Communication"};

            //for (var i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine(books[i]);
            //}

            foreach (var s in books)
            {
                Console.WriteLine(s);
            }
        }

        public void SimpleWhile()
        {
            int i = 10;
            Console.WriteLine("Inside While Method;");

            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void SimpleDoWhile()
        {
            int i = 10;
            Console.WriteLine("Inside Do/While Method;");
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
        }

    }
}
