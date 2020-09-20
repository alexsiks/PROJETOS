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

namespace CONTAS_ENTRE_PESSOAS
{
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }
        //Classe que define a string de conexao com provedor caminho e nome do banco de dados
        SqlConnection Sqlcon = null;
        private string Strcon = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=BD_CONTAS;Integrated Security=True";
        private string Strsql = string.Empty;

        private void Empresas_Load(object sender, EventArgs e)
        {
         

        }

        private void button3_CADASTRAR_CREDOR_Click(object sender, EventArgs e)
        {


            //CADASTRAR CREDORES EM BANCO DE DADOS.

            string sql = $"INSERT INTO credor(NOME,tipocredor,telefone,email,comentario,datacadastro) VALUES" +
                $" ('{textBox1_Credor.Text}','{comboBox1_TIPOCREDOR.Text}','{textBox1_telefone.Text}','{textBox2_email.Text}','{textBox1_COMENTARIO.Text}',getdate())";

            SqlConnection con = new SqlConnection(Strcon);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Credor Cadastro com sucesso!");
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

        private void button1_Click(object sender, EventArgs e)
        {


            // Visualização de dados esecultados pelo select do datagrid o DataGrid.

            SqlConnection Sqlcon = new SqlConnection(Strcon);


            // Comando execultado pelo o dataGrid.
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT*FROM credor " +
                $"where idcredor = {textBox1_IDCREDOR.Text} ", Sqlcon);

            Sqlcon.Open();

            try
            {

                //Classe com um construtor que cria um metodo retornando dados de uma string.
                DataTable dataTable = new DataTable();

                sqlData.Fill(dataTable);

                dataGridView1_informação.DataSource = dataTable;

            }
            catch
            {
                MessageBox.Show("Algumas das Informações não foram preenchidas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            Sqlcon.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Visualização de dados esecultados pelo select do datagrid o DataGrid.

            SqlConnection Sqlcon = new SqlConnection(Strcon);


            // Comando execultado pelo o dataGrid.
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT*FROM credor ", Sqlcon);

            Sqlcon.Open();

            try
            {

                //Classe com um construtor que cria um metodo retornando dados de uma string.
                DataTable dataTable = new DataTable();

                sqlData.Fill(dataTable);

                dataGridView1_informação.DataSource = dataTable;

            }
            catch
            {
                MessageBox.Show("Algumas das Informações não foram preenchidas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            Sqlcon.Close();


        }

        private void button3_ATUALIARCREDOR_Click(object sender, EventArgs e)
        {

            Atualizar_Credores atualizar_Credores = new Atualizar_Credores();
            atualizar_Credores.ShowDialog();

        }
    }
}
