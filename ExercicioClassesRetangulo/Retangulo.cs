using System;
using System.Globalization;

namespace ExercicioClasseRetangulo {
    internal class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro() {
            double perimetro = (Largura + Altura) * 2;
            return perimetro;
        }

        public double Diagonal() {
            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return diagonal;
        }
    }
}