namespace WindowsForms
{
    partial class FRM_1
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
            this.TXB_1 = new System.Windows.Forms.TextBox();
            this.LB_1 = new System.Windows.Forms.Label();
            this.BT_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXB_1
            // 
            this.TXB_1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXB_1.Location = new System.Drawing.Point(95, 135);
            this.TXB_1.MaxLength = 10;
            this.TXB_1.Name = "TXB_1";
            this.TXB_1.Size = new System.Drawing.Size(227, 20);
            this.TXB_1.TabIndex = 0;
            this.TXB_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXB_1.TextChanged += new System.EventHandler(this.TXB_1_TextChanged);
            // 
            // LB_1
            // 
            this.LB_1.AutoSize = true;
            this.LB_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_1.ForeColor = System.Drawing.Color.Orange;
            this.LB_1.Location = new System.Drawing.Point(107, 243);
            this.LB_1.Name = "LB_1";
            this.LB_1.Size = new System.Drawing.Size(199, 31);
            this.LB_1.TabIndex = 1;
            this.LB_1.Text = "INFORMAÇÃO";
            this.LB_1.Click += new System.EventHandler(this.LB_1_Click);
            // 
            // BT_1
            // 
            this.BT_1.BackColor = System.Drawing.Color.Black;
            this.BT_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BT_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BT_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BT_1.ForeColor = System.Drawing.Color.Orange;
            this.BT_1.Location = new System.Drawing.Point(95, 174);
            this.BT_1.Name = "BT_1";
            this.BT_1.Size = new System.Drawing.Size(227, 41);
            this.BT_1.TabIndex = 2;
            this.BT_1.Text = "Transformar";
            this.BT_1.UseVisualStyleBackColor = false;
            this.BT_1.Click += new System.EventHandler(this.BT_1_Click);
            // 
            // FRM_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.BT_1);
            this.Controls.Add(this.LB_1);
            this.Controls.Add(this.TXB_1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "FRM_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_1;
        private System.Windows.Forms.Label LB_1;
        private System.Windows.Forms.Button BT_1;
    }
}

