using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcDelegate deleg = Calc.Add;
            Console.WriteLine(deleg(10,20));
            Console.WriteLine($"Delegate Method: {deleg.Method} ");
            Console.WriteLine($"Delegate Target: {deleg.Target ?? "Empty"} ");
        }
    }
}
