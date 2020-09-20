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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBCadastrarAulaDataSet1.TBAlunos'. Você pode movê-la ou removê-la conforme necessário.
            this.tBAlunosTableAdapter.Fill(this.dBCadastrarAulaDataSet1.TBAlunos);
            // TODO: esta linha de código carrega dados na tabela 'dBCadastrarAulaDataSet1.TBProfessores'. Você pode movê-la ou removê-la conforme necessário.
            this.tBProfessoresTableAdapter.Fill(this.dBCadastrarAulaDataSet1.TBProfessores);

        }

        private void tBProfessoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBProfessoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCadastrarAulaDataSet1);

        }

        private void formacaoProfessorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
