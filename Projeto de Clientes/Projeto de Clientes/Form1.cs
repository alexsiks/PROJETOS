using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Projeto_de_Clientes
    {
    public partial class Form1 : Form
        {

        //Declaração de Variavel//


        public Form1()
            {





            InitializeComponent();
            }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
            {
            double n1, n2, Resultado;

            n1 = Convert.ToDouble(txtValor1.Text);
            n2 = Convert.ToDouble(txtValor2.Text);

            Resultado = n1 + n2;

            txtotal.Text = Resultado.ToString();



            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void Form1_ControlAdded(object sender, ControlEventArgs e)
            {

            }

        private void Form1_Click(object sender, EventArgs e)
            {

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void label2_Click(object sender, EventArgs e)
            {

            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
            {




            }
        private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

        private void Caucular_Click(object sender, EventArgs e)
            {



            }
        }
    }
