using System;
using System.Globalization;//ADICIONEI ESTA BIBLIOTECA PARA FUNCIONAR O ULTIMO COMANDO ONDE DETERMINO A QUANTIDADE DE CASAS DECIMAIS DEVEM SER EXIBIDAS PELO PROGRAMA AO IMPRIMIR NA TELA A VARIÁVEL QUE DECLAREI EM DOUBLE

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;//AQUI EU CRIEI UMA VARIÁVEL TIPO DOUBLE(QUE OFERECE MAIS PRECISÃO QUE A VARIÁVEL TIPO FLOAT, COLOQUEI O NOME DE X E DEFINI SEU VALOR COM O NÚMERO

            Console.WriteLine("Nesse Programa vamos escrever na tela o valor de uma variável com ponto flutuante, \n" +//AQUI ESTOU IMPRIMINDO ALGUMAS INFORMAÇÕES NA TELA PARA O USUÁRIO SABER O QUE ESTA ACONTECENDO
                "ou seja, uma variável double. Observe Abaixo como ela é exibida apenas utilizando o comando Console.WriteLine");
            Console.WriteLine();//AQUI ESTOU FAZENDO LINHA EM BRANCO PARA SEPARAR OS CONTEÚDOS
            Console.WriteLine(x);//EXIBIR A VARIÁVEL QUE EU CRIEI NA TELA
            Console.WriteLine();//LINHA EM BRANCO
            Console.WriteLine("Agora observe quando adicionamos o comando ToStringF2");//IMPRIMIR A VARIÁVEL QUE CRIEI MAS EXIBINDO APENAS DUAS CASAS DECIMAIS
            Console.WriteLine(x.ToString("F2"));//PARA EXIBIR APENAS DUAS CASAS DECIMAIS UTILIZEI O COMANDO TOSTRING E LIMITEI A QUANTIDADE DE CASAS DECIMAIS COM O COMANDO F2
            Console.WriteLine();//LINHA EM BRANCO
            Console.WriteLine("Abaixo utilizamos o comando ToStringF4, observe a quantidade de casas decimais exibidas:");//OUTRA MENSAGEM PARA O USUÁRIO SABER O QUE ESTA ACONTECENDO
            Console.WriteLine();//LINHA EM BRANCO
            Console.WriteLine(x.ToString("F4"));//AQUI ESTOU UTILIZANDO MAIS COMANDOS E O PROGRAMA VAI EXIBIR QUATRO CASAS DECIMAIS DEVIDO AO USO DO COMANDO F4
            Console.WriteLine();//LINHA EM BRANCO
            Console.WriteLine("Podem haver erros em relação ao uso do PONTO  ou VÍRGULA, nesses \n" +//OBSERVE QUE ESTOU USANDO O COMANDO \N PARA EFETUAR UMA QUEBRA DE LINHA
                "casos utilizaremos um recurso adicional chamado CultureInfo.InvariantCulture que é \n" +//OBSERVE QUE QUANDO UTILIZO A QUEBRA DE LINHA DEVO CONCATENAR OS TEXTOS COM SINAL DE + E NOVAS ASPAS DUPLAS
                "adicionado ao final da linha de comando. Observe porém que esse recurso \n" +//O COMANDO \N AJUDA NA FORMATACAO DOA TEXTO QUE SERÁ EXIBIDO AO USUÁRIO
                "só funciona quando você declara no início do programa using System.Globalization. \n" +//A CONCATENAÇÃO DEVE SER OBSERVADA PARA NAO HAVER ERROS
                "Observe o resultado abaixo: ");//SEMPRE FINALIZAR A LINHA DE COMANDO COM O SINAL DE PONTO E VIRGULA
            Console.WriteLine();//LINHA EM BRANCO
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));//AGORA ADICIONEI MAIS UM COMANDO PARA DETERMINAR A EXIBIÇÃO COM O PONTO COMO SEPARADOR DAS CASAS DECIMAIS. ESSE É O PADRÃO GLOBAL CONFORME DEFINIMOS
        }
    }
}
