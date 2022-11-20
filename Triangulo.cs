using System;
using System.Collections.Generic;
using System.Text;

namespace curso
{
    public class Triangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }


        public double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        { 
          return 2 * (Largura + Altura);             
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }


}
