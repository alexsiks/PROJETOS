﻿using System;
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
                double taxaJuros = Convert.ToDouble(textBox2.Text);

            
               
                
                double cauculo = valor+(valor * taxaJuros)/100;
                
                textBox3.Text = cauculo.ToString("n2");

            }
            catch 
            {
                MessageBox.Show("Não foi possivel realizar a Operação.");

               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
            
        }
    }
}
