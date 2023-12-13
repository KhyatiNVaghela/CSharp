/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };


    class Program
    {
        static void Main(string[] args)
        {
            Int32 num1 = 30;
            double num2 = 30.33;
            Boolean status = true;
            String message = "Hello";

            Int32 val1 = 10, val2 = 20;
            //bool status = true;

            Int32 value = 3, i = 0;

            //integer datatype Example
            Console.WriteLine(num1);

            //double datatype Example
            Console.WriteLine(num2);

            //boolean datatype Example
            Console.WriteLine(status);

            //string datatype Example
            Console.WriteLine(message);

            //enum Example
            Console.WriteLine(Days.Sun);

            //combine result variables using operator Example 
            Console.WriteLine(message + num1);

            //operators Example
            Console.WriteLine(val1 + val2);
            Console.WriteLine(val1 < val2);
            Console.WriteLine(!(status));

            //if else Example
            if (val1 < 10)
            {
                Console.WriteLine("Value is less than 10");
            }
            else
            {
                Console.WriteLine("Value is greater than 10");
            }

            //switch case Example
            switch (value)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Value is 2");
                    break;
                default:
                    Console.WriteLine("value is different");
                    break;
            }

            //while loop Example
            while (i < value)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            //for loop Example
            for (Int32 i1 = 0; i1 < 3; i1++)
            {
                Console.WriteLine(i1);
            }

            //array Example
            Int32[] value1;
            value1 = new Int32[3];

            value1[0] = 1;
            value1[1] = 2;
            value1[2] = 3;

            Console.WriteLine(value1[0]);
            Console.WriteLine(value1[1]);
            Console.WriteLine(value1[2]);


            Console.ReadKey();
        }
    }
}
