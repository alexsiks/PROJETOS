namespace CONTAS_ENTRE_PESSOAS
{
    partial class Preenchimento
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
            this.textBox1_valor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1_valor2
            // 
            this.textBox1_valor2.Location = new System.Drawing.Point(136, 37);
            this.textBox1_valor2.Name = "textBox1_valor2";
            this.textBox1_valor2.Size = new System.Drawing.Size(168, 20);
            this.textBox1_valor2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INSIRA UM NÚMERO:";
            // 
            // Preenchimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_valor2);
            this.Name = "Preenchimento";
            this.Text = "Preenchimento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Preenchimento_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_valor2;
        private System.Windows.Forms.Label label1;
    }
}