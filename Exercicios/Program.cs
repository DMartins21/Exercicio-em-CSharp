using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite de 0 a 4:");
            int num = int.Parse(Console.ReadLine());

            if (num == 0 || num >= 5)
            {
                Console.WriteLine("Numero Invalido!");
                
            }
            double total;
            switch (num)
            {
             case 1:
                Console.WriteLine("Gasolina, digite a quantidade desejada:");
                    int quant = int.Parse(Console.ReadLine());
                    double valor = 7.00;
                    total = quant * valor;
                    Console.WriteLine($"O valor total a pagar e de: R${total}");
                    break;
             case 2:
                Console.WriteLine("Diesel, digite a quantidade:");
                    quant = int.Parse(Console.ReadLine());
                    valor = 6.60;
                    total = quant * valor;
                    Console.WriteLine($"O valor total a pagar e de: R${total}");
                    break;
             case 3:
                    Console.WriteLine("GNV, digite a quantidade:");
                    quant = int.Parse(Console.ReadLine());
                    valor = 5.50;
                    total = quant * valor;
                    Console.WriteLine($"O valor total a pagar e de: R${total}");
                    break;
                case 4:
                    Console.WriteLine("Etanol, digite a quantidade");
                    quant = int.Parse(Console.ReadLine());
                    valor = 4.65;
                    total = quant * valor;
                    Console.WriteLine($"O valor total a pagar e de: R${total}");
                    break;
            }
        }
    }
}
