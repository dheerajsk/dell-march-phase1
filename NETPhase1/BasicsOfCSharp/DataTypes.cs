using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class DataTypes
    {
        // Types of Methods
        // 1. Instance methods - You can invoke them using objects/instances.
        // 2. Static Methods - Invoke using class name
        public void Do()
        {

            // Numeric values
            // int or int32 - 4 byte
            int num = 20;
            Console.Write(num);

            // 1 byte
            char c = 's';
            Console.Write(c);

            // 4 byte
            float num2 = 20.01F;
            Console.WriteLine(num2);

            // int64 - 8 byte
            long num3 = 787576464657;
            Console.WriteLine(num3);

            // 8 byte
            double num4 = 1232323323.78567;
            Console.WriteLine(num4);

            // 16 byte
            decimal num5 = 12345678123456789;
            Console.WriteLine(num5);

            string str = "This is a text";
            Console.WriteLine(str);
            // Sealed class - You can't inherit sealed class.

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
        }
    }
}
