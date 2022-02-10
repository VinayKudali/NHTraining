using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project2NormalProperties
{
    class SimpleInterest
    {
        //Author: Vinay Kudali
        //Purpose Creating Class By using Normal Properties and Auto-Implemented Properties
        private int principleamount;
        private int annualRate;
        private int time;
        private int Interest;
        //Normal Properties
        public int Principleamount
        {
            set
            {
                principleamount = value;
            }
        }
        public int AnnualRate
        {
            set
            {
                AnnualRate = value;
            }
        }
        public int Time
        {
            set
            {
                time = value;
            }
        }
        public int interest
        {
            get
            {
                return Interest = principleamount * annualRate * time / 100;
            }
        }
        //Auto-Implemented Properties
        public int AutoImplementedInterest
        {
            get
            {
                return Interest = principleamount * annualRate * time / 100;
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                SimpleInterest s = new SimpleInterest();
                s.principleamount = 10000;
                s.annualRate = 4;
                s.time = 2;
                Console.WriteLine(s.interest);
                Console.WriteLine(s.AutoImplementedInterest);
                Console.ReadLine();
            }
        }
    }
}
