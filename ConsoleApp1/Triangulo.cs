using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Triangulo {

        public double A;
        public double B;
        public double C;



        public static (double, double, double) PegarInfoTriangulo(int numeroTriangulo) {

            double a = 0, b = 0, c = 0;


            Console.WriteLine($"Entre com as medidas do {numeroTriangulo:F2}º Triangulo");

            try {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
            } catch(Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return (a, b, c);
        }

        public static double MaiorTriangulo(double a,double b) {
            return a > b ? a : b;
        }


        public static double AreaTriangulo(double a,double b,double c) {
            if(a + b > c && a + c > b && b + c > a) {
                double P = (a + b + c) / 2;
                return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            } else {
                Console.WriteLine("Erro: As medidas fornecidas não formam um triângulo válido.");
                return double.NaN;
            }
        }
    }
}
