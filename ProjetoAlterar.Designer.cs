
namespace Gestão_de_Projetos
{
    partial class ProjetoAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjetoAlterar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_adicionarProjeto = new System.Windows.Forms.Button();
            this.clb_Tec = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Descricao = new System.Windows.Forms.RichTextBox();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_Removerprojeto = new System.Windows.Forms.TextBox();
            this.btn_RemoverColaborador = new System.Windows.Forms.Button();
            this.cmb_RemoverColaboradores = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_AdicionarProjeto = new System.Windows.Forms.TextBox();
            this.cmb_AdicionarColaboradores = new System.Windows.Forms.ComboBox();
            this.btn_AdicionarColaborador = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_HorasColaborador = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HorasColaborador)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Projeto";
            // 
            // btn_adicionarProjeto
            // 
            this.btn_adicionarProjeto.Location = new System.Drawing.Point(573, 59);
            this.btn_adicionarProjeto.Name = "btn_adicionarProjeto";
            this.btn_adicionarProjeto.Size = new System.Drawing.Size(102, 29);
            this.btn_adicionarProjeto.TabIndex = 3;
            this.btn_adicionarProjeto.Text = "Editar Projeto";
            this.btn_adicionarProjeto.UseVisualStyleBackColor = true;
            this.btn_adicionarProjeto.Click += new System.EventHandler(this.btn_adicionarProjeto_Click);
            // 
            // clb_Tec
            // 
            this.clb_Tec.FormattingEnabled = true;
            this.clb_Tec.Location = new System.Drawing.Point(6, 71);
            this.clb_Tec.Name = "clb_Tec";
            this.clb_Tec.Size = new System.Drawing.Size(280, 79);
            this.clb_Tec.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tecnologias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // txb_Descricao
            // 
            this.txb_Descricao.Location = new System.Drawing.Point(316, 36);
            this.txb_Descricao.Name = "txb_Descricao";
            this.txb_Descricao.Size = new System.Drawing.Size(238, 114);
            this.txb_Descricao.TabIndex = 1;
            this.txb_Descricao.Text = "";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(6, 36);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(280, 20);
            this.txb_Nome.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_Removerprojeto);
            this.groupBox2.Controls.Add(this.btn_RemoverColaborador);
            this.groupBox2.Controls.Add(this.cmb_RemoverColaboradores);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remover Colaboradores ao Projeto";
            // 
            // cmb_Removerprojeto
            // 
            this.cmb_Removerprojeto.Location = new System.Drawing.Point(6, 35);
            this.cmb_Removerprojeto.Name = "cmb_Removerprojeto";
            this.cmb_Removerprojeto.ReadOnly = true;
            this.cmb_Removerprojeto.Size = new System.Drawing.Size(201, 20);
            this.cmb_Removerprojeto.TabIndex = 9;
            this.cmb_Removerprojeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_RemoverColaborador
            // 
            this.btn_RemoverColaborador.Location = new System.Drawing.Point(573, 34);
            this.btn_RemoverColaborador.Name = "btn_RemoverColaborador";
            this.btn_RemoverColaborador.Size = new System.Drawing.Size(102, 21);
            this.btn_RemoverColaborador.TabIndex = 8;
            this.btn_RemoverColaborador.Text = "Remover Colaborador";
            this.btn_RemoverColaborador.UseVisualStyleBackColor = true;
            this.btn_RemoverColaborador.Click += new System.EventHandler(this.btn_RemoverColaborador_Click);
            // 
            // cmb_RemoverColaboradores
            // 
            this.cmb_RemoverColaboradores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RemoverColaboradores.FormattingEnabled = true;
            this.cmb_RemoverColaboradores.Location = new System.Drawing.Point(261, 34);
            this.cmb_RemoverColaboradores.Name = "cmb_RemoverColaboradores";
            this.cmb_RemoverColaboradores.Size = new System.Drawing.Size(167, 21);
            this.cmb_RemoverColaboradores.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Colaborador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Projeto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_AdicionarProjeto);
            this.groupBox3.Controls.Add(this.cmb_AdicionarColaboradores);
            this.groupBox3.Controls.Add(this.btn_AdicionarColaborador);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nud_HorasColaborador);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(698, 86);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adicionar Colaboradores ao Projeto";
            // 
            // cmb_AdicionarProjeto
            // 
            this.cmb_AdicionarProjeto.Location = new System.Drawing.Point(6, 41);
            this.cmb_AdicionarProjeto.Name = "cmb_AdicionarProjeto";
            this.cmb_AdicionarProjeto.ReadOnly = true;
            this.cmb_AdicionarProjeto.Size = new System.Drawing.Size(201, 20);
            this.cmb_AdicionarProjeto.TabIndex = 15;
            this.cmb_AdicionarProjeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_AdicionarColaboradores
            // 
            this.cmb_AdicionarColaboradores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AdicionarColaboradores.FormattingEnabled = true;
            this.cmb_AdicionarColaboradores.ItemHeight = 13;
            this.cmb_AdicionarColaboradores.Location = new System.Drawing.Point(261, 40);
            this.cmb_AdicionarColaboradores.Name = "cmb_AdicionarColaboradores";
            this.cmb_AdicionarColaboradores.Size = new System.Drawing.Size(167, 21);
            this.cmb_AdicionarColaboradores.TabIndex = 14;
            // 
            // btn_AdicionarColaborador
            // 
            this.btn_AdicionarColaborador.Location = new System.Drawing.Point(573, 40);
            this.btn_AdicionarColaborador.Name = "btn_AdicionarColaborador";
            this.btn_AdicionarColaborador.Size = new System.Drawing.Size(102, 21);
            this.btn_AdicionarColaborador.TabIndex = 6;
            this.btn_AdicionarColaborador.Text = "Adicionar Colaborador";
            this.btn_AdicionarColaborador.UseVisualStyleBackColor = true;
            this.btn_AdicionarColaborador.Click += new System.EventHandler(this.btn_AdicionarColaborador_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = " Nº de horas ";
            // 
            // nud_HorasColaborador
            // 
            this.nud_HorasColaborador.Location = new System.Drawing.Point(456, 41);
            this.nud_HorasColaborador.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nud_HorasColaborador.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_HorasColaborador.Name = "nud_HorasColaborador";
            this.nud_HorasColaborador.Size = new System.Drawing.Size(98, 20);
            this.nud_HorasColaborador.TabIndex = 5;
            this.nud_HorasColaborador.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Colaborador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Projeto";
            // 
            // ProjetoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(724, 384);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjetoAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Projeto";
            this.Load += new System.EventHandler(this.ProjetoAlterar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HorasColaborador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_adicionarProjeto;
        private System.Windows.Forms.CheckedListBox clb_Tec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txb_Descricao;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_RemoverColaborador;
        private System.Windows.Forms.ComboBox cmb_RemoverColaboradores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cmb_Removerprojeto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_AdicionarColaboradores;
        private System.Windows.Forms.Button btn_AdicionarColaborador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_HorasColaborador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cmb_AdicionarProjeto;
    }
}