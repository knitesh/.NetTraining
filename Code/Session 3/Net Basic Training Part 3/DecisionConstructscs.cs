using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Basic_Training_Part_3
{
    public class DecisionConstructscs
    {
        private void SimpleSwitch(int integerA)
        {
            switch (integerA)
            {
                case 1:
                    Console.WriteLine("integerA =1");
                    break;
                case 2:
                    Console.WriteLine("integerA =2");
                    break;
                case 3:
                    Console.WriteLine("integerA =3");
                    break;
                default:
                    Console.WriteLine("integerA is not 1,2, or 3");
                    break;
            }
        }

        public void SimpleIfElse()
        {
            Console.WriteLine("Type in a string");
            string input = Console.ReadLine();
            
            if (input == "")
            {
                Console.WriteLine("You typed in an empty string.");
            }
            else if (input.Length < 5)
            {
                Console.WriteLine("The string had less than 5 characters.");
            }
            else if (input.Length < 10)
            {
                Console.WriteLine("The string had at least 5 but less than 10 Characters.");
            }

            Console.WriteLine("The string was " + input);
        }
    }
}
   
