using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado = 0;
            string operacao;
            string sair;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("+---------------------------+");
            Console.WriteLine("|       Seja-bem vindo      |");
            Console.WriteLine("+---------------------------+");
            Console.WriteLine("|   Comandos das operações: |");
            Console.WriteLine("+---------------------------+");
            Console.WriteLine("|          Soma (+)         |");
            Console.WriteLine("|        Subtração (-)      |");
            Console.WriteLine("|      Multiplicação (*)    |");
            Console.WriteLine("|         Divisão (/)       |");
            Console.WriteLine("|      Exponeciação (^)     |");
            Console.WriteLine("|      Radiação (R ou r)    |");
            Console.WriteLine("+---------------------------+");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+--------------------------------------------------------------------------------+");
            Console.WriteLine("|   Observação: a cada etapa, leia as orientações e tecle ENTER para continuar.  |");
            Console.WriteLine("|na radiação (raiz quadrada), o número que irá contar é o primeiro valor digitado|");
            Console.WriteLine("+--------------------------------------------------------------------------------+");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Aguarde...");
            Console.WriteLine();
            
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha uma operação: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ResetColor();
            operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            do
            {
            switch(operacao)
            {
                case "+":
                resultado = numero1 + numero2;
                Console.Write("O valor da soma é: ");
                break;
                case "-":
                resultado = numero1 - numero2;
                Console.Write("O valor da subtração é: ");
                break;
                case "/":
                resultado = numero1 / numero2;
                Console.Write("O valor da divisão é: ");
                break;
                case "*":
                resultado = numero1 * numero2;
                Console.Write("O valor da multiplicação é: ");
                break;
                case "^":
                resultado = Math.Pow(numero1, numero2);
                Console.Write("O valor da exponeciação é: ");
                break;
                case "R":
                numero2 = Convert.ToDouble(numero1);
                resultado = Math.Sqrt(numero2);
                Console.WriteLine($"A raiz quadrada de {numero2} é: ");
                break;
                case "r":
                numero2 = Convert.ToDouble(numero1);
                resultado = Math.Sqrt(numero2);
                Console.WriteLine($"A raiz quadrada de {numero2} é: ");
                break;

                default:
                Console.WriteLine("Operação incorreta!");
                break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", resultado);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Deseja sair? S/N: ");
            Console.WriteLine();
            Console.ResetColor();
            sair = Console.ReadLine().ToUpper();
        }
        while (sair != "S" && sair != "SIM");
        {
            Console.WriteLine();
            Console.WriteLine("\nVolte sempre!");
        }
            
        }
    }
}
