using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinayKudaliLibrary
{
    //VinayKudaliBaseClass
    public class VinayKudaliBaseclass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;

        public void ReadData()
        {
            a = 9;
            b = 8;
            c = 7;
            d = 6;
            e = 5;
        }

    }
    //VinayKUdaliDerivedClass
    public class VinayKudaliDerivedClass: VinayKudaliBaseclass
    {
        public void ReadDerivedData()
        {
            a = 9;
          //b = 8; //Derived Class Can't access Private variable
            c = 7;
            d = 6;
            e = 5;
        }
    }
    //VinayKudaliOtherClass
    public class VinayKudaliOtherClass
    {
        public void ReadOtherData()
        {
            VinayKudaliBaseclass vkbc = new VinayKudaliBaseclass();
            vkbc.a = 9;
         // vkbc.b = 8; Other Class Can not Access private variable
         // vkbc.c = 7; Other class Can not access Protected Variable
            vkbc.d = 6;
            vkbc.e = 5;
        }

    }
}
