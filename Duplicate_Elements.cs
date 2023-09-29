using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objec_Oriented__Programs
{
    internal class Duplicate_Elements
    {
        public void duplicate_elements() 
        {
            {
                int[] arr = { 1, 2, 3, 4, 1, 2, 3, 5, 6, 7, 8, 9, 2 };

                Dictionary<int, int> elementCount = new Dictionary<int, int>();

                foreach (int num in arr)
                {
                    if (elementCount.ContainsKey(num))
                    {
                        elementCount[num]++;
                       
                    }
                    else
                    {
                        elementCount[num] = 1;
                       
                    }
                }

                int totalDuplicates = elementCount.Values.Count(count => count > 1);
               

                Console.WriteLine($"Total number of duplicate elements: {totalDuplicates}");
            }

        }
    }
}
