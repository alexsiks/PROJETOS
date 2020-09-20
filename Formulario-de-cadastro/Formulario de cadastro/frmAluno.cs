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
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }

        private void tBAlunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBAlunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCadastrarAulaDataSet11);

        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBCadastrarAulaDataSet11.TBAlunos'. Você pode movê-la ou removê-la conforme necessário.
            this.tBAlunosTableAdapter.Fill(this.dBCadastrarAulaDataSet11.TBAlunos);

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            
        }

        private void idAlunoLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
