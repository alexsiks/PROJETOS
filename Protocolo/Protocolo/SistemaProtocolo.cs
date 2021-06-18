using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace Protocolo
{
    public partial class SistemaProtocolo : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;

        public SistemaProtocolo()
        {
            InitializeComponent();
        }

        
      
        //botão de cadastro
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("O campo não pode estar vazio.","Erro de Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                comboBox1.Focus();
            }

            else
            {

                try
                {
                    conexao = new MySqlConnection("Server=192.168.100.112;Port=3306;Database=empresa;Uid=programa;Pwd=123;");

                    strSql = $"insert into protocolo (situacao,motivo,memorando,dat_registro) values (@situacao,@motivo,@memorando,now())";

                    comando = new MySqlCommand(strSql, conexao);

                    comando.Parameters.AddWithValue("@motivo", comboBox1.Text);
                    comando.Parameters.AddWithValue("@situacao", comboBox2.Text);
                    comando.Parameters.AddWithValue("@memorando", textBox1.Text);

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Protocolo Registrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                }


            }

        }
        //caixa de seleção
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //BOTÃO DE VISUALIZAÇÃO
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Não é possivel visualizar informações, informe o código do protolcolo","Erro de Busca",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {


                    conexao = new MySqlConnection("Server=192.168.100.112;Port=3306;Database=empresa;Uid=programa;Pwd=123;");

                    strSql = $"SELECT id as CODIGO,situacao AS SITUACAO,motivo AS MOTIVO,memorando AS DESCRICAO,dat_registro as DATA_REGISTRO,DAT_ATUALIZACAO AS DATA_ATUALIZACAO FROM PROTOCOLO where" +
                        $" id like '%{textBox2.Text}%' ||" +
                        $"situacao like '%{textBox2.Text}%' ||" +
                        $"motivo like '%{textBox2.Text}%' ||" +
                        $"dat_registro like '%{textBox2.Text}%'";

                    da = new MySqlDataAdapter(strSql, conexao);

                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;


                                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                }

            }


        }
        
        private void scanear_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=192.168.100.112;Port=3306;Database=empresa;Uid=programa;Pwd=123;");
                strSql = "select * from protocolo where id = @ID";

                comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@ID",texto_escanear.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    
                    comboBox1.Text = Convert.ToString(dr["motivo"]);
                    comboBox2.Text = Convert.ToString(dr["situacao"]);
                    
                    textBox1.Text = Convert.ToString(dr["memorando"]);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel recuperar os dados","erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
            




        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new MySqlConnection("Server=192.168.100.112;Port=3306;Database=empresa;Uid=programa;Pwd=123;");

                strSql = $"UPDATE protocolo SET SITUACAO = @situacao , motivo = @motivo , memorando = @memorando , DAT_ATUALIZACAO = NOW() where id = {texto_escanear.Text}";

                comando = new MySqlCommand(strSql, conexao);

                comando.Parameters.AddWithValue("@situacao", comboBox2.Text);
                comando.Parameters.AddWithValue("@motivo", comboBox1.Text);
                comando.Parameters.AddWithValue("@memorando", textBox1.Text);
                
                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Registros atualizados", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void SistemaProtocolo_Load(object sender, EventArgs e)
        {

        }
    }
}
