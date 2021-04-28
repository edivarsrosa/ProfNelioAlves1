using System;
using System.Globalization;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE NOME SEXO IDADE ALTURA:");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

                
            Console.WriteLine("VOCÊ DIGITOU: ");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
