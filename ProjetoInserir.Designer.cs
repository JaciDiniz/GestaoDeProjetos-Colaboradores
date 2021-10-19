
namespace Gestão_de_Projetos
{
    partial class ProjetoInserir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjetoInserir));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_adicionarProjeto = new System.Windows.Forms.Button();
            this.clb_Tec = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Descricao = new System.Windows.Forms.RichTextBox();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.projetoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_ColaboradoresDataSet = new Gestão_de_Projetos.db_ColaboradoresDataSet();
            this.projetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoTableAdapter = new Gestão_de_Projetos.db_ColaboradoresDataSetTableAdapters.projetoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ColaboradoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_adicionarProjeto);
            this.groupBox1.Controls.Add(this.clb_Tec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_Descricao);
            this.groupBox1.Controls.Add(this.txb_Nome);
            this.groupBox1.Location = new System.Drawing.Point(20, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Projeto";
            // 
            // btn_adicionarProjeto
            // 
            this.btn_adicionarProjeto.Location = new System.Drawing.Point(588, 35);
            this.btn_adicionarProjeto.Name = "btn_adicionarProjeto";
            this.btn_adicionarProjeto.Size = new System.Drawing.Size(95, 33);
            this.btn_adicionarProjeto.TabIndex = 8;
            this.btn_adicionarProjeto.Text = "Adicionar Projeto";
            this.btn_adicionarProjeto.UseVisualStyleBackColor = true;
            this.btn_adicionarProjeto.Click += new System.EventHandler(this.btn_adicionarProjeto_Click);
            // 
            // clb_Tec
            // 
            this.clb_Tec.FormattingEnabled = true;
            this.clb_Tec.Location = new System.Drawing.Point(14, 74);
            this.clb_Tec.Name = "clb_Tec";
            this.clb_Tec.Size = new System.Drawing.Size(280, 79);
            this.clb_Tec.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tecnologias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // txb_Descricao
            // 
            this.txb_Descricao.Location = new System.Drawing.Point(329, 35);
            this.txb_Descricao.Name = "txb_Descricao";
            this.txb_Descricao.Size = new System.Drawing.Size(226, 118);
            this.txb_Descricao.TabIndex = 3;
            this.txb_Descricao.Text = "";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(14, 35);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(280, 20);
            this.txb_Nome.TabIndex = 2;
            // 
            // projetoBindingSource1
            // 
            this.projetoBindingSource1.DataMember = "projeto";
            this.projetoBindingSource1.DataSource = this.db_ColaboradoresDataSet;
            // 
            // db_ColaboradoresDataSet
            // 
            this.db_ColaboradoresDataSet.DataSetName = "db_ColaboradoresDataSet";
            this.db_ColaboradoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetoBindingSource
            // 
            this.projetoBindingSource.DataMember = "projeto";
            this.projetoBindingSource.DataSource = this.db_ColaboradoresDataSet;
            // 
            // projetoTableAdapter
            // 
            this.projetoTableAdapter.ClearBeforeFill = true;
            // 
            // ProjetoInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(742, 192);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjetoInserir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Projeto ";
            this.Load += new System.EventHandler(this.ProjetoInserir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ColaboradoresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txb_Descricao;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.CheckedListBox clb_Tec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_adicionarProjeto;
        private db_ColaboradoresDataSet db_ColaboradoresDataSet;
        private System.Windows.Forms.BindingSource projetoBindingSource;
        private db_ColaboradoresDataSetTableAdapters.projetoTableAdapter projetoTableAdapter;
        private System.Windows.Forms.BindingSource projetoBindingSource1;
    }
}