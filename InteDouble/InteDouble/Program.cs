using System;

namespace InteDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;

            a = 5;
            b = 2;
            
            resultado = (double)a / b;//OBSERQUE QUE O RESULTADO SERA INTEIRO E PERDERA INFORMACOES //SERA NECÉSSÁRIO FAZER CASTING


            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}
