using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                // Janela de mensagem para o usuario caso o campo textbox1 estiver vazio.
                MessageBox.Show("Digite um Veiculo");

                //Foca o cursor para o campo.
                textBox1.Focus();
                return;
                
            }
            else
            {    /// Realiza o incremento concaternando a virgula.
                textBox2.Text += textBox1.Text + ", " ;
                
            }

            // Apaga todo o conteudo.
            textBox1.Clear();
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // Redireciona o cursor .
            textBox1.Focus();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox2_FontChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Ao clicar no botao button3
            /*
             Ira declarar o objeto "Formulario veiculos" como "formulario_De_Veiculos".
             
             */

            Formulario_de_Veiculos formulario_De_Veiculos = new Formulario_de_Veiculos(textBox1.Text);

            /*
             *  .ShowDialog      " Não permite mecher na janela anterior enquanto aberta" 
             
            *  .Show             " permite mecher na janela anterior enquanto aberta"
            
             
             */
            formulario_De_Veiculos.ShowDialog();
        }
    }
}
