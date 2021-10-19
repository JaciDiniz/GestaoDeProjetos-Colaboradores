
namespace Gestão_de_Projetos
{
    partial class AdicinarColaborador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Morada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clb_Habilitacao = new System.Windows.Forms.CheckedListBox();
            this.cmb_Tecnologias = new System.Windows.Forms.ComboBox();
            this.numup_ValorHora = new System.Windows.Forms.NumericUpDown();
            this.btn_AdicionarColaborador = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numup_ValorHora)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AdicionarColaborador);
            this.groupBox1.Controls.Add(this.numup_ValorHora);
            this.groupBox1.Controls.Add(this.cmb_Tecnologias);
            this.groupBox1.Controls.Add(this.clb_Habilitacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_Morada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_Nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(73, 19);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(100, 20);
            this.txb_Nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Morada";
            // 
            // txb_Morada
            // 
            this.txb_Morada.Location = new System.Drawing.Point(73, 45);
            this.txb_Morada.Name = "txb_Morada";
            this.txb_Morada.Size = new System.Drawing.Size(100, 20);
            this.txb_Morada.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nível de Habilitação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = " Tecnologias de domínio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor/Hora";
            // 
            // clb_Habilitacao
            // 
            this.clb_Habilitacao.FormattingEnabled = true;
            this.clb_Habilitacao.Location = new System.Drawing.Point(0, 98);
            this.clb_Habilitacao.Name = "clb_Habilitacao";
            this.clb_Habilitacao.Size = new System.Drawing.Size(120, 94);
            this.clb_Habilitacao.TabIndex = 10;
            // 
            // cmb_Tecnologias
            // 
            this.cmb_Tecnologias.FormattingEnabled = true;
            this.cmb_Tecnologias.Items.AddRange(new object[] {
            "Programador",
            "Gestor de Redes",
            "Operacional técnico"});
            this.cmb_Tecnologias.Location = new System.Drawing.Point(376, 51);
            this.cmb_Tecnologias.Name = "cmb_Tecnologias";
            this.cmb_Tecnologias.Size = new System.Drawing.Size(121, 21);
            this.cmb_Tecnologias.TabIndex = 11;
            // 
            // numup_ValorHora
            // 
            this.numup_ValorHora.Location = new System.Drawing.Point(367, 23);
            this.numup_ValorHora.Name = "numup_ValorHora";
            this.numup_ValorHora.Size = new System.Drawing.Size(120, 20);
            this.numup_ValorHora.TabIndex = 12;
            // 
            // btn_AdicionarColaborador
            // 
            this.btn_AdicionarColaborador.Location = new System.Drawing.Point(353, 120);
            this.btn_AdicionarColaborador.Name = "btn_AdicionarColaborador";
            this.btn_AdicionarColaborador.Size = new System.Drawing.Size(144, 26);
            this.btn_AdicionarColaborador.TabIndex = 13;
            this.btn_AdicionarColaborador.Text = "Adicionar Colaborador";
            this.btn_AdicionarColaborador.UseVisualStyleBackColor = true;
            // 
            // AdicinarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdicinarColaborador";
            this.Text = "AdicinarColaborador";
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
        private System.Windows.Forms.CheckedListBox clb_Habilitacao;
    }
}