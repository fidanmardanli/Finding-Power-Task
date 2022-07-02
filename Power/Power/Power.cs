using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public static class Power
    {
        public static int FindingPower(this int num, int num2)
        {
            int count = 1;
            for (int i = 1; i <= num2; i++)
                count = count * num;

            return count;
            
        }
    }
} 
       
