using System;
using AForge.Genetic;

public class AvaliadorDeRainhas : IFitnessFunction
{
    private ShortArrayChromosome individo;
    private int nCasas;

    public AvaliadorDeRainhas()
    {
    }

    private void gerarTabuleiro(int[,] tabuleiro)
    {
        for (int i = 0; i < nCasas; i++)
        {
            int posicaoRainha = individo.Value[i];
            for (int j = 0; j < nCasas; j++)
            {
                tabuleiro[i, j] = posicaoRainha == j ? 1 : 0;
            }
        }
    }

    public bool essaRainhaTemAtaque(ShortArrayChromosome individo,int i,int j){
        this.individo = individo;
        nCasas = individo.Length;
        int[,] tabuleiro = new int[nCasas, nCasas];

        // primeiro representamos o tabuleiro com 0 e 1
        gerarTabuleiro(tabuleiro);
        return temAtacante(tabuleiro, i, j);

    }

    //retorna a quantidade de rainhas a salvo
    public double Evaluate(IChromosome chromosome)
    {
        this.individo = (ShortArrayChromosome)chromosome;
        nCasas = individo.Length;
        double ret = 0;
        int[,] tabuleiro = new int[nCasas, nCasas];

        // primeiro representamos o tabuleiro com 0 e 1
        gerarTabuleiro(tabuleiro);

        // agora verificamos quantas rainhas estao a salvo, este será o nosso
        // retorno da função fitness
        for (int i = 0; i < nCasas; i++)
        {
            for (int j = 0; j < nCasas; j++)
            {
                if (tabuleiro[i, j] == 1)
                {
                    if (!temAtacante(tabuleiro, i, j))
                    {
                        ret++;
                    }
                }
            }
        }
        return ret;
    }

    private bool temAtacante(int[,] tabuleiro, int i, int j)
    {

        // verificar na horizontal
        for (int k = 0; k < nCasas; k++)
        {
            if (k != i && tabuleiro[k, j] == 1)
                return true;
        }

        // verificar na vertical
        for (int k = 0; k < nCasas; k++)
        {
            if (k != j && tabuleiro[i, k] == 1)
                return true;
        }

        // verificar na diagonal1
        int i0 = i - 1;
        int j0 = j - 1;
        while (i0 >= 0 && j0 >= 0)
        {
            if (tabuleiro[i0, j0] == 1)
                return true;
            i0--;
            j0--;

        }

        // verificar na diagonal2
        i0 = i + 1;
        j0 = j + 1;
        while (i0 < nCasas && j0 < nCasas)
        {
            if (tabuleiro[i0, j0] == 1)
                return true;
            i0++;
            j0++;
        }

        // verificar na diagonal3
        i0 = i + 1;
        j0 = j - 1;
        while (i0 < nCasas && j0 >= 0)
        {
            if (tabuleiro[i0, j0] == 1)
                return true;
            i0++;
            j0--;
        }

        // verificar na diagonal4
        i0 = i - 1;
        j0 = j + 1;
        while (i0 >= 0 && j0 < nCasas)
        {
            if (tabuleiro[i0, j0] == 1)
                return true;
            i0--;
            j0++;
        }

        return false; // esta a salvo
    }
}
