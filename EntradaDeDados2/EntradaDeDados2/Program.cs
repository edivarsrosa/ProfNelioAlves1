using System;
using System.Globalization;

namespace EntradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("SEJA BEM VINDO! \n  DIGITE SEU NOME: ");
            string nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("AGORA FAREMOS MAIS ALGUMAS PERGUNTAS: \n POR FAVOR INSIRA OS DADOS A SEGUIR... ");
            Console.WriteLine("SUA IDADE: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("ALTURA: ");
            string altura = (Console.ReadLine());

            Console.WriteLine();

            Console.Write("PESO: ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("SEXO: ");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("AGORA SERÁ NECESSÁRIO INSERIR SEU ENDEREÇO \nINSIRA OS DADOS A CADA ETAPA PARA O ARMAZENAMENTO CORRETO...");
            Console.Write("RUA: ");
            string rua = Console.ReadLine();
            Console.Write("NUMERO: ");
            string numero = Console.ReadLine();
            Console.Write("COMPLEMENTO (CASO VOCÊ MORE EM APARTAMENTO, BLOCO OU CASA, POR FAVOR INSIRA AQUI: ");
            string complemento = Console.ReadLine();
            Console.Write("BAIRRO, DISTRITO OU LOCALIDADE: ");
            string bairro = Console.ReadLine();
            Console.Write("CIDADE: ");
            string cidade = Console.ReadLine();
            Console.Write("CEP: ");
            string cep = Console.ReadLine();
            Console.Write("ESTADO: ");
            string uf = Console.ReadLine();
            Console.Write("PAÍS: ");
            string country = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("OBRIGADO! \nOBSERVE ABAIXO O BANCO DE DADOS QUE FOI CRIADO:");

            Console.WriteLine();

            Console.WriteLine($"{ nome} { idade} anos {altura}m SEXO:{sexo} {peso.ToString("F2", CultureInfo.InvariantCulture)}kg");
            Console.WriteLine();
            Console.WriteLine($"ENDEREÇO: {rua} {numero} {complemento}");
            Console.WriteLine(bairro);
            Console.WriteLine(cidade, uf, country);
            Console.WriteLine(cep);

            Console.ReadLine();
            

        }
    }
}
