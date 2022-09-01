using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    public class Rectangulo
    {
        public Vertice v1 { get; set; }
        public Vertice v2 { get; set; }
        public Vertice v3 { get; set; }
        public Vertice v4 { get; set; }

        public double GetArea()
        {
            double basx = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
            double altura = Math.Sqrt(Math.Pow(v4.x - v3.x, 2) + Math.Pow(v4.y - v3.y, 2));

            double Area = basx * altura;
            
            return Area;
        }

        public double GetPerimetro()
        {
            double basx = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
            double altura = Math.Sqrt(Math.Pow(v4.x - v3.x, 2) + Math.Pow(v4.y - v3.y, 2));

            double Perimetro = 2 * basx + 2 * altura;

            return Perimetro;
        }
    }
}
