using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Formulario_de_Veiculos : Form
    {
        public Formulario_de_Veiculos(String carros)
        {
            InitializeComponent();



            textBox_listaveiculo.Text = carros;


        }

        public void textBox_listaveiculo_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
