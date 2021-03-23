using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    delegate int CalcDelegate(int a, int b);
    class Calc
    {
        public static int Add(int a, int b) => a + b;
        public static int Mult(int a, int b) => a * b;
    }
}
