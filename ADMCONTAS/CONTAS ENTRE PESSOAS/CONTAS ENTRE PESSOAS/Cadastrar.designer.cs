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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_principal));
            System.Windows.Forms.Label idPESSOALabel;
            System.Windows.Forms.Label fOTOLabel;
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
            this.label10_ = new System.Windows.Forms.Label();
            this.textBox1_telefone = new System.Windows.Forms.TextBox();
            this.label10_foto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2_email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.atualizar_CredoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_CONTASDataSet = new CONTAS_ENTRE_PESSOAS.BD_CONTASDataSet();
            this.pESSOATableAdapter = new CONTAS_ENTRE_PESSOAS.BD_CONTASDataSetTableAdapters.PESSOATableAdapter();
            this.tableAdapterManager = new CONTAS_ENTRE_PESSOAS.BD_CONTASDataSetTableAdapters.TableAdapterManager();
            this.pESSOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOABindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOABindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.idPESSOANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fOTOPictureBox = new System.Windows.Forms.PictureBox();
            idPESSOALabel = new System.Windows.Forms.Label();
            fOTOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atualizar_CredoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_CONTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPESSOANumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOTOPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_nome
            // 
            this.textBox1_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1_nome.Location = new System.Drawing.Point(125, 50);
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
            this.textBox2_sobrenome.Location = new System.Drawing.Point(125, 76);
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
            this.label1.Location = new System.Drawing.Point(77, 58);
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
            this.label2.Location = new System.Drawing.Point(41, 80);
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
            this.label3.Location = new System.Drawing.Point(77, 106);
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
            this.label4.Location = new System.Drawing.Point(235, 104);
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
            this.comboBox1_sexo.Location = new System.Drawing.Point(125, 102);
            this.comboBox1_sexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1_sexo.MaxLength = 1;
            this.comboBox1_sexo.Name = "comboBox1_sexo";
            this.comboBox1_sexo.Size = new System.Drawing.Size(103, 21);
            this.comboBox1_sexo.TabIndex = 8;
            // 
            // button2_cadastrar
            // 
            this.button2_cadastrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2_cadastrar.Location = new System.Drawing.Point(125, 181);
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
            this.label5.Location = new System.Drawing.Point(111, 13);
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
            this.label6.Location = new System.Drawing.Point(843, 51);
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
            this.label7.Location = new System.Drawing.Point(784, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "CADASTRAR";
            this.label7.UseWaitCursor = true;
            // 
            // textBox1_id
            // 
            this.textBox1_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1_id.Location = new System.Drawing.Point(37, 227);
            this.textBox1_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(132, 20);
            this.textBox1_id.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(141, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 26;
            this.label9.UseWaitCursor = true;
            // 
            // button1_buscar
            // 
            this.button1_buscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1_buscar.Location = new System.Drawing.Point(175, 225);
            this.button1_buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(129, 24);
            this.button1_buscar.TabIndex = 21;
            this.button1_buscar.Text = "PROCURAR PELO ID";
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // button1_buscardadosdatagrid
            // 
            this.button1_buscardadosdatagrid.Location = new System.Drawing.Point(889, 225);
            this.button1_buscardadosdatagrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1_buscardadosdatagrid.Name = "button1_buscardadosdatagrid";
            this.button1_buscardadosdatagrid.Size = new System.Drawing.Size(106, 24);
            this.button1_buscardadosdatagrid.TabIndex = 29;
            this.button1_buscardadosdatagrid.Text = "LISTAR TODOS ";
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
            this.dataGridView2_dados.Location = new System.Drawing.Point(37, 255);
            this.dataGridView2_dados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2_dados.Name = "dataGridView2_dados";
            this.dataGridView2_dados.ReadOnly = true;
            this.dataGridView2_dados.Size = new System.Drawing.Size(960, 198);
            this.dataGridView2_dados.TabIndex = 30;
            // 
            // button1_atualizardados
            // 
            this.button1_atualizardados.Location = new System.Drawing.Point(763, 225);
            this.button1_atualizardados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1_atualizardados.Name = "button1_atualizardados";
            this.button1_atualizardados.Size = new System.Drawing.Size(120, 24);
            this.button1_atualizardados.TabIndex = 31;
            this.button1_atualizardados.Text = "ATUALIZAR  DADOS ";
            this.button1_atualizardados.UseVisualStyleBackColor = true;
            this.button1_atualizardados.Click += new System.EventHandler(this.button1_atualizardados_Click);
            // 
            // dateTimePicker1_nascimento
            // 
            this.dateTimePicker1_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1_nascimento.Location = new System.Drawing.Point(323, 102);
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
            this.label8.Location = new System.Drawing.Point(45, 136);
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
            this.textBox_endereco.Location = new System.Drawing.Point(125, 130);
            this.textBox_endereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_endereco.Name = "textBox_endereco";
            this.textBox_endereco.Size = new System.Drawing.Size(389, 20);
            this.textBox_endereco.TabIndex = 33;
            // 
            // label10_
            // 
            this.label10_.AutoSize = true;
            this.label10_.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label10_.ForeColor = System.Drawing.Color.Transparent;
            this.label10_.Location = new System.Drawing.Point(48, 160);
            this.label10_.MaximumSize = new System.Drawing.Size(0, 50);
            this.label10_.Name = "label10_";
            this.label10_.Size = new System.Drawing.Size(66, 13);
            this.label10_.TabIndex = 35;
            this.label10_.Text = "TELEFONE:";
            this.label10_.UseWaitCursor = true;
            // 
            // textBox1_telefone
            // 
            this.textBox1_telefone.Location = new System.Drawing.Point(149, 157);
            this.textBox1_telefone.MaxLength = 10;
            this.textBox1_telefone.Name = "textBox1_telefone";
            this.textBox1_telefone.Size = new System.Drawing.Size(119, 20);
            this.textBox1_telefone.TabIndex = 36;
            // 
            // label10_foto
            // 
            this.label10_foto.AutoSize = true;
            this.label10_foto.Location = new System.Drawing.Point(548, 159);
            this.label10_foto.Name = "label10_foto";
            this.label10_foto.Size = new System.Drawing.Size(28, 13);
            this.label10_foto.TabIndex = 40;
            this.label10_foto.Text = "Foto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(276, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "EMAIL:";
            this.label10.UseWaitCursor = true;
            // 
            // textBox2_email
            // 
            this.textBox2_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2_email.Location = new System.Drawing.Point(324, 157);
            this.textBox2_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2_email.Name = "textBox2_email";
            this.textBox2_email.Size = new System.Drawing.Size(262, 20);
            this.textBox2_email.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // atualizar_CredoresBindingSource
            // 
            this.atualizar_CredoresBindingSource.DataSource = typeof(CONTAS_ENTRE_PESSOAS.Atualizar_Credores);
            // 
            // pESSOABindingSource
            // 
            this.pESSOABindingSource.DataMember = "PESSOA";
            this.pESSOABindingSource.DataSource = this.bD_CONTASDataSet;
            // 
            // bD_CONTASDataSet
            // 
            this.bD_CONTASDataSet.DataSetName = "BD_CONTASDataSet";
            this.bD_CONTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pESSOATableAdapter
            // 
            this.pESSOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PESSOATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CONTAS_ENTRE_PESSOAS.BD_CONTASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pESSOABindingSource1
            // 
            this.pESSOABindingSource1.DataMember = "PESSOA";
            this.pESSOABindingSource1.DataSource = this.bD_CONTASDataSet;
            // 
            // pESSOABindingSource2
            // 
            this.pESSOABindingSource2.DataMember = "PESSOA";
            this.pESSOABindingSource2.DataSource = this.bD_CONTASDataSet;
            // 
            // pESSOABindingSource3
            // 
            this.pESSOABindingSource3.DataMember = "PESSOA";
            this.pESSOABindingSource3.DataSource = this.bD_CONTASDataSet;
            // 
            // pESSOABindingSource4
            // 
            this.pESSOABindingSource4.DataMember = "PESSOA";
            this.pESSOABindingSource4.DataSource = this.bD_CONTASDataSet;
            // 
            // idPESSOALabel
            // 
            idPESSOALabel.AutoSize = true;
            idPESSOALabel.Location = new System.Drawing.Point(481, 27);
            idPESSOALabel.Name = "idPESSOALabel";
            idPESSOALabel.Size = new System.Drawing.Size(64, 13);
            idPESSOALabel.TabIndex = 42;
            idPESSOALabel.Text = "id PESSOA:";
            // 
            // idPESSOANumericUpDown
            // 
            this.idPESSOANumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pESSOABindingSource, "idPESSOA", true));
            this.idPESSOANumericUpDown.Location = new System.Drawing.Point(551, 27);
            this.idPESSOANumericUpDown.Name = "idPESSOANumericUpDown";
            this.idPESSOANumericUpDown.Size = new System.Drawing.Size(227, 20);
            this.idPESSOANumericUpDown.TabIndex = 43;
            // 
            // fOTOLabel
            // 
            fOTOLabel.AutoSize = true;
            fOTOLabel.Location = new System.Drawing.Point(481, 53);
            fOTOLabel.Name = "fOTOLabel";
            fOTOLabel.Size = new System.Drawing.Size(39, 13);
            fOTOLabel.TabIndex = 44;
            fOTOLabel.Text = "FOTO:";
            // 
            // fOTOPictureBox
            // 
            this.fOTOPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.fOTOPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pESSOABindingSource, "FOTO", true));
            this.fOTOPictureBox.Location = new System.Drawing.Point(592, 53);
            this.fOTOPictureBox.Name = "fOTOPictureBox";
            this.fOTOPictureBox.Size = new System.Drawing.Size(245, 165);
            this.fOTOPictureBox.TabIndex = 45;
            this.fOTOPictureBox.TabStop = false;
            // 
            // Form1_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(idPESSOALabel);
            this.Controls.Add(this.idPESSOANumericUpDown);
            this.Controls.Add(fOTOLabel);
            this.Controls.Add(this.fOTOPictureBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2_email);
            this.Controls.Add(this.label10_foto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1_telefone);
            this.Controls.Add(this.label10_);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atualizar_CredoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_CONTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPESSOANumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOTOPictureBox)).EndInit();
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
        private System.Windows.Forms.Label label10_;
        private System.Windows.Forms.TextBox textBox1_telefone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10_foto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2_email;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource atualizar_CredoresBindingSource;
        private CONTAS_ENTRE_PESSOAS.BD_CONTASDataSet bD_CONTASDataSet;
        private System.Windows.Forms.BindingSource pESSOABindingSource;
        private CONTAS_ENTRE_PESSOAS.BD_CONTASDataSetTableAdapters.PESSOATableAdapter pESSOATableAdapter;
        private CONTAS_ENTRE_PESSOAS.BD_CONTASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pESSOABindingSource1;
        private System.Windows.Forms.BindingSource pESSOABindingSource2;
        private System.Windows.Forms.BindingSource pESSOABindingSource3;
        private System.Windows.Forms.BindingSource pESSOABindingSource4;
        private System.Windows.Forms.NumericUpDown idPESSOANumericUpDown;
        private System.Windows.Forms.PictureBox fOTOPictureBox;
    }
}

