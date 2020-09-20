namespace Formulario_de_cadastro
{
    partial class frmAluno
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeAlunoLabel;
            System.Windows.Forms.Label sobrenomeAlunoLabel;
            System.Windows.Forms.Label telefoneAlunoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
            System.Windows.Forms.Label idAlunoLabel2;
            this.dBCadastrarAulaDataSet11 = new Formulario_de_cadastro.DBCadastrarAulaDataSet1();
            this.tBAlunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBAlunosTableAdapter = new Formulario_de_cadastro.DBCadastrarAulaDataSet1TableAdapters.TBAlunosTableAdapter();
            this.tableAdapterManager = new Formulario_de_cadastro.DBCadastrarAulaDataSet1TableAdapters.TableAdapterManager();
            this.tBAlunosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tBAlunosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dbCadastrarAulaDataSet1 = new Formulario_de_cadastro.DBCadastrarAulaDataSet();
            this.nomeAlunoTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeAlunoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneAlunoTextBox = new System.Windows.Forms.TextBox();
            this.idAlunoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            nomeAlunoLabel = new System.Windows.Forms.Label();
            sobrenomeAlunoLabel = new System.Windows.Forms.Label();
            telefoneAlunoLabel = new System.Windows.Forms.Label();
            idAlunoLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCadastrarAulaDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAlunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAlunosBindingNavigator)).BeginInit();
            this.tBAlunosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbCadastrarAulaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idAlunoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeAlunoLabel
            // 
            nomeAlunoLabel.AutoSize = true;
            nomeAlunoLabel.Location = new System.Drawing.Point(38, 77);
            nomeAlunoLabel.Name = "nomeAlunoLabel";
            nomeAlunoLabel.Size = new System.Drawing.Size(66, 13);
            nomeAlunoLabel.TabIndex = 9;
            nomeAlunoLabel.Text = "nome Aluno:";
            // 
            // sobrenomeAlunoLabel
            // 
            sobrenomeAlunoLabel.AutoSize = true;
            sobrenomeAlunoLabel.Location = new System.Drawing.Point(12, 106);
            sobrenomeAlunoLabel.Name = "sobrenomeAlunoLabel";
            sobrenomeAlunoLabel.Size = new System.Drawing.Size(92, 13);
            sobrenomeAlunoLabel.TabIndex = 10;
            sobrenomeAlunoLabel.Text = "sobrenome Aluno:";
            // 
            // telefoneAlunoLabel
            // 
            telefoneAlunoLabel.AutoSize = true;
            telefoneAlunoLabel.Location = new System.Drawing.Point(26, 135);
            telefoneAlunoLabel.Name = "telefoneAlunoLabel";
            telefoneAlunoLabel.Size = new System.Drawing.Size(78, 13);
            telefoneAlunoLabel.TabIndex = 11;
            telefoneAlunoLabel.Text = "telefone Aluno:";
            // 
            // dBCadastrarAulaDataSet11
            // 
            this.dBCadastrarAulaDataSet11.DataSetName = "DBCadastrarAulaDataSet1";
            this.dBCadastrarAulaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBAlunosBindingSource
            // 
            this.tBAlunosBindingSource.DataMember = "TBAlunos";
            this.tBAlunosBindingSource.DataSource = this.dBCadastrarAulaDataSet11;
            // 
            // tBAlunosTableAdapter
            // 
            this.tBAlunosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBAlunosTableAdapter = this.tBAlunosTableAdapter;
            this.tableAdapterManager.TBAulasTableAdapter = null;
            this.tableAdapterManager.TBProfessoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Formulario_de_cadastro.DBCadastrarAulaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tBAlunosBindingNavigator
            // 
            this.tBAlunosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tBAlunosBindingNavigator.BindingSource = this.tBAlunosBindingSource;
            this.tBAlunosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tBAlunosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tBAlunosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tBAlunosBindingNavigatorSaveItem});
            this.tBAlunosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tBAlunosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tBAlunosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tBAlunosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tBAlunosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tBAlunosBindingNavigator.Name = "tBAlunosBindingNavigator";
            this.tBAlunosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tBAlunosBindingNavigator.Size = new System.Drawing.Size(443, 25);
            this.tBAlunosBindingNavigator.TabIndex = 0;
            this.tBAlunosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tBAlunosBindingNavigatorSaveItem
            // 
            this.tBAlunosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBAlunosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tBAlunosBindingNavigatorSaveItem.Image")));
            this.tBAlunosBindingNavigatorSaveItem.Name = "tBAlunosBindingNavigatorSaveItem";
            this.tBAlunosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tBAlunosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tBAlunosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tBAlunosBindingNavigatorSaveItem_Click);
            // 
            // dbCadastrarAulaDataSet1
            // 
            this.dbCadastrarAulaDataSet1.DataSetName = "DBCadastrarAulaDataSet";
            this.dbCadastrarAulaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeAlunoTextBox
            // 
            this.nomeAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBAlunosBindingSource, "nomeAluno", true));
            this.nomeAlunoTextBox.Location = new System.Drawing.Point(110, 77);
            this.nomeAlunoTextBox.MaxLength = 20;
            this.nomeAlunoTextBox.Name = "nomeAlunoTextBox";
            this.nomeAlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeAlunoTextBox.TabIndex = 10;
            // 
            // sobrenomeAlunoTextBox
            // 
            this.sobrenomeAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBAlunosBindingSource, "sobrenomeAluno", true));
            this.sobrenomeAlunoTextBox.Location = new System.Drawing.Point(110, 106);
            this.sobrenomeAlunoTextBox.Name = "sobrenomeAlunoTextBox";
            this.sobrenomeAlunoTextBox.Size = new System.Drawing.Size(213, 20);
            this.sobrenomeAlunoTextBox.TabIndex = 11;
            // 
            // telefoneAlunoTextBox
            // 
            this.telefoneAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBAlunosBindingSource, "telefoneAluno", true));
            this.telefoneAlunoTextBox.Location = new System.Drawing.Point(110, 132);
            this.telefoneAlunoTextBox.Name = "telefoneAlunoTextBox";
            this.telefoneAlunoTextBox.Size = new System.Drawing.Size(118, 20);
            this.telefoneAlunoTextBox.TabIndex = 12;
            // 
            // idAlunoLabel2
            // 
            idAlunoLabel2.AutoSize = true;
            idAlunoLabel2.Location = new System.Drawing.Point(56, 49);
            idAlunoLabel2.Name = "idAlunoLabel2";
            idAlunoLabel2.Size = new System.Drawing.Size(48, 13);
            idAlunoLabel2.TabIndex = 12;
            idAlunoLabel2.Text = "id Aluno:";
            // 
            // idAlunoNumericUpDown
            // 
            this.idAlunoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tBAlunosBindingSource, "idAluno", true));
            this.idAlunoNumericUpDown.Location = new System.Drawing.Point(110, 49);
            this.idAlunoNumericUpDown.Name = "idAlunoNumericUpDown";
            this.idAlunoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.idAlunoNumericUpDown.TabIndex = 13;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(idAlunoLabel2);
            this.Controls.Add(this.idAlunoNumericUpDown);
            this.Controls.Add(telefoneAlunoLabel);
            this.Controls.Add(this.telefoneAlunoTextBox);
            this.Controls.Add(sobrenomeAlunoLabel);
            this.Controls.Add(this.sobrenomeAlunoTextBox);
            this.Controls.Add(nomeAlunoLabel);
            this.Controls.Add(this.nomeAlunoTextBox);
            this.Controls.Add(this.tBAlunosBindingNavigator);
            this.Name = "frmAluno";
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCadastrarAulaDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAlunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAlunosBindingNavigator)).EndInit();
            this.tBAlunosBindingNavigator.ResumeLayout(false);
            this.tBAlunosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbCadastrarAulaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idAlunoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBCadastrarAulaDataSet dbCadastrarAulaDataSet1;
        private DBCadastrarAulaDataSet1 dBCadastrarAulaDataSet11;
        private System.Windows.Forms.BindingSource tBAlunosBindingSource;
        private DBCadastrarAulaDataSet1TableAdapters.TBAlunosTableAdapter tBAlunosTableAdapter;
        private DBCadastrarAulaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tBAlunosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tBAlunosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeAlunoTextBox;
        private System.Windows.Forms.TextBox sobrenomeAlunoTextBox;
        private System.Windows.Forms.TextBox telefoneAlunoTextBox;
        private System.Windows.Forms.NumericUpDown idAlunoNumericUpDown;
    }
}