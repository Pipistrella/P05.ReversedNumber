using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ReversedNumber
    {
        static string ReverseNumber(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse( charArray );
            return new string(charArray);
        }

        static void Main()
        {
            Console.WriteLine("Enter the number to reverse");
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumber(number));
        }
    }

