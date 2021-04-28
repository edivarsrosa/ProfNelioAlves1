using System;

namespace EntradaDeDados1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite Bom Dia!");
            string frase = Console.ReadLine();
            Console.WriteLine("você digitou: " + frase);

            Console.WriteLine("Agora traduza RED: ");
            string x=Console.ReadLine();
            Console.WriteLine("Traduza GREEN: ");
            string y = Console.ReadLine();
            Console.WriteLine("Traduza BLUE: ");
            string b = Console.ReadLine();

            Console.WriteLine(" Agora Digite Três legumes: ");

            
            string[] vet = Console.ReadLine().Split(' ');//os colchetes indicam que será um vetor //precisa do espaço em branco dentro das aspas simples
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Observe abaixo suas traduções: ");
            Console.WriteLine(" RED: " + x + " RESPOSTA CORRETA: VERMELHO ");
            Console.WriteLine(" GREEN: " + y + " RESPOSTA CORRETA: VERDE ");
            Console.WriteLine(" BLUE: " + b + " RESPOSTA CORRETA: AZUL ");
            Console.WriteLine();
            Console.WriteLine("Observe os três legumes que você inseriu: ");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.WriteLine(" Fim do Programa.");
            

        }
    }
}
