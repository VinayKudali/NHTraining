using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsLibrary;

namespace MathsLibrary
{
    public class AlgebraClass
    {
        public static int Factorial(int input)
        {
            
            if (input == 0)
                return 1;
            else if (input > 7)
                return -999;
            else if (input < 0)
                return -9999;
            else
            {
                int fact = 1;
                for (int i = 1; i<=input; i++)
                {
                    fact= fact*i;
                }
                return fact;
            }
                
        }
        public static string Palindrome(int input)
        {
           int temp = input;
            int sum = 0, rem;
            while(input>0)
            {
                rem=input%10;
                sum=sum*10+rem;
                input = input/10;
            }
            if(temp==sum)
                return "Palindrome";
            else
                return "Not Palindrome";
        }
    }
}
