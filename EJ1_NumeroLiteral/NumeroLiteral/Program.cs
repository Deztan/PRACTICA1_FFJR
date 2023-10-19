using NumeroLiteral.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ingrese un numero:");
        int n =  int.Parse(Console.ReadLine());
        Console.WriteLine("el numero es: "+Literal.nlite(n));
    }
}