using System;

namespace Alg01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poadj a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Poadj b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Poadj c: ");
            float c = float.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine(delta);

            if (delta == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("Pierwiastek podwójny Xo " + x);
            }
            else
            {
                if (delta > 0)
                {
                    double x1 = -b - Math.Sqrt(delta) / 2 * a;
                    double x2 = -b + Math.Sqrt(delta) / 2 * a;

                    Console.WriteLine("Dwa pierwiastki rzeczywiste x1,x2 " + x1 + " " + x2);
                    
                }
                else
                {
                    double x1 = -b - Math.Sqrt(delta) / 2 * a;
                    double x2 = -b + Math.Sqrt(delta) / 2 * a;
                    Console.WriteLine("Dwa pierwiastki zespolone x1,x2");
                }
            }
        }
    }
}
