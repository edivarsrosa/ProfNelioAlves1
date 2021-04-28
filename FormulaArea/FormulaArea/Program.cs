using System;

namespace FormulaArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, B, h, area;

            b = 6.0;//QUANDO FOR DECLARAR VARIÁVEL TIPO DOUBLE, UTILIZE O .0 PONTO ZERO APOIS O NUMERO PARA DETERMINAR O PONTO FLUTUANTE E REFORÇAR QUE A VARIAVEL NAO É INT
            B = 8.0;
            h = 5.0;
            area = (b + B) / 2.0 * h;



            Console.WriteLine(area);

            Console.ReadLine();


            /*
             * OBSERVE NA ANOTAÇÃO ABAIXO COMO SERIA ESSA MESMA FORMULA UTILIZANDO VARIÁVEIS TIPO FLOAT
             * float b, B, h, area;

            b = 6f;//QUANDO FOR DECLARAR VARIÁVEL TIPO DOUBLE, UTILIZE O .0 PONTO ZERO APOIS O NUMERO PARA DETERMINAR O PONTO FLUTUANTE E REFORÇAR QUE A VARIAVEL NAO É INT
            B = 8f;
            h = 5f;
            area = (b + B) / 2f * h;



            Console.WriteLine(area);

            Console.ReadLine();
             */
        }
    }
}
