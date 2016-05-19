using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Framework.Retangulo ret1 = new Framework.Retangulo { Altura = 10, Largura = 10 };
            Framework.Retangulo ret2 = new Framework.Retangulo { Altura = 20, Largura = 20 };
            Framework.Circulo cir1 = new Framework.Circulo { Raio = 10 };
            Object[] formas = new Object[] { ret1, ret2, cir1 };
            Framework.Area area = new Framework.Area();
            Console.WriteLine(area.CalculaArea(formas));
            Console.ReadKey();
        }
    }
}
