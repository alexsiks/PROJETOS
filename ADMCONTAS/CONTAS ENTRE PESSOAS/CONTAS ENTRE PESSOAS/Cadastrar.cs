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
using System.Runtime.CompilerServices;
using System.IO;

namespace Contas
{

    public partial class Form1_principal : Form
    {
        //Formulario de Pessoas
        public Form1_principal()
        {
            InitializeComponent();

        }

        //Classe que define a string de conexao com provedor caminho e nome do banco de dados
        SqlConnection Sqlcon = null;
        private string Strcon = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=BD_CONTAS;Integrated Security=True";
        private string Strsql = string.Empty;

        
        //Cadastrar pessoas------------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {

            string sql = $"INSERT INTO PESSOA(NOME,SOBRENOME,SEXO,DATANASCIMENTO,DATACADASTRO,ENDERECO,TELEFONE,EMAIL) VALUES" +
                $" ('{textBox1_nome.Text}','{textBox2_sobrenome.Text}','{comboBox1_sexo.Text}','{dateTimePicker1_nascimento.Text}',getdate(),'{textBox_endereco.Text}','{textBox1_telefone.Text}','{textBox2_email.Text}')";

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




        private void button1_buscardadosdatagrid_Click(object sender, EventArgs e)
        {

            // Visualização de dados esecultados pelo select do datagrid o DataGrid.

            SqlConnection Sqlcon = new SqlConnection(Strcon);



            Sqlcon.Open();

            // Comando execultado pelo o dataGrid.
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT IDPESSOA,NOME , SOBRENOME  ,SEXO,DATANASCIMENTO,DATACADASTRO,ENDERECO,TELEFONE,EMAIL FROM PESSOA", Sqlcon);




            DataTable dataTable = new DataTable();

            sqlData.Fill(dataTable);

            dataGridView2_dados.DataSource = dataTable;

            Sqlcon.Close();

        }





        private void button1_buscar_Click(object sender, EventArgs e)
        {

            // Visualização de dados esecultados pelo select do datagrid o DataGrid.

            SqlConnection Sqlcon = new SqlConnection(Strcon);


            // Comando execultado pelo o dataGrid.
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT*FROM PESSOA " +
                $"where idpessoa = {this.textBox1_id.Text} ", Sqlcon);

            Sqlcon.Open();

            try
            {

                //Classe com um construtor que cria um metodo retornando dados de uma string.
                DataTable dataTable = new DataTable();

                sqlData.Fill(dataTable);

                dataGridView2_dados.DataSource = dataTable;

            }
            catch
            {
                MessageBox.Show("Algumas das Informações não foram preenchidas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            Sqlcon.Close();

            

        }


        //BOTÃO DE guia para a pagina de atualização
        private void button1_atualizardados_Click(object sender, EventArgs e)
        {

            Form1_atualizar form1_atualizar = new Form1_atualizar();
            form1_atualizar.ShowDialog();

        }


      

        private void textBox1_FOTO_TextChanged(object sender, EventArgs e)
        {



        }

        private void Form1_principal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_CONTASDataSet.PESSOA'. Você pode movê-la ou removê-la conforme necessário.
            this.pESSOATableAdapter.Fill(this.bD_CONTASDataSet.PESSOA);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pESSOATableAdapter.FillBy(this.bD_CONTASDataSet.PESSOA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
        private void fotoToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.pESSOATableAdapter.FillBy(this.bD_CONTASDataSet.PESSOA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.pESSOATableAdapter.FillBy(this.bD_CONTASDataSet.PESSOA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pESSOATableAdapter.FillBy1(this.bD_CONTASDataSet.PESSOA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pESSOATableAdapter.FillBy2(this.bD_CONTASDataSet.PESSOA, ((int)(System.Convert.ChangeType(idpessoaToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
