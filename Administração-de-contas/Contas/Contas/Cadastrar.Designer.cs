namespace Contas
{
    partial class Form1_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Contas.Properties.Settings settings3 = new Contas.Properties.Settings();
            Contas.Properties.Settings settings4 = new Contas.Properties.Settings();
            this.textBox1_nome = new System.Windows.Forms.TextBox();
            this.textBox2_sobrenome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1_sexo = new System.Windows.Forms.ComboBox();
            this.button2_cadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1_buscar = new System.Windows.Forms.Button();
            this.button1_buscardadosdatagrid = new System.Windows.Forms.Button();
            this.dataGridView2_dados = new System.Windows.Forms.DataGridView();
            this.button1_atualizardados = new System.Windows.Forms.Button();
            this.dateTimePicker1_nascimento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_endereco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_nome
            // 
            this.textBox1_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1_nome.Location = new System.Drawing.Point(100, 46);
            this.textBox1_nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1_nome.MaxLength = 15;
            this.textBox1_nome.Name = "textBox1_nome";
            this.textBox1_nome.Size = new System.Drawing.Size(150, 20);
            this.textBox1_nome.TabIndex = 0;
            // 
            // textBox2_sobrenome
            // 
            this.textBox2_sobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2_sobrenome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2_sobrenome.Location = new System.Drawing.Point(100, 72);
            this.textBox2_sobrenome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2_sobrenome.Name = "textBox2_sobrenome";
            this.textBox2_sobrenome.Size = new System.Drawing.Size(272, 20);
            this.textBox2_sobrenome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.MaximumSize = new System.Drawing.Size(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SOBRENOME:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEXO:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(210, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NASCIMENTO:";
            this.label4.UseWaitCursor = true;
            // 
            // comboBox1_sexo
            // 
            this.comboBox1_sexo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox1_sexo.DisplayMember = "Escolha o Sexo";
            this.comboBox1_sexo.FormattingEnabled = true;
            this.comboBox1_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox1_sexo.Location = new System.Drawing.Point(100, 98);
            this.comboBox1_sexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1_sexo.MaxLength = 1;
            this.comboBox1_sexo.Name = "comboBox1_sexo";
            this.comboBox1_sexo.Size = new System.Drawing.Size(103, 21);
            this.comboBox1_sexo.TabIndex = 8;
            // 
            // button2_cadastrar
            // 
            this.button2_cadastrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2_cadastrar.Location = new System.Drawing.Point(100, 160);
            this.button2_cadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2_cadastrar.Name = "button2_cadastrar";
            this.button2_cadastrar.Size = new System.Drawing.Size(102, 30);
            this.button2_cadastrar.TabIndex = 10;
            this.button2_cadastrar.Text = "CADASTRAR";
            this.button2_cadastrar.UseVisualStyleBackColor = true;
            this.button2_cadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 34);
            this.label5.TabIndex = 17;
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label6.Font = new System.Drawing.Font("Castellar", 10.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(498, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "PESSOAS PARCEIRAS";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label7.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(375, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "CADASTRAR";
            this.label7.UseWaitCursor = true;
            // 
            // textBox1_id
            // 
            this.textBox1_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1_id.Location = new System.Drawing.Point(12, 223);
            this.textBox1_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(140, 20);
            this.textBox1_id.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(116, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 26;
            this.label9.UseWaitCursor = true;
            // 
            // button1_buscar
            // 
            this.button1_buscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            settings3.dia = "VISUALIZAR PESSOAS CADASTRADAS";
            settings3.SettingsKey = "";
            this.button1_buscar.DataBindings.Add(new System.Windows.Forms.Binding("Text", settings3, "dia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1_buscar.Location = new System.Drawing.Point(168, 221);
            this.button1_buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(177, 24);
            this.button1_buscar.TabIndex = 21;
            this.button1_buscar.Text = settings3.dia;
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // button1_buscardadosdatagrid
            // 
            this.button1_buscardadosdatagrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            settings4.dia = "VISUALIZAR PESSOAS CADASTRADAS";
            settings4.SettingsKey = "";
            this.button1_buscardadosdatagrid.DataBindings.Add(new System.Windows.Forms.Binding("Text", settings4, "dia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1_buscardadosdatagrid.Location = new System.Drawing.Point(702, 222);
            this.button1_buscardadosdatagrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1_buscardadosdatagrid.Name = "button1_buscardadosdatagrid";
            this.button1_buscardadosdatagrid.Size = new System.Drawing.Size(218, 24);
            this.button1_buscardadosdatagrid.TabIndex = 29;
            this.button1_buscardadosdatagrid.Text = settings4.dia;
            this.button1_buscardadosdatagrid.UseVisualStyleBackColor = true;
            this.button1_buscardadosdatagrid.Click += new System.EventHandler(this.button1_buscardadosdatagrid_Click);
            // 
            // dataGridView2_dados
            // 
            this.dataGridView2_dados.AllowUserToAddRows = false;
            this.dataGridView2_dados.AllowUserToDeleteRows = false;
            this.dataGridView2_dados.AllowUserToOrderColumns = true;
            this.dataGridView2_dados.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView2_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_dados.Location = new System.Drawing.Point(12, 251);
            this.dataGridView2_dados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2_dados.Name = "dataGridView2_dados";
            this.dataGridView2_dados.ReadOnly = true;
            this.dataGridView2_dados.Size = new System.Drawing.Size(960, 198);
            this.dataGridView2_dados.TabIndex = 30;
            // 
            // button1_atualizardados
            // 
            this.button1_atualizardados.Location = new System.Drawing.Point(511, 222);
            this.button1_atualizardados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1_atualizardados.Name = "button1_atualizardados";
            this.button1_atualizardados.Size = new System.Drawing.Size(99, 24);
            this.button1_atualizardados.TabIndex = 31;
            this.button1_atualizardados.Text = "ATUALIZAR ";
            this.button1_atualizardados.UseVisualStyleBackColor = true;
            this.button1_atualizardados.Click += new System.EventHandler(this.button1_atualizardados_Click);
            // 
            // dateTimePicker1_nascimento
            // 
            this.dateTimePicker1_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1_nascimento.Location = new System.Drawing.Point(298, 98);
            this.dateTimePicker1_nascimento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1_nascimento.Name = "dateTimePicker1_nascimento";
            this.dateTimePicker1_nascimento.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1_nascimento.TabIndex = 32;
            this.dateTimePicker1_nascimento.Value = new System.DateTime(2020, 7, 4, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(20, 132);
            this.label8.MaximumSize = new System.Drawing.Size(0, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "ENDEREÇO :";
            this.label8.UseWaitCursor = true;
            // 
            // textBox_endereco
            // 
            this.textBox_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_endereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_endereco.Location = new System.Drawing.Point(100, 126);
            this.textBox_endereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_endereco.Name = "textBox_endereco";
            this.textBox_endereco.Size = new System.Drawing.Size(438, 20);
            this.textBox_endereco.TabIndex = 33;
            // 
            // Form1_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_endereco);
            this.Controls.Add(this.dateTimePicker1_nascimento);
            this.Controls.Add(this.button1_atualizardados);
            this.Controls.Add(this.dataGridView2_dados);
            this.Controls.Add(this.button1_buscardadosdatagrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2_cadastrar);
            this.Controls.Add(this.comboBox1_sexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2_sobrenome);
            this.Controls.Add(this.textBox1_nome);
            this.ForeColor = System.Drawing.Color.Black;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1_principal";
            this.Text = "Formulario de Cadastro";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_nome;
        private System.Windows.Forms.TextBox textBox2_sobrenome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1_sexo;
        private System.Windows.Forms.Button button2_cadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1_buscardadosdatagrid;
        private System.Windows.Forms.DataGridView dataGridView2_dados;
        private System.Windows.Forms.Button button1_atualizardados;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_nascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_endereco;
    }
}

