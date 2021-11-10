//Daniel Hiroshi Fugikawa - 200209
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Formass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da lista
            List<forma> list = new List<forma>();
            Console.WriteLine("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //Informações das formas
                Console.WriteLine($"Forma#{i}: ");
                Console.Write("Retâmgulo ou Circulo? (R/C) ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor: (Preto/Azul/Vermelho):");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                //Informações adicionais para retangulos
                if (ch == 'R' || ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    list.Add(new Retangulo(largura, altura, cor));
                }
                //Informações adicionais para um circulo
                if ( ch == 'c' || ch =='C')
                {
                    Console.WriteLine("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }

            }

            Console.WriteLine();
            //Imprimir a area das formas
            Console.WriteLine("Area de cada forma: ");
            foreach (forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}