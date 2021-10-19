
namespace Gestão_de_Projetos
{
    partial class ProjetoEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjetoEliminar));
            this.lv_Consultar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_Consultar
            // 
            this.lv_Consultar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_Consultar.FullRowSelect = true;
            this.lv_Consultar.HideSelection = false;
            this.lv_Consultar.Location = new System.Drawing.Point(12, 63);
            this.lv_Consultar.Name = "lv_Consultar";
            this.lv_Consultar.Size = new System.Drawing.Size(578, 209);
            this.lv_Consultar.TabIndex = 6;
            this.lv_Consultar.UseCompatibleStateImageBehavior = false;
            this.lv_Consultar.View = System.Windows.Forms.View.Details;
            this.lv_Consultar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_Consultar_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome do Projeto";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 450;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(201, 23);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 10;
            this.btn_Eliminar.Text = "Apagar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Insira o Nome do Projeto";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(12, 25);
            this.txb_Nome.MaxLength = 9;
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(183, 20);
            this.txb_Nome.TabIndex = 9;
            this.txb_Nome.Tag = "";
            this.txb_Nome.TextChanged += new System.EventHandler(this.txb_Nome_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Selecione um projeto:";
            // 
            // ProjetoEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(607, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.lv_Consultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjetoEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Projeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lv_Consultar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.Label label5;
    }
}