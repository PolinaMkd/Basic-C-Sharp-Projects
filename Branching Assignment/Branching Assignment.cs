using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

 

namespace Package_Express

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

 

            // Prompting for package weight

            Console.Write("Please enter the package weight: ");

            float weight = float.Parse(Console.ReadLine());

 

            // Checking if the package weight exceeds the limit

            if (weight > 50)

            {

                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

                Console.ReadLine();

                return;

               

            }

 

            // Prompting for package dimensions

            Console.Write("Please enter the package width: ");

            float width = float.Parse(Console.ReadLine());

 

            Console.Write("Please enter the package height: ");

            float height = float.Parse(Console.ReadLine());

 

            Console.Write("Please enter the package length: ");

            float length = float.Parse(Console.ReadLine());

 

            // Checking if the dimensions total exceeds the limit

            float totalDimensions = width + height + length;

            if (totalDimensions > 50)

            {

                Console.WriteLine("Package too big to be shipped via Package Express.");

                Console.ReadLine();

                return;

            }

 

            // Calculating the quote

            float product = width * height * length;

            float quote = (product * weight) / 100;

 

            // Displaying the quote as a dollar amount

            Console.WriteLine($"Your estimated total for shipping this package is:  ${quote:F2}");

            Console.WriteLine("Thank you!");

            Console.ReadLine();

        }

    }

}

 