using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Author:         Caio Marteli
Creation Date:  06/09/2017
Version:        1.0
*/


namespace Algebraic
{
    public class Arithmetic
    {
        public static double sqrt(double a)
        {
            return Math.Sqrt(a);
        }
        public static double cubert(double a)
        {
            return Math.Pow(a,(1.0/3.0));
        }
        public static double inversert(double a)
        {
            return Math.Pow(a,-1);
        }
    }
}
