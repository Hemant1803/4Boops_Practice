using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objec_Oriented__Programs
{
    internal class Find_Sum_Of_All_Num
    {
       
internal static void find_Sum_Of_All_Num()
        {
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
    Console.WriteLine("Sum is= "+sum);       
     }  
    }
}
