using System;

namespace EstudoDotNet
{
    class Program
    { 
         static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu nome:");
            i1.Nome = Console.ReadLine();

            Console.WriteLine("Insira sua altura em metros:");
            i1.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira seu peso em quilogramas:");
            i1.Peso = Convert.ToDouble(Console.ReadLine());

            Individuo i1 = new Individuo();

            Console.WriteLine("{0}, seu peso é {1}kg, sua altura é {2}m", i1.Nome, i1.Altura, i1.Peso);
            Console.WriteLine("Seu IMC é {0}", i1.CalculoImc());
            Console.WriteLine(i1.FaixaAtual());
            Console.WriteLine(i1.PesoIdeal());
        }
    }
}