
namespace Gestão_de_Projetos
{
    partial class CustosAtuais
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Colaboradores");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Tecnologias");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Total");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustosAtuais));
            this.db_ColaboradoresDataSet = new Gestão_de_Projetos.db_ColaboradoresDataSet();
            this.projetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoTableAdapter = new Gestão_de_Projetos.db_ColaboradoresDataSetTableAdapters.projetoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.lv_Projetos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Tecnologias = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Colaborador = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Total = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_ColaboradoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insira o Nome do Projeto";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(12, 27);
            this.txb_Nome.MaxLength = 9;
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(326, 20);
            this.txb_Nome.TabIndex = 7;
            this.txb_Nome.Tag = "";
            this.txb_Nome.TextChanged += new System.EventHandler(this.txb_Nome_TextChanged);
            // 
            // lv_Projetos
            // 
            this.lv_Projetos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_Projetos.FullRowSelect = true;
            this.lv_Projetos.HideSelection = false;
            this.lv_Projetos.Location = new System.Drawing.Point(12, 64);
            this.lv_Projetos.Name = "lv_Projetos";
            this.lv_Projetos.Size = new System.Drawing.Size(705, 109);
            this.lv_Projetos.TabIndex = 6;
            this.lv_Projetos.UseCompatibleStateImageBehavior = false;
            this.lv_Projetos.View = System.Windows.Forms.View.Details;
            this.lv_Projetos.Click += new System.EventHandler(this.lv_Projetos_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome do Projeto";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 471;
            // 
            // lv_Tecnologias
            // 
            this.lv_Tecnologias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Tecnologias.FullRowSelect = true;
            this.lv_Tecnologias.HideSelection = false;
            this.lv_Tecnologias.Location = new System.Drawing.Point(390, 194);
            this.lv_Tecnologias.Name = "lv_Tecnologias";
            this.lv_Tecnologias.Size = new System.Drawing.Size(171, 104);
            this.lv_Tecnologias.TabIndex = 9;
            this.lv_Tecnologias.UseCompatibleStateImageBehavior = false;
            this.lv_Tecnologias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tecnologia";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Custo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 52;
            // 
            // lv_Colaborador
            // 
            this.lv_Colaborador.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader10});
            this.lv_Colaborador.FullRowSelect = true;
            this.lv_Colaborador.HideSelection = false;
            this.lv_Colaborador.Location = new System.Drawing.Point(12, 194);
            this.lv_Colaborador.Name = "lv_Colaborador";
            this.lv_Colaborador.Size = new System.Drawing.Size(367, 103);
            this.lv_Colaborador.TabIndex = 10;
            this.lv_Colaborador.UseCompatibleStateImageBehavior = false;
            this.lv_Colaborador.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Colaborador";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Valor Hora";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 64;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Horas/projeto";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 78;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Custo";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_Total
            // 
            this.lv_Total.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lv_Total.FullRowSelect = true;
            this.lv_Total.HideSelection = false;
            this.lv_Total.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_Total.Location = new System.Drawing.Point(574, 194);
            this.lv_Total.Name = "lv_Total";
            this.lv_Total.Size = new System.Drawing.Size(143, 104);
            this.lv_Total.TabIndex = 13;
            this.lv_Total.UseCompatibleStateImageBehavior = false;
            this.lv_Total.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Atributos";
            this.columnHeader8.Width = 77;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Valores";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Colaboradores associados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tecnologias associadas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Selecione um projeto:";
            // 
            // CustosAtuais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(729, 308);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_Total);
            this.Controls.Add(this.lv_Colaborador);
            this.Controls.Add(this.lv_Tecnologias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.lv_Projetos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustosAtuais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custos Atuais";
            ((System.ComponentModel.ISupportInitialize)(this.db_ColaboradoresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private db_ColaboradoresDataSet db_ColaboradoresDataSet;
        private System.Windows.Forms.BindingSource projetoBindingSource;
        private db_ColaboradoresDataSetTableAdapters.projetoTableAdapter projetoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.ListView lv_Projetos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lv_Tecnologias;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lv_Colaborador;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lv_Total;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}