using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objec_Oriented__Programs
{
    internal class Reverse_String
    {
       

        internal static void Reverse_string()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            Console.WriteLine(result);
        }
    }
}
