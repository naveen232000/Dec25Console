using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dec25Console
{
    public class BinarySearch
    {
        public int[] GetArray()
        {
            int n ;
            Console.WriteLine("Enter Number Of elements in Array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {n} elements :");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) {
                try { arr[i] = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }  
            }
            Console.WriteLine("\nSorted Array");
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
         return arr;
        }
        public int BinaryScr(int[] arr,int ScrNum)
        {
            int first, mid, end;
            first= 0;
            end = arr.Length - 1;
            mid= (first+end)/2;
            while (first<=end) {
                if (arr[mid] == ScrNum) {
                    return mid;
                }
                else if (arr[mid]>ScrNum){
                    end= mid-1;
                    mid= (first+end)/2;
                }
                else  
                {
                    first = mid+1;
                    mid = (first + end) / 2;
                }
            }

            return -1;
        }
        

        
        static void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch();
            int[] arr = binarySearch.GetArray();
            while (true)
            {
                Console.WriteLine("\nEnter Search Number");
                int n=Convert.ToInt32(Console.ReadLine());
                int result = binarySearch.BinaryScr(arr, n);
                if (result != -1)
                {
                    Console.WriteLine($"Number {n} at index of {result}");
                }
                else
                {
                    Console.WriteLine($"Number {n} not found");
                }
            }
        }
    }
}
