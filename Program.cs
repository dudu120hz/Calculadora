using System;
using Calculadora.Classes;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Calculadora");
            Console.WriteLine("\n As operações disponíveis são:");
            Console.WriteLine(" - adição");
            Console.WriteLine(" - subtração");
            Console.WriteLine(" - multiplicação");
            Console.WriteLine(" - divisão");
            Console.Write(" Qual das operações você quer fazer? ");
            string perguntaOperacao = Console.ReadLine();
            perguntaOperacao = perguntaOperacao.ToLower();

            Calculo c = new Calculo();

            if(perguntaOperacao == "adicao" || perguntaOperacao == "adição")
            {
                Console.Write("\n Digite o valor da primeira parcela: ");
                double valorParcela1 = Double.Parse(Console.ReadLine());
                Console.Write(" Digite o valor da segunda parcela: ");
                double valorParcela2 = Double.Parse(Console.ReadLine());

                c.Adicao(perguntaOperacao, valorParcela1, valorParcela2);

            }
            else if(perguntaOperacao == "subtracao" || perguntaOperacao == "subtração")
            {
                Console.Write("\n Digite o valor do minuendo: ");
                double valorMinuendo = Double.Parse(Console.ReadLine());
                Console.Write(" Digite o valor do subtraendo: ");
                double valorSubtraendo = Double.Parse(Console.ReadLine());

                c.Subtracao(perguntaOperacao, valorMinuendo, valorSubtraendo);
            }
            else if(perguntaOperacao == "multiplicacao" || perguntaOperacao == "multiplicação")
            {
                Console.Write("\n Digite o valor do primeiro fator: ");
                double valorFator1 = Double.Parse(Console.ReadLine());
                Console.Write(" Digite o valor do segundo fator: ");
                double valorFator2 = Double.Parse(Console.ReadLine());

                c.Multiplicacao(perguntaOperacao, valorFator1, valorFator2);
            }
            else if(perguntaOperacao == "divisao" || perguntaOperacao == "divisão")
            {
                Console.Write("\n Digite o valor do dividendo: ");
                double valorDividendo = Double.Parse(Console.ReadLine());
                Console.Write(" Digite o valor do divisor: ");
                double valorDivisor = Double.Parse(Console.ReadLine());

                c.Divisao(perguntaOperacao, valorDividendo, valorDivisor);
            }
            else
            {
                throw new Exception("\n\n Você digitou alguma operação errado, feche o programa e tente novamente \n");
            }
        }
    }
}