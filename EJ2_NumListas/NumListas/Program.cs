using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    static Boolean esmulde2(int num)
    {
        Boolean res = false;
            if (num % 2 == 0)
            {
                res = true;
            }
        return res;
    }
    static Boolean esmulde5(int num)
    {
        Boolean res = false;
        if (num % 5 == 0)
        {
            res = true;
        }
        return res;
    }
    static Boolean esprimo(int num)
    {
        Boolean res = false;
        int cont = 0;
        for (int i = 1; i <=num ; i++)
        {
            if (num%i==0)
                cont++;
        }
        if (cont == 2)
            res = true;
        return res;
    }
    static Boolean esperfecto(int num) 
    {
        int sumdiv = 1;
        for (int i = 2; i <= num; i++)
        {
            if (num%i==0)
            {
                sumdiv += i;
            }
        }
        return sumdiv == num;
    }
    private static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
       

        List<int> mulde2 = new List<int>();
        List<int> primo = new List<int>();
        List<int> mulde5 = new List<int>();
        List<int> perfecto = new List<int>();
        Console.WriteLine("¿Cuantos numeros desea añadir?");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("aniada "+n+" numeros");
        

        for (int i = 0; i < n; i++)
        {
            numeros.Add(int.Parse(Console.ReadLine()));
        }
        numeros = numeros.Distinct().ToList();
        n = numeros.Count;
        //multiplo de 2
        for (int i = 0; i <n ; i++)
        {
            if (esmulde2(numeros[i]))
            {
                mulde2.Add(numeros[i]);
            }
        }
        mulde2.Sort();
        //numero primo
        for (int i = 0; i < n; i++)
        {
            if (esprimo(numeros[i]))
            {
                primo.Add(numeros[i]);
            }
        }
        primo.Sort();

        //multiplo de 5
        for (int i = 0; i < n; i++)
        {
            if (esmulde5(numeros[i]))
            {
                mulde5.Add(numeros[i]);
            }
        }
        mulde5.Sort();

        //numero perfecto
        for (int i = 0; i < n; i++)
        {
            if (esperfecto(numeros[i]))
            {
                perfecto.Add(numeros[i]);
            }
        }
        perfecto.Sort();

        Console.WriteLine("Lista 1 (multiplos de 2): ");
        foreach (var item in mulde2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Lista 2 (Primos): ");
        foreach (var item in primo)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Lista 3 (multiplos de 5): ");
        foreach (var item in mulde5)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Lista 2 (Perfectos): ");
        foreach (var item in perfecto)
        {
            Console.WriteLine(item);
        }
    }
}