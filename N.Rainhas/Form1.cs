using AForge.Genetic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N.Rainhas
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            selecaoBox.SelectedIndex = 0;
        }

        private String log = "";
        private int nRainhas = 14;
        private int nPopulacao = 14;
        private int nGeracoes = 8000;
        private int nParada = 100;
        private double crossoverRate = 0.75;
        private double mutationRate = 0.01;

        private void button1_Click(object sender, EventArgs e)
        {
            //ShortArrayChromosome[] individos = new ShortArrayChromosome[nPopulacao];
            //for (int i = 0; i < individos.Length; i++)
            //{
            //    individos[i] = new ShortArrayChromosome(nRainhas, nRainhas);
            //    individos[i].Generate();
            //    Console.WriteLine(i + " : " + individos[i].ToString());
            //}

            configuraAlgoritimo();
            int selecao = selecaoBox.SelectedIndex;
            ISelectionMethod metodoDeSelecao = (selecao == 0) ? (ISelectionMethod)new RouletteWheelSelection() :
                                                    (selecao == 1) ? (ISelectionMethod)new EliteSelection() :
                                                        (ISelectionMethod)new RankSelection();
										   
            AvaliadorDeRainhas avaliador = new AvaliadorDeRainhas();
            Population populacao = new Population(nPopulacao, new ShortArrayChromosome(nRainhas, nRainhas - 1), avaliador, metodoDeSelecao);
            populacao.CrossoverRate = crossoverRate;
            populacao.MutationRate = mutationRate;
            //populacao.AutoShuffling = true;

            int iteracao = 0;
            int pararEm = nParada;
            while (iteracao < nGeracoes)
            {
                //populacao.Shuffle();
                //populacao.Selection();
                //populacao.Crossover();
                //populacao.Mutate();
                populacao.RunEpoch();
                //MessageBox.Show("iteração: " + iteracao + "\n Avaliacao Media: " + populacao.FitnessAvg + "\n Melhor individo: " + populacao.BestChromosome.ToString());
                if (nParada > 0 && iteracao == pararEm)
                {
                    atualizaDadosPara(iteracao, populacao);
                    MessageBox.Show("Visualização\nGeração: " + iteracao+"\n OK para Continuar");
                    pararEm += nParada;
                }
                if (populacao.BestChromosome.Fitness == nRainhas)
                    break;
                iteracao++;
            }
            //constroiTabuleiroNoConsole((ShortArrayChromosome)populacao.BestChromosome);
            atualizaDadosPara(iteracao,populacao);
        }

        private void atualizaDadosPara(int iteracao,Population populacao)
        {
            log = "Geração: " + iteracao +
                "\n Método de Seleção : " + populacao.SelectionMethod +
                "\n Avaliação Média: " + populacao.FitnessAvg +
                "\n Melhor Avaliação : " + populacao.FitnessMax +
                "\n Melhor indivíduo: " + populacao.BestChromosome.ToString();
            this.logBox.Text = log;
            desenhaTabuleiro((ShortArrayChromosome)populacao.BestChromosome);
        }

        private void desenhaTabuleiro(ShortArrayChromosome individo)
        {

            int quadSize = 14 + (int)(398/(individo.Length*2));
            Bitmap bm = new Bitmap(800, 800);
            using (Graphics g = Graphics.FromImage(bm))
            using (SolidBrush blackBrush = new SolidBrush(Color.Black))
            using (SolidBrush whiteBrush = new SolidBrush(Color.White))
            using (SolidBrush redBrush = new SolidBrush(Color.Red))
            using (SolidBrush orangeBrush = new SolidBrush(Color.Orange))
            {
                for (int i = 0; i < nRainhas; i++)
                {
                    for (int j = 0; j < nRainhas; j++)
                    {
                        if (individo.Value[i] == j){
                            if (new AvaliadorDeRainhas().essaRainhaTemAtaque(individo, i, j))
                                g.FillRectangle(redBrush, i * quadSize, j * quadSize, quadSize, quadSize);
                            else
                                g.FillRectangle(orangeBrush, i * quadSize, j * quadSize, quadSize, quadSize);
                        }
                        else if ((j % 2 == 0 && i % 2 == 0) || (j % 2 != 0 && i % 2 != 0))
                            g.FillRectangle(blackBrush, i * quadSize, j * quadSize, quadSize, quadSize);
                        else if ((j % 2 == 0 && i % 2 != 0) || (j % 2 != 0 && i % 2 == 0))
                            g.FillRectangle(whiteBrush, i * quadSize, j * quadSize, quadSize, quadSize);
                    }
                }
            }

            this.panelTabuleiro.BackgroundImage = bm;
        }

        private void configuraAlgoritimo(){
            try
            {
                nPopulacao = Math.Max(10, Math.Min(100, int.Parse(populationSizeBox.Text)));
            }
            catch
            {
                nPopulacao = 8;
            }
            try
            {
                nGeracoes = Math.Max(0, int.Parse(iterationsBox.Text));
            }
            catch
            {
                nGeracoes = 100;
            }
            try
            {
                nRainhas = Math.Max(4, int.Parse(nRainhasBox.Text));
            }
            catch
            {
                nRainhas = 8;
            }
            try
            {
                crossoverRate = Math.Max(0.0, int.Parse(crossoverRateBox.Text));
            }
            catch
            {
                crossoverRate = 0.75;
            }
            try
            {
                mutationRate = Math.Max(0.0, int.Parse(motacaoRateBox.Text));
            }
            catch
            {
                mutationRate = 0.01;
            }
            try
            {
                nParada = Math.Max(0, int.Parse(paradaBox.Text));
            }
            catch
            {
                nParada = 0;
            }
        }

        private void constroiTabuleiroNoConsole(ShortArrayChromosome melhorIndividuo)
        {
            int nRainhas = melhorIndividuo.Length;
            Console.WriteLine("|---+---+---+---+---+---+---+---|");
            for (int i = 0; i < nRainhas; i++)
            {
                Console.Write("|");
                int posicaoRainha = melhorIndividuo.Value[i];
                for (int j = 0; j < nRainhas; j++)
                {
                    if (posicaoRainha == j)
                    {
                        Console.Write(" x |");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }
                Console.WriteLine("\r\n|---+---+---+---+---+---+---+---|");
            }
        }
        
    }
}
