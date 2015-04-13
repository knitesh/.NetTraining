using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net_Basic_Training_Part_3;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var objDataType = new DataType();
            objDataType.TypeInference();

            System.Console.ReadLine();
        }
    }
}
