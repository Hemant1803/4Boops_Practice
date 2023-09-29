using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objec_Oriented__Programs
{
    internal class Max_Min
    {
        
internal static void max_min()
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, min, n;
            // size of the array
            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Maximum element = {0}", max);
      Console.WriteLine("Minimum element = {0}", min);
   }

}
    }
        
    }

