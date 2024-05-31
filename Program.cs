using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //uses backslash \\ to represent single back slash
            string myString = " Go to D:\\ drive";

            //uses backslash before each double quote to allow a string hold a string inside a the string
            string myString1 = "My  \"name is\"Diana";

            //uses \n to print in a new line
            string myString2 = "The C# guide contains articles, tutorials, and code samples to help you get \n started with C# and the .NET";

            // .Format() used to replace the 0 inside the callibraces with Wambo
            string myString3 = String.Format("{0}", "Wambo");

            string myString4 = String.Format("Make: {0} (Model: {1})", "CX-5", "765li");
            //formatting string to currency
            string myString5 = String.Format("{0:C}", 124.52);
            //formating large numbers into thousands, hundreds etc
            string myString6 = String.Format("{0:N}", 1234567890);

            //formatting percentage
            string myString7 = String.Format("{0:P}", .132);

            //formatting phone numbers
            string myString8 = String.Format("phone number: {0:(###) ### ####}", +254745617890);

            Console.WriteLine(myString);
            Console.WriteLine(myString1);
            Console.WriteLine(myString2);
            Console.WriteLine(myString3);
            Console.WriteLine(myString4);
            Console.WriteLine(myString5);
            Console.WriteLine(myString6);
            Console.WriteLine(myString7);
            Console.WriteLine(myString8);

            string myString9 = " ";
            for (int a = 0; a < 150; a++)
            {
            myString9 = myString9 + "--"  + a.ToString();
            }
            Console.WriteLine(myString9);
            Console.ReadLine();

            StringBuilder myString10 = new StringBuilder();
            for (int a = 0; a < 150; a++)
            {
                myString10.Append("--");
                myString10.Append(a);
            }
            Console.WriteLine(myString10.ToString());
            Console.ReadLine();
           
            string myString11 = "I am enjoying coding C# language";
             = myString11.Substring(10, 15);
            myString11 = myString11.ToUpper();
            Console.WriteLine(myString11);
            Console.ReadLine();

        }
    }
}
