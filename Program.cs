using System;

namespace Exercicio_individual_Tema_Matriz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativos = 0;
            Console.Write("Insira um numero para ser a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n]; //declara matriz

            for(int l = 0; l<n; l++)  // l = linhas, c = colunas
            {
                for(int c = 0; c<n; c++)
                {
                    Console.Write("Insira o [" + l + ", " + c + "]: "); //pede os valores da matriz
                    matriz[l,c] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine(); //Pula linha
            Console.Write("As diagonais são:");
            for (int l = 0; l < n; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (l == c)
                    {
                        Console.WriteLine(matriz[l, c]); //mostra diagonais
                    }
                    if(matriz[l,c] < 0)
                    {
                        negativos++; //soma negativos
                    }
                }
            }

            Console.WriteLine(); //Pula linha
            Console.WriteLine("A quantidade de numeros negativos na matriz é: " + negativos);
            Console.ReadKey();
        }
    }
}
