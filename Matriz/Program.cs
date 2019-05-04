using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EXERCICIO DE MATRIZ
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            //linhas
            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                //colunas
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.Write("Negative numbers: " + count);
            #endregion

        }
    }
}
