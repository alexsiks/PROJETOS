using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTAS_ENTRE_PESSOAS
{
    public partial class Preenchimento : Form
    {

        Cadastrar_Contas informacao;
        public Preenchimento(string v, Cadastrar_Contas cc )
        {
            InitializeComponent();

            textBox1_valor2.Text = v;

            informacao = cc;

            cc.num = textBox1_valor2.Text;

            

        }

        private void Preenchimento_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            informacao.textBox3_VALORCONTA.Text = textBox1_valor2.Text;
            

            
            
        }
    }
}
