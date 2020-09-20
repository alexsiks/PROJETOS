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
    public partial class Atualizar_Credores : Form
    {
        public Atualizar_Credores()
        {
            InitializeComponent();
        }
        SqlConnection Sqlcon = null;
        private string Strcon = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=BD_CONTAS;Integrated Security=True";
        private string Strsql = string.Empty;

        private void Atualizar_Credores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Comando de construção de comando.
            string sql = "SELECT idCREDOR,NOME,TIPOCREDOR,TELEFONE,EMAIL,COMENTARIO FROM CREDOR WHERE idCREDOR= @IDCREDOR ";

            //
            SqlConnection con = new SqlConnection(Strcon);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idCREDOR", textBox1_IDCREDOR_busca.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            //
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1_idretorno.Enabled = false;
                    textBox1_IDCREDOR_busca.Enabled = true;
                    textBox1_Credor.Enabled = true;
                    comboBox1_TIPOCREDOR.Enabled = true;
                    textBox1_telefone.Enabled = true;
                    textBox2_email.Enabled = true;
                    textBox1_COMENTARIO.Enabled = true;
                    
                    textBox1_IDCREDOR_busca.Focus();

                    textBox1_idretorno.Text = reader[0].ToString();
                    textBox1_Credor.Text = reader[1].ToString();
                    comboBox1_TIPOCREDOR.Text = reader[2].ToString();
                    textBox1_telefone.Text = reader[3].ToString();
                    textBox2_email.Text = reader[4].ToString();
                    textBox1_COMENTARIO.Text = reader[5].ToString();
                   
                }

                else
                    MessageBox.Show("NÃO EXISTE UM REGISTRO NO ID INFORMADO", "ERRO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algumas informações referente ao ID que foi inserido esta vazia. ", "FALTA DE INFORMAÇÕES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }


        }

        private void button3_ATUALIARCREDOR_Click(object sender, EventArgs e)
        {



            string sql = $"  update credor set " +
                $"nome = '{textBox1_Credor.Text}'," +
                $"tipocredor = '{comboBox1_TIPOCREDOR.Text}'," +
                $" telefone = '{textBox1_telefone.Text}'," +
                $"email = '{textBox2_email.Text}'," +
                $"ATUALIZACAODADOS = GETDATE(), " +
                $"comentario = '{textBox1_COMENTARIO.Text}'  where idcredor = {textBox1_IDCREDOR_busca.Text}";

            SqlConnection con = new SqlConnection(Strcon);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            try
            {

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

        private void textBox1_idretorno_TextChanged(object sender, EventArgs e)
        {
            
            textBox1_IDCREDOR_busca.Focus();
        }

        private void textBox1_IDCREDOR_busca_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
