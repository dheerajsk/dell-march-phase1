using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class EvenOddProgram
    {
        public void Do()
        {
            Console.WriteLine("Please enter a number to find if odd or even, or enter 0 to exit");
            bool keepReading = true;
            while (keepReading)
            {
                string input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                if (num == 0)
                {
                    break;
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine("This is an even number");
                }
                else
                {
                    Console.WriteLine("This is an odd number");
                }
            }
        }
    }
}
