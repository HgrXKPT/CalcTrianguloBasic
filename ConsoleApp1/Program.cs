using System;
class Program {

    static void Main(string[] args) {
        double a, b, c, TrianguloA, TrianguloB;
            (a, b, c) = PegarInfoTriangulo(1);
            TrianguloA = AreaTriangulo(a,b,c);

            (a, b, c) = PegarInfoTriangulo(2);
            TrianguloB = AreaTriangulo(a,b,c);
        

        Console.WriteLine($"Aréa do Triangulo A:{TrianguloA}, Triangulo B:{TrianguloB}");

        Console.WriteLine($"O maior triangulo é {MaiorTriangulo(TrianguloA, TrianguloB)}");

    }

    static (double, double, double) PegarInfoTriangulo(int numeroTriangulo) {
 
            double a = 0, b = 0, c = 0;


            Console.WriteLine($"Entre com as medidas do {numeroTriangulo}º Triangulo");

            try {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
            } catch(Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
        return (a, b, c); 
    }

        static double MaiorTriangulo(double a,double b) {
        return a > b ? a : b;
    }


    static double AreaTriangulo(double a,double b,double c) {
        if(a + b > c && a + c > b && b + c > a) {
            double P = (a + b + c) / 2;
            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        } else {
            Console.WriteLine("Erro: As medidas fornecidas não formam um triângulo válido.");
            return double.NaN;
        }
    }




}

