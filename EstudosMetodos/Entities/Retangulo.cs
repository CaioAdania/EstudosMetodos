﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstudosMetodos.Entities
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        public override string ToString()
        {
            return "Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPerimetro = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDiagonal = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
