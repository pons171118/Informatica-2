﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linea
{
    public class Linea2D : LineaAbstracta<Punto2D>
    {
        public override Punto2D[] Puntos { get; }

        public Linea2D(Punto2D[] puntos)
        {
            Puntos = puntos;
        }

        public override double Distancia(Punto2D punto1, Punto2D punto2)
        {
            double X2 = Math.Pow(punto2.X - punto1.X, 2);
            double Y2 = Math.Pow(punto2.Y - punto1.Y, 2);
            double distancia = Math.Sqrt(X2 + Y2);

            return distancia;
        }
    }
}
