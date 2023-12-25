using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25Console
{
    public class LinearSearch
    {
        public int LinearSer(int[] num,int FindNum) {
        
        for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == FindNum)
                {
                    return i+1;
                }
            }
        return -1;
        }

        static void Main(string[] args)

        {
            LinearSearch linearSearch = new LinearSearch();
            int[] arr = { 51, 42, 63, 94, 25, 36, 47, 78, 19 };
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            int n, ret;
            Console.WriteLine("\nEnter a Number to search" );
            n = Convert.ToInt32(Console.ReadLine());
            ret = linearSearch.LinearSer(arr, n);
            if (ret!=-1)
            {
                Console.WriteLine($"The Number {n} at {ret}");
            }
            else
            {
                Console.WriteLine($"The Number {n} not Found");
            }
            Console.ReadLine(); 

        }
    }
}
