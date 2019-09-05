using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_9
{
    class Point
    {
        public int x;
        public int y;
        public Point (int xval, int yval)
        {
            x = xval;
            y = yval;
        }
    }
    class Swap
    { 
        public static void SwapPoints<SwapPoints>(ref SwapPoints x, ref SwapPoints y)
        {

            SwapPoints tempswap = x;
            x = y;
            y = tempswap;
        }

    }
}

