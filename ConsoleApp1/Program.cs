using System;
using ConsoleApp1;
class Program {


    static void Main(string[] args) {
        Triangulo x, y;
        x = new Triangulo();
        y = new Triangulo();

        double a, b, c, TrianguloA, TrianguloB;
            (x.A, x.B, x.C) = Triangulo.PegarInfoTriangulo(1);
            TrianguloA = Triangulo.AreaTriangulo(x.A,x.B,x.C);

            (y.A, y.B, y.C) = Triangulo.PegarInfoTriangulo(2);
            TrianguloB = Triangulo.AreaTriangulo(y.A,y.B,y.C);
        

        Console.WriteLine($"Aréa do Triangulo A:{TrianguloA}, Triangulo B:{TrianguloB}");

        Console.WriteLine($"O maior triangulo é {Triangulo.MaiorTriangulo(TrianguloA, TrianguloB)}");

    }

    




}

