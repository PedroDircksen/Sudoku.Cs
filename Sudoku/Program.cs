using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int verificador = 0;
            int[] linha = new int[9];            
            int[] colunas = new int[9];
            int[,] matriz = new int[,] {
                     {1,3,2,5,7,9,4,6,8},
                     {4,9,8,2,6,1,3,7,5},
                     {7,5,6,3,8,4,2,1,9},
                     {6,4,3,1,5,8,7,9,2},
                     {5,2,1,7,9,3,8,4,6},
                     {9,8,7,4,2,6,5,3,1},
                     {2,1,4,9,3,5,6,8,7},
                     {3,6,5,8,1,7,9,2,4},
                     {8,7,9,6,4,2,1,5,3}};

            var verify = new Dictionary<int, int>();

           // Console.WriteLine("LINHAS");
            for (int i = 0; i < 9; i++)
            {
                int somaLinha=0;
                for (int j = 0; j < 9; j++)
                {
                    int count = 0;
                    somaLinha = somaLinha + matriz[i, j];
                    count++;

                }
              //  Console.WriteLine(somaLinha);
                if(somaLinha!=45)
                {
                    verificador = 1;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                int somaColuna = 0;
                for (int j = 0; j < 9; j++)
                {
                    int count = 0;
                    somaColuna = somaColuna + matriz[j, i];
                    count++;

                }
               // Console.WriteLine(somaColuna);
                if (somaColuna != 45)
                {
                    verificador = 1;
                }
            }
            for (int posicaoBlocoI = 0; posicaoBlocoI < 3; posicaoBlocoI++)
            {
                for (int posicaoBlocoj = 0; posicaoBlocoj < 3; posicaoBlocoj++)
                {
                    int offSetI = (posicaoBlocoI * 3);
                    int offSetJ = (posicaoBlocoj * 3);

                    int[] bloco = new int[9];
                    int somaBloco = 0;
                    for (int i = offSetI; i < offSetI +3; i++ )
                    {
                        for (int j = offSetJ; j < offSetJ +3; j++)
                        {
                            int exemplo = matriz[i, j];
                            somaBloco = somaBloco + matriz[i, j];
                        }                        
                    }
                  //  Console.WriteLine(somaBloco);
                    if (somaBloco != 45)
                    {
                        verificador = 1;
                    }
                }                
            }

            foreach (var value in matriz)
                     {
                         if (verify.ContainsKey(value))
                             verify[value]++;
                         else
                             verify[value] = 1;
                     }
                     foreach (var pair in verify)
                     {
                         //Console.WriteLine("{0} = {1} time(s)", pair.Key, pair.Value);
                         if(pair.Value!=9)
                         {
                            verificador = 1;
                         }
                     }

            if (verificador == 0)
            {
                Console.WriteLine("SIM");
            }
            else if (verificador == 1)
            {
                Console.WriteLine("NÃO");
            }
          //  Console.WriteLine(verificador);
            Console.ReadLine();
        }
    }
}
