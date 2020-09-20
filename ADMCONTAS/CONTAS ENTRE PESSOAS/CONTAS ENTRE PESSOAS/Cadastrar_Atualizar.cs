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

namespace Contas
{
    public partial class Form1_atualizar : Form
    {
        public Form1_atualizar()
        {
            InitializeComponent();

            
        }

        //define a string de conexao com provedor caminho e nome do banco de dados
        SqlConnection Sqlcon = null;
        private string Strcon = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=BD_CONTAS;Integrated Security=True";
        private string Strsql = string.Empty;


        

        //BOTÃO DE METODO DE ATUALIZAÇÃO DE DADOS 
        private void button1_procurar_Click(object sender, EventArgs e)
        {


            
            string sql =$"  update pessoa set nome = '{textBox2_nome.Text}'," +
                $"sobrenome = '{textBox2_sobrenome.Text}'," +
                $" sexo = '{textBox1_SEXO.Text}',datanascimento = '{dateTimePicker1_nascimento.Text}',ATUALIZACAODADOS = GETDATE(), endereco = '{textBox_endereco.Text}' ,telefone='{textBox1_telefone.Text}', email ='{textBox2_email.Text}' where idpessoa = {textBox1_idpessoa_atualizar.Text}";

            SqlConnection con = new SqlConnection(Strcon);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

           try { 

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();



                MessageBox.Show("ATUALIZAÇÃO REALIZADA COM SUCESSO", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch
            {
                MessageBox.Show("Erro de atualização", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }



        //METODO PARA CARREGAR OS DADOS PELO O ID
        private void button1_carregar_Click(object sender, EventArgs e)
        {

            string sql = "SELECT idpessoa,nome,sobrenome,sexo,datanascimento,endereco,telefone,email FROM pessoa WHERE idpessoa= @Idpessoa ";

            SqlConnection con = new SqlConnection(Strcon);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idpessoa", textBox1_idpessoa_atualizar.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            //
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1_idpessoa_retorno.Enabled = false;
                    textBox2_nome.Enabled = true;
                    textBox2_sobrenome.Enabled = true;
                    textBox1_SEXO.Enabled = true;
                    dateTimePicker1_nascimento.Enabled = true;
                    textBox_endereco.Enabled = true;
                    textBox1_telefone.Enabled = true;
                    textBox2_email.Enabled = true;

                    textBox1_idpessoa_atualizar.Focus();

                    textBox1_idpessoa_retorno.Text = reader[0].ToString();
                    textBox2_nome.Text = reader[1].ToString();
                    textBox2_sobrenome.Text = reader[2].ToString();
                    textBox1_SEXO.Text = reader[3].ToString();
                    dateTimePicker1_nascimento.Text = reader[4].ToString();
                    textBox_endereco.Text = reader[5].ToString();
                    textBox1_telefone.Text = reader[6].ToString();
                    textBox2_email.Text = reader[7].ToString();
                    
                }

                else
                    MessageBox.Show("NÃO EXISTE UM REGISTRO NO ID INFORMADO", "ERRO ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algumas informações referente ao ID que foi inserido esta vazia. ","FALTA DE INFORMAÇÕES",MessageBoxButtons.OK,MessageBoxIcon.Warning );
            }
            finally
            {
                con.Close();
            }




        }

        private void Form1_atualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
