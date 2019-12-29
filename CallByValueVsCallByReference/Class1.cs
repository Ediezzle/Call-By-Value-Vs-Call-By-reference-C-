using System;
using System.Collections.Generic;
using System.Text;

namespace CallByValueVsCallByReference
{
      class Class1
    {
        public static int add(params int[] array)
        {
            int sum = 0;
            foreach(int value in array)
            {
                sum += value;
            }
            return sum;
        }

       }
}
