using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringListString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("vinay");
            data.Add("vamsi");
            data.Add("arun");
            data.Add("abhi");
            data.Add("vamsi");
            //printing values using for loop
            for (int i=0;i<data.Count;i++)
            {
                Console.WriteLine(data[i]);
            }

            //printing values using foreach loop
            foreach (var s in data)
            {
                Console.WriteLine(s);
            }
            //print using lambda expression
            data.ForEach (p=> Console.WriteLine(p));
            Console.ReadLine();
            
        }
    }
}
