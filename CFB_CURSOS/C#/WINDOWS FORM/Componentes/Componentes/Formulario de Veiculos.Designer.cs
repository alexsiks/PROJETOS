namespace Componentes
{
    partial class Formulario_de_Veiculos
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
            this.textBox_listaveiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_listaveiculo
            // 
            this.textBox_listaveiculo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_listaveiculo.HideSelection = false;
            this.textBox_listaveiculo.Location = new System.Drawing.Point(12, 12);
            this.textBox_listaveiculo.Multiline = true;
            this.textBox_listaveiculo.Name = "textBox_listaveiculo";
            this.textBox_listaveiculo.Size = new System.Drawing.Size(776, 287);
            this.textBox_listaveiculo.TabIndex = 0;
            this.textBox_listaveiculo.TextChanged += new System.EventHandler(this.textBox_listaveiculo_TextChanged);
            // 
            // Formulario_de_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_listaveiculo);
            this.MaximizeBox = false;
            this.Name = "Formulario_de_Veiculos";
            this.Text = "Formulario_de_Veiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_listaveiculo;
    }
}