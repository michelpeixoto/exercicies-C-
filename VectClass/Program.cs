using System;

namespace ListasArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            VetorClasse[] vect = new VetorClasse[10];

            Console.Write("Digite quantos quartos vao ser alugados: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Rent {0}: ", i);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new VetorClasse { Name = name, Email = email };

            }

            for (int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine($"Room {i}: {vect[i]}");
                }
            }
        }
    }
}
