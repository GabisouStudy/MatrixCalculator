using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class Form1 : Form
    {

        private TextBox[,] Matriz;
        private TextBox[,] Matriz_2;
        private TextBox[,] Matriz_3;

        Calculos calculos = new Calculos();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonForm1_Click(object sender, EventArgs e, int id, int type)
        {

            
        }

        //MATRIZ 1
        private void lineUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.matrixBox1.Controls.Clear();

            NumericUpDown upDownSelect = sender as NumericUpDown;
            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown1.Value);
            coluna = Convert.ToInt32(columnUpDown1.Value);

            Matriz = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz[i, j].Left = j * 35 + 15;
                    Matriz[i, j].Width = 30;
                    this.matrixBox1.Controls.Add(Matriz[i, j]);
                }
            }
        }

        private void columnUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.matrixBox1.Controls.Clear();

            NumericUpDown upDownSelect = sender as NumericUpDown;
            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown1.Value);
            coluna = Convert.ToInt32(columnUpDown1.Value);

            Matriz = new TextBox[linha, coluna];
            //upDownSelect.

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz[i, j].Left = j * 35 + 15;
                    Matriz[i, j].Width = 30;
                    this.matrixBox1.Controls.Add(Matriz[i, j]);
                }
            }
        }

        //MATRIZ 2
        private void lineUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.matrixBox2.Controls.Clear();

            NumericUpDown upDownSelect = sender as NumericUpDown;
            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown2.Value);
            coluna = Convert.ToInt32(columnUpDown2.Value);

            Matriz_2 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    Matriz_2[i, j] = new TextBox();
                    Matriz_2[i, j].Text = "0";
                    Matriz_2[i, j].Top = (i * Matriz_2[i, j].Height) + 100;
                    Matriz_2[i, j].Left = j * 35 + 15;
                    Matriz_2[i, j].Width = 30;
                    this.matrixBox2.Controls.Add(Matriz_2[i, j]);
                }
            }
        }

        private void columnUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.matrixBox2.Controls.Clear();

            NumericUpDown upDownSelect = sender as NumericUpDown;
            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown2.Value);
            coluna = Convert.ToInt32(columnUpDown2.Value);

            Matriz_2 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    Matriz_2[i, j] = new TextBox();
                    Matriz_2[i, j].Text = "0";
                    Matriz_2[i, j].Top = (i * Matriz_2[i, j].Height) + 100;
                    Matriz_2[i, j].Left = j * 35 + 15;
                    Matriz_2[i, j].Width = 30;
                    this.matrixBox2.Controls.Add(Matriz_2[i, j]);
                }
            }
        }

        //Matriz 3
        private void lineUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.matrixBox3.Controls.Clear();

            NumericUpDown upDownSelect = sender as NumericUpDown;
            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown3.Value);
            coluna = Convert.ToInt32(columnUpDown3.Value);

            Matriz_3 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_3.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_3.GetLength(1); j++)
                {
                    Matriz_3[i, j] = new TextBox();
                    Matriz_3[i, j].Text = "0";
                    Matriz_3[i, j].Top = (i * Matriz_3[i, j].Height) + 100;
                    Matriz_3[i, j].Left = j * 35 + 15;
                    Matriz_3[i, j].Width = 30;
                    this.matrixBox3.Controls.Add(Matriz_3[i, j]);
                }
            }
        }

        private void columnUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.matrixBox3.Controls.Clear();

            NumericUpDown upDownSelect = sender as NumericUpDown;
            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown3.Value);
            coluna = Convert.ToInt32(columnUpDown3.Value);

            Matriz_3 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_3.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_3.GetLength(1); j++)
                {
                    Matriz_3[i, j] = new TextBox();
                    Matriz_3[i, j].Text = "0";
                    Matriz_3[i, j].Top = (i * Matriz_3[i, j].Height) + 100;
                    Matriz_3[i, j].Left = j * 35 + 15;
                    Matriz_3[i, j].Width = 30;
                    this.matrixBox3.Controls.Add(Matriz_3[i, j]);
                }
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            float[,] valorMatriz1 = new float[Matriz.GetLength(0), Matriz.GetLength(1)];
            float[,] valorMatriz2 = new float[Matriz_2.GetLength(0), Matriz_2.GetLength(1)];

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    float k = 0;
                    if (float.TryParse(Matriz[i, j].Text, out k))
                    {
                        valorMatriz1[i, j] = float.Parse(Matriz[i, j].Text);
                    }
                }
            }

            Console.WriteLine(valorMatriz1);

            for (int i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    float k = 0;
                    if (float.TryParse(Matriz_2[i, j].Text, out k))
                    {
                        valorMatriz2[i, j] = float.Parse(Matriz_2[i, j].Text);
                    }
                }
            }

            Console.WriteLine(valorMatriz2);

            float[,] answer = calculos.Soma(valorMatriz1, valorMatriz2);

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Text: " + (Matriz[i, j] as TextBox).Text);
                    Console.WriteLine("NAME: " + Matriz[i, j].Name);
                }
            }

                    /*for (int i = 0; i < answer.GetLength(0); i++)
                    {
                        for (int j = 0; j < answer.GetLength(1); j++)
                        {*/
                    
               /* }
            }*/

            for (int i = 0; i < Matriz_3.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_3.GetLength(1); j++)
                {
                    Matriz_3[i, j].Text = "" + answer[i, j];
                }
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            /* Graphics myGraphics = new Graphics;
            Pen myPen = new Pen;

            Point[] myPointArray =
                { new Point(0, 0), new Point(50, 30), new Point(30, 60) };
                            myGraphics.DrawPolygon(myPen, myPointArray); */
        }

        /*
         private void Criar_Matriz(object sender, EventArgs e){

            int linha = Int16.Parse(Linhas1.Text);
            int coluna = Int16.Parse(Colunas1.Text);

            Matriz = new TextBox[linha, coluna];

            for (i = 0; i < Matriz.GetLength(0); i++){
                for (j = 0; j < Matriz.GetLength(1); j++){
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz[i, j].Left = j * 35 + 15;
                    Matriz[i, j].Width = 30;
                    this.Controls.Add(Matriz[i, j]);
                }
            }
        }
        */
    }
}
