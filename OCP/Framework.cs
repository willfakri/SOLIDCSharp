using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Framework
    {
        public class Retangulo
        {
            public double Altura { get; set; }
            public double Largura { get; set; }

        }

        public class Circulo
        {
            public double Raio { get; set; }
        }

        public class Area
        {
            public double CalculaArea(Object[] formas)
            {
                double area = 0;
                foreach(var forma in formas)
                {
                    if(forma is Retangulo)
                    {
                        Retangulo retangulo = forma as Retangulo;
                        area += retangulo.Altura * retangulo.Largura;
                    }
                    else if(forma is Circulo)
                    {
                        Circulo circulo = forma as Circulo;
                        area += circulo.Raio * circulo.Raio * Math.PI;
                    }                    
                }

                return area;
            }
        }
    }
}