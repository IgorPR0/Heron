using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
        
        double a, b, c;
        double perimetro, area;

        Console.Write("Digite o valor de A: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        c = double.Parse(Console.ReadLine());
            
        perimetro = (a + b + c)/2;
        area = Math.Sqrt(perimetro * (perimetro - a) * (perimetro -b) * (perimetro -c));
        Console.WriteLine("semiperimetro é igual {0}", perimetro);
        Console.WriteLine("area é igual {0}", area);
        
        }
    }
}
