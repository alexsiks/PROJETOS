using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Data.SqlTypes;

namespace CONTAS_ENTRE_PESSOAS
{
    public partial class Cadastrar_Contas : Form
    {

        public string num;

        public Cadastrar_Contas()
        {
            InitializeComponent();

            num = " ";
        }
        //Classe que define a string de conexao com provedor caminho e nome do banco de dados
        SqlConnection Sqlcon = null;
        private string Strcon = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=BD_CONTAS;Integrated Security=True";
        private string Strsql = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {


            string sql = $"INSERT INTO conta(idconta,idpessoa,idcredor,periodo,vencimento,valor,status,DATACADASTRO)" +
                $"values " +
                $"('{textBox2_IDCONTA.Text}'," +
                $"{textBox1_idpessoa.Text}," +
                $"{textBox1_IDCREDOR.Text}," +
                $"'{dateTimePicker1_periodocobranca.Text}'" +
                $",'{dateTimePicker1_periodovencimento.Text}'," +
                $"{ textBox3_VALORCONTA.Text}," +
                $"'{comboBox1_STATUSCONTA.Text}',GETDATE())";

            SqlConnection con = new SqlConnection(Strcon);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro no cadastro dos dados, verifique se as informações estão corretas: ", "ERRO DE CADASTRO");
            }
            finally
            {
                con.Close();
            }



        }

        private void toolStripContainer2_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_VALORCONTA_TextChanged(object sender, EventArgs e)
        {
            try {
                
                Preenchimento preenchimento = new Preenchimento(textBox3_VALORCONTA.Text, this);
                preenchimento.ShowDialog();

              
              

            textBox3_VALORCONTA.Text = string.Format("{0:c}", double.Parse(textBox3_VALORCONTA.Text.Replace("R$"," ")));
            }
            catch
            {

            }


        }
    }
}
