using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project5
{


    //Author: Vinay Kudali
    //Program: Own class with own variables and calling for,foreach,Lamda,LINQ
    class Institute
    {
        public string name;
        public string location;
        public string type;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Institute> off = new List<Institute>()
                {
                    new Institute() { name = "Jspiders", location = "Kphb", type = "Full stack java" },
                    new Institute() { name = "Qspiders", location = "Panjagutta", type = " Testing " },
                    new Institute() { name = "Manya", location = "Bangalore", type = "Python" },
                    new Institute() { name = "Texas", location = "kukatpally", type = "IELTS" },
                    new Institute() { name = "CV corp", location = "raidurg", type = "java" }
                };
            //for loop
            for (int i = 0; i < off.Count; i++)
            {
                Console.WriteLine($"name={off[i].name}, location={off[i].location}, type={off[i].type}");
            }

            //foreach loop
            foreach (var o in off)
            {
                Console.WriteLine($"name={o.name}, location={o.location}, type={o.type}");
            }

            //Lamda Expression

            off.ToList().ForEach(o => Console.WriteLine($"name={o.name}, location={o.location}, type={o.type}"));

            //LINQ Query
            var result = from o in off
                         select o;
            result.ToList().ForEach(o => Console.WriteLine($"name={o.name}, location={o.location}, type={o.type}"));

            Console.ReadLine();



        }
    }
}
