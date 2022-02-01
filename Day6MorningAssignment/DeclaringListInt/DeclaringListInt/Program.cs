using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringListInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0, sum1=0, sum2 =0, temp;


            //Read Thwe data From User
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine("Enter Any Number");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }

                //Print the sum using For Loop
                for (int i = 0;i< data.Count; i++)
                
                    sum = sum + data[i];
                    Console.WriteLine("sum is "+  sum);

                //print the sum using ForEach Loop
                foreach (var v in data)
                    sum1 = sum1 + v;
                    Console.WriteLine("sum is " + sum1);
                    
                //print the sum using Lambda Expression
                data.ForEach(p=> sum2 =sum2+p);
                Console.WriteLine("sum is " + sum2);
                Console.ReadLine();



                    

            

        }
    }
}
