namespace Projeto_de_Clientes
    {
    partial class Form1
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
            System.Windows.Forms.TextBox Valor1;
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Somar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Valor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            Valor1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Valor1
            // 
            Valor1.Location = new System.Drawing.Point(30, 52);
            Valor1.Name = "Valor1";
            Valor1.Size = new System.Drawing.Size(100, 20);
            Valor1.TabIndex = 3;
            Valor1.Visible = false;
            Valor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Somar
            // 
            this.Somar.Location = new System.Drawing.Point(30, 135);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(82, 38);
            this.Somar.TabIndex = 0;
            this.Somar.Text = "Somar";
            this.Somar.UseVisualStyleBackColor = true;
            this.Somar.Click += new System.EventHandler(this.Caucular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Valor2
            // 
            this.Valor2.Location = new System.Drawing.Point(253, 52);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(100, 20);
            this.Valor2.TabIndex = 4;
            this.Valor2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(12, 273);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(365, 20);
            this.Resultado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(144, 311);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(104, 64);
            this.Sair.TabIndex = 9;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            // 
            // Subtrair
            // 
            this.Subtrair.Location = new System.Drawing.Point(295, 135);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(82, 38);
            this.Subtrair.TabIndex = 10;
            this.Subtrair.Text = "Subtrair";
            this.Subtrair.UseVisualStyleBackColor = true;
            // 
            // Dividir
            // 
            this.Dividir.Location = new System.Drawing.Point(118, 135);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(82, 38);
            this.Dividir.TabIndex = 11;
            this.Dividir.Text = "Dividir";
            this.Dividir.UseVisualStyleBackColor = true;
            // 
            // Multiplicar
            // 
            this.Multiplicar.Location = new System.Drawing.Point(206, 135);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(82, 38);
            this.Multiplicar.TabIndex = 12;
            this.Multiplicar.Text = "Multiplicar";
            this.Multiplicar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(389, 398);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Subtrair);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(Valor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Somar);
            this.Name = "Form1";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Form1_ControlAdded);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Valor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button Multiplicar;
        }
    }
