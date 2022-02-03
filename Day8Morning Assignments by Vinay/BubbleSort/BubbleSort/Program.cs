using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 7, 5, 9, 1 };
            int temp ;
            for (int i=0; i<=a.Length-1; i++)
            {
                for (int j=0; j<=a.Length-i-1;i++)
                {
                    if (a[j] > a[j+1])
                    {
                        temp = a[j+1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
          
                }
                foreach (var v in a)
                    Console.WriteLine(v);
                Console.ReadLine();


            }
                

        }
    }
    
}
