using System;
using System.Globalization;

namespace Concatenação
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784; //DECLAREI UMA VARIÁVEL
            int y = 32;//DECLAREI UMA VARIÁVEL TIPO INT 
            string z = "Maria";//STRING PARA PALAVRAS E FRASES E DEVE SER COLOCADA ENTRE ASPAS DUPLAS
            char w = 'F';//OBSERVE QUE A VARIÁVEL TIPO CHAR É COLOCADA EM ASPAS SIMPLES E ARMAZENA APENAS UM CARACTER

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);//AQUI ESTOU CONCATENANDO A PALAVRA INICIAL + A VARIÁVEL
            Console.WriteLine();//LINHA EM BRANCO
            Console.WriteLine("O valor do troco é " + x + " reais ");//AQUI ESTOU CONCATENANDO A FRASE INICIAL + A VARIÁVEL + A PALAVRA FINAL
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais ");//AQUI ESTOU DETERMINANDO QUE SEJA APRESENTADO APENAS DUAS CASAS DECIMAIS
            Console.WriteLine();
            Console.WriteLine("agora observe o valor com o recurso InvariantCulture: \n " + x.ToString("F5", CultureInfo.InvariantCulture));//AQUI ESTOU UTILIZANDO DOIS RECURSOS ADICIONAIS, TOSTRING E F5 PARA EXIBIR CINCO CASAS DECIMAIS E MAIS O PONTO ATRAVES DO INVARIANTCULTURE

            Console.WriteLine("A cliente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.ReadLine();
        }
    }
}
