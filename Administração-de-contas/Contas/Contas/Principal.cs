using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contas
{

    //Formulario principal do Programa.
    public partial class Principal : Form
    {
        
        public Principal()
        {

            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Inicializar o formulario de Pessoas 

                       Form1_principal formulario1 = new Form1_principal();
            formulario1.ShowDialog();
            

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
