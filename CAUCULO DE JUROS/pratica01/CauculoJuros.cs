using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


 

namespace pratica01
{
    public partial class CauculoJuros : Form
    {

        CauculoAritmetica aritmetica = new CauculoAritmetica();
        public CauculoJuros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                if (textBox2.Text == " ")
                {
                    MessageBox.Show("O campo 2 não deve ficar vazio.");

                }
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                Somar();
               
            
            

        }

        private void Somar()
        {           

            try
            {
                
                  double valor = Convert.ToDouble(textBox1.Text);
                textBox1.Text = valor.ToString("n2");


                double taxaJuros = Convert.ToDouble(textBox2.Text);
                textBox1.Text = valor.ToString("n2");

               
                double cauculo = valor + (valor * taxaJuros) / 100;
                textBox3.Text = cauculo.ToString("n2");

            }
            catch 
            {
                MessageBox.Show("Não foi possivel realizar a Operação.");

               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            
            }
            catch
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("O campo 1 não deve ficar vazio.");

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                double valor = Convert.ToDouble(textBox1.Text);
                textBox1.Text = valor.ToString("n2");


                double taxaJuros = Convert.ToDouble(textBox2.Text);
                textBox1.Text = valor.ToString("n2");


                double cauculo = valor - (valor * taxaJuros) / 100;
                textBox3.Text = cauculo.ToString("n2");

            }
            catch
            {
                MessageBox.Show("Não foi possivel realizar a Operação.");


            }

        }

       
    }
}
