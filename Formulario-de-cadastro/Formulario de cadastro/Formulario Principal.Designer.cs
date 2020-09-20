namespace Formulario_de_cadastro
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
            System.Windows.Forms.ToolStripButton tsbProfessor;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAluno = new System.Windows.Forms.ToolStripButton();
            this.tsbAula = new System.Windows.Forms.ToolStripButton();
            tsbProfessor = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbProfessor
            // 
            tsbProfessor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbProfessor.Image = ((System.Drawing.Image)(resources.GetObject("tsbProfessor.Image")));
            tsbProfessor.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbProfessor.Name = "tsbProfessor";
            tsbProfessor.Size = new System.Drawing.Size(60, 22);
            tsbProfessor.Text = "Professor";
            tsbProfessor.Click += new System.EventHandler(this.tsbProfessor_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAluno,
            tsbProfessor,
            this.tsbAula});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(277, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAluno
            // 
            this.tsbAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAluno.Image = ((System.Drawing.Image)(resources.GetObject("tsbAluno.Image")));
            this.tsbAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAluno.Name = "tsbAluno";
            this.tsbAluno.Size = new System.Drawing.Size(43, 22);
            this.tsbAluno.Text = "Aluno";
            this.tsbAluno.Click += new System.EventHandler(this.tsbAluno_Click);
            // 
            // tsbAula
            // 
            this.tsbAula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAula.Image = ((System.Drawing.Image)(resources.GetObject("tsbAula.Image")));
            this.tsbAula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAula.Name = "tsbAula";
            this.tsbAula.Size = new System.Drawing.Size(35, 22);
            this.tsbAula.Text = "Aula";
            this.tsbAula.Click += new System.EventHandler(this.tsbAula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(277, 450);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form1";
            this.Text = "Formulario de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAluno;
        private System.Windows.Forms.ToolStripButton tsbAula;
    }
}

