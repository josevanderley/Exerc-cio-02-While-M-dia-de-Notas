using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_02_While__Média_de_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(((((((((((((((((((((((((( PROGRAMA MEDIA DE NOTAS ))))))))))))))))))))) ");

            int somaNotas = 0;
            int contadorNotas = 0;
            string entrada;

            Console.WriteLine("Insira as notas dos alunos. Digite 'fim' para encerrar.");

            while (true)
            {
                Console.Write("Insira uma nota (ou 'fim' para encerrar): ");
                entrada = Console.ReadLine();

                if (entrada.ToLower() == "fim")
                {
                    break;
                }

                if (int.TryParse(entrada, out int nota))
                {
                    somaNotas += nota;
                    contadorNotas++;
                }
                else
                {
                    Console.WriteLine("Por favor, insira uma nota válida.");
                }
            }

            if (contadorNotas > 0)
            {
                int media = somaNotas / contadorNotas;
                Console.WriteLine($"A média das notas é: {media}");
            }
            else
            {
                Console.WriteLine("Nenhuma nota inserida.");

                Console.ReadKey();
            }
        }
    }
}
    
