﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitilyTypedLocal
{
    class ImplicitilyTypedLocal
    {
        static void Main(string[] args)
        {
            var i = 5;
            var s = "hello";
            var d = 1.0;
            Console.WriteLine("i*i: " +i * i);
            Console.WriteLine("s in upper case:" + s.ToUpper());
            Console.ReadLine();
        }
    }
}
