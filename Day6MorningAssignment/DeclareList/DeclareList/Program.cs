using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0;
       
            data.Add(19);
            data.Add(16);
            data.Add(13);
            data.Add(37);
            foreach(var d in data)
                sum = sum + (int)d;
            Console.WriteLine(sum);
            
            Console.ReadLine();
        }
    }
}
