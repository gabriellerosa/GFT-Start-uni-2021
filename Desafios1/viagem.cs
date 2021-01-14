using System;
using static System.Math;

class Viagem {
    static void Main(string[] args) {

        string[] km = Console.ReadLine().Split(" ");
        int h = Int32.Parse(km[0]);
        int velocidade = Int32.Parse(km[1]);

        double x = 12;
        double litro = (h * velocidade);
        double total = litro/x;

        Console.WriteLine(total.ToString("N3"));
    }
}