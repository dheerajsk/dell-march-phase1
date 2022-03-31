using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class ReverseString
    {
        public void Do()
        {
            Console.WriteLine("Please enter a string to reverse");
            string input = Console.ReadLine();

            int lastIndexOfInput = input.Length - 1;
            string reversedString = string.Empty;
            for (int i = lastIndexOfInput; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
                reversedString += input[i];
            }
            Console.WriteLine("Result: " + reversedString);
        }
    }
}
