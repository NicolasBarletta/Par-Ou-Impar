using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Ímpar ou Par");
            Console.WriteLine("Escolha: ");
            Console.WriteLine(" [ 1 ] Par");
            Console.WriteLine(" [ 2 ] Ímpar");
            int caso = int.Parse(Console.ReadLine());

            switch (caso)
            {
                case 1:
                    Console.WriteLine("Digite um número!");
                    int num = int.Parse(Console.ReadLine());

                    Random r = new Random();
                   int pc = r.Next(0, 99);

                    int resultado = num + pc;
                    if (resultado % 2 == 0)
                    {
                        Console.WriteLine("Parabéns, você ganhou!!! ");
                        Console.WriteLine(" Você escolheu " + num + " e o computador escolheu " + pc);
                        Console.ReadKey();
                        break;
                    } else
                    {
                        Console.WriteLine("GAME OVER!!!");
                        Console.WriteLine(" Você escolheu " + num + " e o computador escolheu " + pc);
                        Console.ReadKey();
                        break;
                    }

                case 2:
               
                    Console.WriteLine("Digite um número!");
                    int num1 = int.Parse(Console.ReadLine());

                    Random r1 = new Random();
                    int pc1 = r1.Next(0, 99);

                    int resultado1 = num1 + pc1;
                    if (resultado1 % 2 == 0)
                    {
                        
                        Console.WriteLine("GAME OVER!!!");
                        Console.WriteLine("Você escolheu " + num1 + " e o computador escolheu " + pc1);
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Parabéns, você ganhou!!! ");
                        Console.WriteLine(" Você escolheu " + num1 + " e o computador escolheu " + pc1);
                        Console.ReadKey();
                        break;
                    }

                default:
                    Console.WriteLine("Comando Inválido!");
                    break;
            }
        }
    }
}
