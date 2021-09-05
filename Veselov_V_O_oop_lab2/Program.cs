using System;

namespace Veselov_V_O_oop_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ellipse ellipse = new Ellipse(3, 5);
            Ellipse ellipse = new Ellipse();
            ellipse.setRadiusA(3);
            ellipse.setRadiusB(5);
            double square = ellipse.getSquare();
            Console.WriteLine("Ellipse square is " + square);

            //instead of system.pause()
            Console.ReadLine();
        }
    }
}
