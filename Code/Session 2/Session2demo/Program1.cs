using System;
using System.Data.SqlClient;
using System.IO;

namespace Session2demo
{
    class Program1
    {
        public string Connection_string;
        private string Query;

        public string Connection_strings { get; set; }
        
        
        static void Main(string[] args)
        {
            Program1 obj = new Program1();
            obj.Print("Supernova");
            obj.Connection_string = "gfgfdgfdgfd";
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
            Console.ReadLine();

        }
    }
}
