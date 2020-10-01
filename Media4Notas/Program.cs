using System;

namespace media4notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1;
            double N2;
            double N3;
            double N4;
            double resultMedia;

            Console.Write("Digite a 1ºNota: ");
            N1 = double.Parse(Console.ReadLine());
            if (N1 < 0 || N1 > 10)
            {
                Console.WriteLine();
                Console.WriteLine("Digite somente números de 0 a 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write("Digite a 2ºNota: ");
            N2 = double.Parse(Console.ReadLine());
            if (N2< 0 || N2 > 10)
            {
                Console.WriteLine();
                Console.WriteLine("Digite somente números de 0 a 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write("Digite a 3ºNota: ");
            N3 = double.Parse(Console.ReadLine());
            if (N3 < 0 || N3 > 10)
            {
                Console.WriteLine();
                Console.WriteLine("Digite somente números de 0 a 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write("Digite a 4ºNota: ");
            N4 = double.Parse(Console.ReadLine());
            if (N4 < 0 || N4 > 10)
            {
                Console.WriteLine();
                Console.WriteLine("Digite somente números de 0 a 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            resultMedia = (N1 + N2 + N3 + N4) / 4;
            if (resultMedia >= 7)
            {
                Console.WriteLine();
                Console.WriteLine($"Sua media final é de {Math.Round(resultMedia, 1)}");
                Console.WriteLine("Então você foi APROVADO!");
            }
            else if (resultMedia >= 5 && resultMedia <= 6)
            {
                Console.WriteLine();
                Console.WriteLine($"Sua media final é de {Math.Round(resultMedia, 1)}");
                Console.WriteLine("Então você ficou de RECUPERAÇÃO!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Sua media final é de {Math.Round(resultMedia, 1)}");
                Console.WriteLine("Então você foi REPROVADO!");
            }
        }
    }
}