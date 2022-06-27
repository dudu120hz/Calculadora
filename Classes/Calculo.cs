using System;
using Calculadora;

namespace Calculadora.Classes
{
    class Calculo
    {
        public void Adicao(string operacao, double parcela1, double parcela2)
        {
            double resultado = parcela1 + parcela2;
            Console.WriteLine($"\n O valor do total da soma é: {resultado}"); 
        }
        public void Subtracao(string operacao, double minuendo, double subtraendo)
        {
            double resultado = minuendo - subtraendo;
            Console.WriteLine($"\n O valor da diferença da subtração é: {resultado}");
        }
        public void Multiplicacao(string operacao, double fator1, double fator2)
        {
            double resultado = fator1 * fator2;
            Console.WriteLine($"\n O valor do produto da multiplicação é: {resultado}");
        }
        public void Divisao(string operacao, double dividendo, double quociente)
        {
            double resultado = dividendo / quociente;
            Console.WriteLine($"\n O valor do quociente da divisão é: {resultado}");
        }
    }
}