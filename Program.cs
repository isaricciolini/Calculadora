using System;

namespace Calculator{
    class Program{
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double primeiroValor = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            double segundoValor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Escolha a operação entre {primeiroValor} __ {segundoValor}:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu){
                case 1: 
                Console.WriteLine($"Resultado da adição: {Adicao(primeiroValor, segundoValor)}");
                break;
                case 2: 
                Console.WriteLine($"Resultado da subtração: {Subtracao(primeiroValor, segundoValor)}");
                break;
                case 3: 
                Console.WriteLine($"Resultado da multiplicação: {Multiplicacao(primeiroValor, segundoValor)}");
                break;
                case 4: 
                Console.WriteLine($"Resultado da divisão: {Divisao(primeiroValor, segundoValor)}");
                break;
                case 5: 
                System.Environment.Exit(0);
                break;
                default:
                Console.WriteLine("Opção inválida! ");
                break;
            }
        }

        static double Adicao(double primeiroValor, double segundoValor){
            return primeiroValor + segundoValor;
        }

        static double Subtracao(double primeiroValor, double segundoValor){
            return primeiroValor - segundoValor;
        }

        static double Multiplicacao(double primeiroValor, double segundoValor){
            return primeiroValor * segundoValor;
        }

        static double Divisao(double primeiroValor, double segundoValor){
            return primeiroValor / segundoValor;
        }
    }
}