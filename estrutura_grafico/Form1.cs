using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using static System.Console;

namespace estrutura_grafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //fazer um forech de objetos
            this.chart1.Series["Tique"].Points.AddXY("100", 33);

            this.chart1.Series["Comparações"].Points.AddXY("50", 300);
           
            var stopwatch = new Stopwatch();


            /* stopwatch.Restart();
            for (var i = 0; i < 10; i++) Teste();
            WriteLine($"Tempo passado: {stopwatch.ElapsedTicks}");
            stopwatch.Stop(); */

            int[] tamanhoDosVetores = { 2, 5, 10, 50, 100, 1000 ,10000 };// 5, 10, 50, 100, 1000 e 10000
            int numerodeVetores = 15;
            /* foreach (int i in tamanhoDosVetores)
            {
                numerodeVetores = numerodeVetores * i;
            } */
            WriteLine(numerodeVetores);


            Random rm = new Random();

            criarVetor(numerodeVetores, rm, stopwatch, tamanhoDosVetores);

            WriteLine("Ordenando");

            /* 
                        bool escolha = false;

                        if (escolha == false)
                        {
                            stopwatch.Restart();
                            System.Console.WriteLine("Ordenando quickSort");
                            for (int j = 0; j < vetores.Length; j++)
                            {
                                quickSort(vetores[j]);
                            }
                            stopwatch.Stop();
                            WriteLine($"Tempo passado: {stopwatch.ElapsedTicks}");
                        }
                      //  imprime(tamanhoDosVetores, vetores);
             */
        }
        public static void criarVetor(int numerodeVetores, Random rm, Stopwatch stopwatch, int[] tamanhoDosVetores)
        {
            stopwatch.Start();
            Teste();
            stopwatch.Stop();
            WriteLine($"Tempo passado teste : {stopwatch.ElapsedTicks}");
            foreach (int i in tamanhoDosVetores)
            {
                int[][] vetores = new int[numerodeVetores][];

                for (int a = 0; a < vetores.Length; a++)
                //foreach (int a in tamanhoDosVetores)
                {
                    vetores[a] = new int[i];

                    int b = 0;
                    foreach (int e in vetores[a])
                    {
                        vetores[a][b] = rm.Next(0, 100);
                        b++;
                    }

                    /*  Write("Elemento({0}): ", a + 1);
                     foreach (int f in vetores[a])
                     {
                         Write(" " + f);
                     }
                     System.Console.WriteLine(); */

                }
                System.Console.WriteLine("Ordenando BubbleSort " + i);
                stopwatch.Restart();
                for (int j = 0; j < vetores.Length; j++)
                {
                    BubbleSort(vetores[j]);
                }
                stopwatch.Stop();
                WriteLine($"Tempo passado: {stopwatch.ElapsedTicks}");


                //imprime(numerodeVetores, vetores);
            }

        }
        public static void Teste() => WriteLine("Fazendo algo aqui");
        public static void imprime(int tamanhoDosVetores, int[][] vetores)
        {
            for (int g = 0; g < tamanhoDosVetores; g++)
            {
                System.Console.Write("Element({0}): ", g + 1);

                for (int j = 0; j < vetores[g].Length; j++)
                {
                    System.Console.Write("{0}{1}", vetores[g][j], j == (vetores[g].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
        }


        public static void BubbleSort(int[] a)
        {

            for (int i = 1; i <= a.Length - 1; ++i)

                for (int j = 0; j < a.Length - i; ++j)

                    if (a[j] > a[j + 1])


                        Swap(ref a[j], ref a[j + 1]);

        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static int[] quickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            quickSort(vetor, inicio, fim);

            return vetor;
        }

        private static void quickSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);
            }






        }//

        private void chart1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Tique"].Points.AddXY("100", 44);
            this.chart1.Series["Comparações"].Points.AddXY("100", 300);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
