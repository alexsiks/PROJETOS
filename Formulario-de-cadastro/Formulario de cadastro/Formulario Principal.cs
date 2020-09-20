using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_de_cadastro
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

        private void tsbAluno_Click(object sender, EventArgs e)
        {

            frmAluno aluno = new frmAluno();
            aluno.ShowDialog();

        }

        private void tsbProfessor_Click(object sender, EventArgs e)
        {
            frmProfessor professor = new frmProfessor();
            professor.ShowDialog();
        }

        private void tsbAula_Click(object sender, EventArgs e)
        {
            frmAula aula = new frmAula();
            aula.ShowDialog();
        }

        private void tBAlunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          
        }
    }
}
