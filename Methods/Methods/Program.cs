using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Calc.Add(1, 2, 3, 4);
        }
    }

    class Point
    {
        // use params key work to accept an array of numbers 
        // allows you to not initialize an array when being called so no .Add(new int[]{1, 2, 3}); 
        public static int Add(params int[] numbers)
        {

        }

    }


}
