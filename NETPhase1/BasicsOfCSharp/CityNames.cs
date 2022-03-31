using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class CityNames
    {
        public static void Do()
        {
            //1.Create Array of string to store city names.
            string[] cities = { "Mumbai", "Pune", "Banglore", "Hyderabad", "Delhi" };

            // foreach(type key in array){ // Body of loop. }
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
