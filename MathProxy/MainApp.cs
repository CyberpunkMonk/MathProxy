using System;

namespace MathProxy {
    class MainApp {
        static void Main() {
            MathProxy proxy = new MathProxy();
            //Do the math
            Console.WriteLine($"4+2={ proxy.Add(4,2)}");
            Console.WriteLine($"4-2={ proxy.Sub(4,2)}");
            Console.WriteLine($"4*2={ proxy.Mul(4,2)}");
            Console.WriteLine($"4/2={ proxy.Div(4,2)}");
            //wait for user
            Console.ReadKey();
        }
    }
}
