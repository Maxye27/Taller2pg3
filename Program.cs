using System;
namespace Taller2pg;
    internal class Program
    {
    private static void Main(string[] args)
    {
        persona perso = new persona();
        Console.WriteLine("Digite su nombre: ");
        perso.Nombre = Console.ReadLine();
        Console.WriteLine("Digite su peso: ");
        perso.Peso = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite su altura: ");
        perso.Altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite su edad: ");
        perso.Edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite su genero: ");
        perso.Genero = Console.ReadLine();
        Console.WriteLine("Digite su ocupacion: ");
        perso.Ocupacion = Console.ReadLine();
        Console.WriteLine("Digite su ciudad: ");
        perso.Ciudad = Console.ReadLine();
        Console.WriteLine("Digite su estado civil: ");
        perso.Estadocivil = Console.ReadLine();

        Console.WriteLine("Su nombre es: " + perso.Nombre);
        Console.WriteLine("Su peso es: " + perso.Peso);
        Console.WriteLine("Su altura es: " + perso.Altura);
        Console.WriteLine("Su edad es: " + perso.Edad);
        Console.WriteLine("Su genero es: " + perso.Genero);
        Console.WriteLine("Su ocupacion es: " + perso.Ocupacion);
        Console.WriteLine("Su ciudad es: " + perso.Ciudad);
        Console.WriteLine("Su estado civil es: " + perso.Estadocivil);

        Console.WriteLine("Su indice de masa corporal es: " + perso.imc());
        Console.WriteLine(perso.ClasificarIMC());
    }
    }
