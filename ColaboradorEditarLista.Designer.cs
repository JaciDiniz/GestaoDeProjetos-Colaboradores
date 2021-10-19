
namespace Gestão_de_Projetos
{
    partial class ColaboradorEditarLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColaboradorEditarLista));
            this.lv_Consultar = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Consultar = new System.Windows.Forms.TextBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_Consultar
            // 
            this.lv_Consultar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_Consultar.FullRowSelect = true;
            this.lv_Consultar.GridLines = true;
            this.lv_Consultar.HideSelection = false;
            this.lv_Consultar.Location = new System.Drawing.Point(12, 68);
            this.lv_Consultar.Name = "lv_Consultar";
            this.lv_Consultar.Size = new System.Drawing.Size(776, 237);
            this.lv_Consultar.TabIndex = 2;
            this.lv_Consultar.UseCompatibleStateImageBehavior = false;
            this.lv_Consultar.View = System.Windows.Forms.View.Details;
            this.lv_Consultar.SelectedIndexChanged += new System.EventHandler(this.lv_Consultar_SelectedIndexChanged);
            this.lv_Consultar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_Consultar_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NIF";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOME";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MORADA";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "VALOR HORA";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "HABILITAÇÃO";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 127;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TECNOLIGIA";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 221;
            // 
            // txt_Consultar
            // 
            this.txt_Consultar.Location = new System.Drawing.Point(12, 27);
            this.txt_Consultar.Name = "txt_Consultar";
            this.txt_Consultar.Size = new System.Drawing.Size(224, 20);
            this.txt_Consultar.TabIndex = 6;
            this.txt_Consultar.TextChanged += new System.EventHandler(this.txt_Consultar_TextChanged_1);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(242, 24);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insira um Nome, NIF ou Tecnologia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selecione um Colaborador:";
            // 
            // ColaboradorEditarLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Consultar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.lv_Consultar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColaboradorEditarLista";
            this.Text = "Lista Editar Colaborador";
            this.Activated += new System.EventHandler(this.ColaboradorEditarLista_Activated);
            this.Load += new System.EventHandler(this.ColaboradorEditarLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Consultar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txt_Consultar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}