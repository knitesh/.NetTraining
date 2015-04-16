using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Basic_Training_Part_3
{
    public class GenericSwap
    {
        private static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));

            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}


/*
int a=10,b=20;
Swap<int>(ref a,ref b);
 */
