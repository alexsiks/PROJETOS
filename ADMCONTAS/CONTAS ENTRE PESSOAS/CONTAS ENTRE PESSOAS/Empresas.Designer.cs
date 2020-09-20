namespace CONTAS_ENTRE_PESSOAS
{
    partial class Empresas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresas));
            this.textBox1_Credor = new System.Windows.Forms.TextBox();
            this.label10_ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_TIPOCREDOR = new System.Windows.Forms.ComboBox();
            this.dataGridView1_informação = new System.Windows.Forms.DataGridView();
            this.textBox1_IDCREDOR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3_ATUALIARCREDOR = new System.Windows.Forms.Button();
            this.textBox1_COMENTARIO = new System.Windows.Forms.TextBox();
            this.button3_CADASTRAR_CREDOR = new System.Windows.Forms.Button();
            this.label2_COMENTARIO = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2_email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1_telefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_informação)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_Credor
            // 
            this.textBox1_Credor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1_Credor.Location = new System.Drawing.Point(131, 62);
            this.textBox1_Credor.Name = "textBox1_Credor";
            this.textBox1_Credor.Size = new System.Drawing.Size(527, 20);
            this.textBox1_Credor.TabIndex = 0;
            // 
            // label10_
            // 
            this.label10_.AutoSize = true;
            this.label10_.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label10_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10_.ForeColor = System.Drawing.Color.Transparent;
            this.label10_.Location = new System.Drawing.Point(68, 66);
            this.label10_.MaximumSize = new System.Drawing.Size(0, 50);
            this.label10_.Name = "label10_";
            this.label10_.Size = new System.Drawing.Size(63, 13);
            this.label10_.TabIndex = 36;
            this.label10_.Text = "CREDOR:";
            this.label10_.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label6.Font = new System.Drawing.Font("Castellar", 10.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(845, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "CREDORES";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label7.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(737, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 35);
            this.label7.TabIndex = 37;
            this.label7.Text = "CADASTRAR";
            this.label7.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 91);
            this.label1.MaximumSize = new System.Drawing.Size(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "TIPO DE CREDOR:";
            this.label1.UseWaitCursor = true;
            // 
            // comboBox1_TIPOCREDOR
            // 
            this.comboBox1_TIPOCREDOR.FormattingEnabled = true;
            this.comboBox1_TIPOCREDOR.Items.AddRange(new object[] {
            "FÍSICO",
            "JURÍDICO"});
            this.comboBox1_TIPOCREDOR.Location = new System.Drawing.Point(131, 88);
            this.comboBox1_TIPOCREDOR.MaxLength = 8;
            this.comboBox1_TIPOCREDOR.Name = "comboBox1_TIPOCREDOR";
            this.comboBox1_TIPOCREDOR.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_TIPOCREDOR.TabIndex = 41;
            // 
            // dataGridView1_informação
            // 
            this.dataGridView1_informação.AllowUserToAddRows = false;
            this.dataGridView1_informação.AllowUserToDeleteRows = false;
            this.dataGridView1_informação.AllowUserToOrderColumns = true;
            this.dataGridView1_informação.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_informação.Location = new System.Drawing.Point(35, 343);
            this.dataGridView1_informação.Name = "dataGridView1_informação";
            this.dataGridView1_informação.ReadOnly = true;
            this.dataGridView1_informação.Size = new System.Drawing.Size(916, 194);
            this.dataGridView1_informação.TabIndex = 42;
            // 
            // textBox1_IDCREDOR
            // 
            this.textBox1_IDCREDOR.Location = new System.Drawing.Point(37, 319);
            this.textBox1_IDCREDOR.Name = "textBox1_IDCREDOR";
            this.textBox1_IDCREDOR.Size = new System.Drawing.Size(100, 20);
            this.textBox1_IDCREDOR.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "ENCONTRAR ID DO CREDOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "VER TODOS  OS CREDORES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3_ATUALIARCREDOR
            // 
            this.button3_ATUALIARCREDOR.Location = new System.Drawing.Point(320, 319);
            this.button3_ATUALIARCREDOR.Name = "button3_ATUALIARCREDOR";
            this.button3_ATUALIARCREDOR.Size = new System.Drawing.Size(133, 22);
            this.button3_ATUALIARCREDOR.TabIndex = 46;
            this.button3_ATUALIARCREDOR.Text = "ATUALIZAR CREDOR";
            this.button3_ATUALIARCREDOR.UseVisualStyleBackColor = true;
            this.button3_ATUALIARCREDOR.Click += new System.EventHandler(this.button3_ATUALIARCREDOR_Click);
            // 
            // textBox1_COMENTARIO
            // 
            this.textBox1_COMENTARIO.Location = new System.Drawing.Point(132, 149);
            this.textBox1_COMENTARIO.Multiline = true;
            this.textBox1_COMENTARIO.Name = "textBox1_COMENTARIO";
            this.textBox1_COMENTARIO.Size = new System.Drawing.Size(804, 109);
            this.textBox1_COMENTARIO.TabIndex = 47;
            // 
            // button3_CADASTRAR_CREDOR
            // 
            this.button3_CADASTRAR_CREDOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3_CADASTRAR_CREDOR.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3_CADASTRAR_CREDOR.Location = new System.Drawing.Point(307, 264);
            this.button3_CADASTRAR_CREDOR.Name = "button3_CADASTRAR_CREDOR";
            this.button3_CADASTRAR_CREDOR.Size = new System.Drawing.Size(136, 35);
            this.button3_CADASTRAR_CREDOR.TabIndex = 48;
            this.button3_CADASTRAR_CREDOR.Text = "CADASTRAR CREDOR";
            this.button3_CADASTRAR_CREDOR.UseVisualStyleBackColor = true;
            this.button3_CADASTRAR_CREDOR.Click += new System.EventHandler(this.button3_CADASTRAR_CREDOR_Click);
            // 
            // label2_COMENTARIO
            // 
            this.label2_COMENTARIO.AutoSize = true;
            this.label2_COMENTARIO.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2_COMENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_COMENTARIO.ForeColor = System.Drawing.Color.Transparent;
            this.label2_COMENTARIO.Location = new System.Drawing.Point(38, 149);
            this.label2_COMENTARIO.MaximumSize = new System.Drawing.Size(0, 50);
            this.label2_COMENTARIO.Name = "label2_COMENTARIO";
            this.label2_COMENTARIO.Size = new System.Drawing.Size(93, 13);
            this.label2_COMENTARIO.TabIndex = 49;
            this.label2_COMENTARIO.Text = "COMENTÁRIO:";
            this.label2_COMENTARIO.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(259, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "EMAIL:";
            this.label10.UseWaitCursor = true;
            // 
            // textBox2_email
            // 
            this.textBox2_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2_email.Location = new System.Drawing.Point(307, 117);
            this.textBox2_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2_email.Name = "textBox2_email";
            this.textBox2_email.Size = new System.Drawing.Size(351, 20);
            this.textBox2_email.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1_telefone
            // 
            this.textBox1_telefone.Location = new System.Drawing.Point(132, 117);
            this.textBox1_telefone.MaxLength = 11;
            this.textBox1_telefone.Name = "textBox1_telefone";
            this.textBox1_telefone.Size = new System.Drawing.Size(119, 20);
            this.textBox1_telefone.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 120);
            this.label2.MaximumSize = new System.Drawing.Size(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "TELEFONE:";
            this.label2.UseWaitCursor = true;
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2_email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label2_COMENTARIO);
            this.Controls.Add(this.button3_CADASTRAR_CREDOR);
            this.Controls.Add(this.textBox1_COMENTARIO);
            this.Controls.Add(this.button3_ATUALIARCREDOR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_IDCREDOR);
            this.Controls.Add(this.dataGridView1_informação);
            this.Controls.Add(this.comboBox1_TIPOCREDOR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10_);
            this.Controls.Add(this.textBox1_Credor);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Empresas";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Empresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_informação)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_Credor;
        private System.Windows.Forms.Label label10_;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_TIPOCREDOR;
        private System.Windows.Forms.DataGridView dataGridView1_informação;
        private System.Windows.Forms.TextBox textBox1_IDCREDOR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3_ATUALIARCREDOR;
        private System.Windows.Forms.TextBox textBox1_COMENTARIO;
        private System.Windows.Forms.Button button3_CADASTRAR_CREDOR;
        private System.Windows.Forms.Label label2_COMENTARIO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1_telefone;
        private System.Windows.Forms.Label label2;
    }
}