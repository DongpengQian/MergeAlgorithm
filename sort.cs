using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeAlgorithm
{
    public class Sort
    {
        public static void Merge(int[] a, int[] b, int[] c)
        {// both a and b must sorted, c stores the merged data
            int x = 0, y = 0, z = 0;
            // when both sorted arrays have elements, copy the smaller one
            // to array c, and advance the index of that array
            while (x < a.Length && y < b.Length)
            {
                if (a[x] < b[y])
                {
                    c[z++] = a[x++];
                }
                else
                {
                    c[z++] = b[y++];
                }
            }
            // Copy over remainder of the rest of a to c
            while (x < a.Length)
            {
                c[z++] = a[x++];
            }
            // Copy over remainder of the rest of b to c
            while (y < b.Length)
            {
                c[z++] = b[y++];
            }
        }
    }
}
