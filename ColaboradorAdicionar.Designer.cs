
namespace Gestão_de_Projetos
{
    partial class ColaboradorAdicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColaboradorAdicionar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.ckl_tecnologia = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AdicionarColaborador = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clb_Habilitacao = new System.Windows.Forms.ComboBox();
            this.txb_Nif = new System.Windows.Forms.TextBox();
            this.numup_ValorHora = new System.Windows.Forms.NumericUpDown();
            this.cmb_Tecnologias = new System.Windows.Forms.ComboBox();
            this.txb_Morada = new System.Windows.Forms.TextBox();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numup_ValorHora)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ckl_tecnologia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_AdicionarColaborador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clb_Habilitacao);
            this.groupBox1.Controls.Add(this.txb_Nif);
            this.groupBox1.Controls.Add(this.numup_ValorHora);
            this.groupBox1.Controls.Add(this.cmb_Tecnologias);
            this.groupBox1.Controls.Add(this.txb_Morada);
            this.groupBox1.Controls.Add(this.txb_Nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Colaborador";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkLabel1.Location = new System.Drawing.Point(176, 179);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(281, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clique aqui para adicionar uma nova tecnologia,";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tecnologias";
            // 
            // ckl_tecnologia
            // 
            this.ckl_tecnologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckl_tecnologia.FormattingEnabled = true;
            this.ckl_tecnologia.Location = new System.Drawing.Point(161, 198);
            this.ckl_tecnologia.Name = "ckl_tecnologia";
            this.ckl_tecnologia.Size = new System.Drawing.Size(327, 84);
            this.ckl_tecnologia.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "NIF";
            // 
            // btn_AdicionarColaborador
            // 
            this.btn_AdicionarColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdicionarColaborador.Location = new System.Drawing.Point(178, 288);
            this.btn_AdicionarColaborador.Name = "btn_AdicionarColaborador";
            this.btn_AdicionarColaborador.Size = new System.Drawing.Size(144, 26);
            this.btn_AdicionarColaborador.TabIndex = 6;
            this.btn_AdicionarColaborador.Text = "Adicionar Colaborador";
            this.btn_AdicionarColaborador.UseVisualStyleBackColor = true;
            this.btn_AdicionarColaborador.Click += new System.EventHandler(this.btn_AdicionarColaborador_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Competência de domínio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor/Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nível de Habilitação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Morada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // clb_Habilitacao
            // 
            this.clb_Habilitacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clb_Habilitacao.DropDownWidth = 167;
            this.clb_Habilitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Habilitacao.FormattingEnabled = true;
            this.clb_Habilitacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clb_Habilitacao.Items.AddRange(new object[] {
            "11.º ANO",
            "12.º ANO (ensino secundário)",
            "9.º ANO (3.º ciclo do ensino básico)",
            "BACHARELATO",
            "CURSO TECNOLÓGICO/PROFISSIONAL/OUTROS",
            "LICENCIATURA",
            "MESTRADO",
            "PÓS-GRADUAÇÃO"});
            this.clb_Habilitacao.Location = new System.Drawing.Point(161, 125);
            this.clb_Habilitacao.Name = "clb_Habilitacao";
            this.clb_Habilitacao.Size = new System.Drawing.Size(327, 23);
            this.clb_Habilitacao.TabIndex = 4;
            // 
            // txb_Nif
            // 
            this.txb_Nif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Nif.Location = new System.Drawing.Point(161, 73);
            this.txb_Nif.MaxLength = 9;
            this.txb_Nif.Name = "txb_Nif";
            this.txb_Nif.Size = new System.Drawing.Size(132, 21);
            this.txb_Nif.TabIndex = 2;
            // 
            // numup_ValorHora
            // 
            this.numup_ValorHora.DecimalPlaces = 2;
            this.numup_ValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numup_ValorHora.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numup_ValorHora.Location = new System.Drawing.Point(161, 98);
            this.numup_ValorHora.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numup_ValorHora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numup_ValorHora.Name = "numup_ValorHora";
            this.numup_ValorHora.Size = new System.Drawing.Size(131, 21);
            this.numup_ValorHora.TabIndex = 3;
            this.numup_ValorHora.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmb_Tecnologias
            // 
            this.cmb_Tecnologias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tecnologias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Tecnologias.FormattingEnabled = true;
            this.cmb_Tecnologias.Items.AddRange(new object[] {
            "Programador",
            "Gestor de Redes",
            "Operacional técnico"});
            this.cmb_Tecnologias.Location = new System.Drawing.Point(161, 152);
            this.cmb_Tecnologias.Name = "cmb_Tecnologias";
            this.cmb_Tecnologias.Size = new System.Drawing.Size(328, 23);
            this.cmb_Tecnologias.TabIndex = 5;
            this.cmb_Tecnologias.SelectedIndexChanged += new System.EventHandler(this.cmb_Tecnologias_SelectedIndexChanged);
            // 
            // txb_Morada
            // 
            this.txb_Morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Morada.Location = new System.Drawing.Point(161, 47);
            this.txb_Morada.Name = "txb_Morada";
            this.txb_Morada.Size = new System.Drawing.Size(328, 21);
            this.txb_Morada.TabIndex = 1;
            // 
            // txb_Nome
            // 
            this.txb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Nome.Location = new System.Drawing.Point(161, 21);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(328, 21);
            this.txb_Nome.TabIndex = 0;
            // 
            // ColaboradorAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(529, 365);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColaboradorAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Colaborador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numup_ValorHora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Morada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.Button btn_AdicionarColaborador;
        private System.Windows.Forms.NumericUpDown numup_ValorHora;
        private System.Windows.Forms.ComboBox cmb_Tecnologias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Nif;
        private System.Windows.Forms.ComboBox clb_Habilitacao;
        private System.Windows.Forms.CheckedListBox ckl_tecnologia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}