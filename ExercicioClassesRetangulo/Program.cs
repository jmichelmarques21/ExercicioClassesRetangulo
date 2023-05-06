using System;
using System.Globalization;

namespace ExercicioClasseRetangulo {
    class Program {
        static void Main(string[] args) {

            /* Fazer um programa para ler os valores de largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua
             * área, perímetro e diagonal.*/

            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Área = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));






        }
    }
}