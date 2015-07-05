using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Genetic;

namespace N.Rainhas
{
    class AvaliadorDeRainhas2 : IFitnessFunction
    {
        private ShortArrayChromosome individo;
        private int nCasas;
        bool[,] tabuleiro;

        private void zeraTabuleiro() {
            for (int i = 0; i < nCasas; i++)
            {
                for (int j = 0; j< nCasas; j++)
                {
                    tabuleiro[i, j] = false;
                }
            }
        }

        private void atualizaTabuleiro() {
            zeraTabuleiro();
            for (int i = 0; i < nCasas; i++)
            {
                tabuleiro[i,individo.Value[i]] = true;
            }
        }

        public double Evaluate(IChromosome chromosome)
        {
            this.individo = (ShortArrayChromosome)chromosome;
            nCasas = individo.Length;
            double conflicts = nCasas;
            int x = 0;
            int y = 0;
            int tempx = 0;
            int tempy = 0;

            int[] dx = new int[]{-1, 1, -1, 1};
            int[] dy = new int[]{-1, 1, 1, -1};
            bool done;

            tabuleiro = new bool[nCasas, nCasas];
            atualizaTabuleiro();

            //Checa na horizontal
            for (int i = 0; i < nCasas; i++)
            {
                y = individo.Value[i];
                if (y != -1)
                {
                    for (int j = 0; j < nCasas; j++)
                    {
                        if (individo.Value[j] == y && j != i)
                        {
                            conflicts++;
                        }
                    }
                }
            }

            //Checa nas diagonais
            for (int i = 0; i < nCasas; i++)
            {
                x = i;
                y = this.individo.Value[i];
                if (y != -1) {
                    for (int j = 0; j <= 3; j++) {
                        tempx = x;
                        tempy = y;
                        done = false;
                        while (!done) {
                            tempx += dx[j];
                            tempy += dy[j];
                            if ((tempx < 0 || tempx <= nCasas) || (tempy < 0 || tempy <= nCasas))
                            {
                                done = true;
                            } else {
                                if (tabuleiro[tempx,tempy])
                                {
                                    conflicts++;
                                }
                            }
                        }
                    }
                }
            }
            return conflicts;
        }
    }
}
