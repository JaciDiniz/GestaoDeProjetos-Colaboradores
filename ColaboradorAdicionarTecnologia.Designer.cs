
namespace Gestão_de_Projetos
{
    partial class ColaboradorAdicionarTecnologia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColaboradorAdicionarTecnologia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.numup_ValorTec = new System.Windows.Forms.NumericUpDown();
            this.cmb_Tecnologias = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AdicionarTecnologia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numup_ValorTec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Competência";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Custo";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(127, 27);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(173, 20);
            this.txt_Nome.TabIndex = 0;
            // 
            // numup_ValorTec
            // 
            this.numup_ValorTec.DecimalPlaces = 2;
            this.numup_ValorTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numup_ValorTec.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numup_ValorTec.Location = new System.Drawing.Point(127, 82);
            this.numup_ValorTec.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numup_ValorTec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numup_ValorTec.Name = "numup_ValorTec";
            this.numup_ValorTec.Size = new System.Drawing.Size(173, 21);
            this.numup_ValorTec.TabIndex = 2;
            this.numup_ValorTec.Value = new decimal(new int[] {
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
            this.cmb_Tecnologias.Location = new System.Drawing.Point(127, 53);
            this.cmb_Tecnologias.Name = "cmb_Tecnologias";
            this.cmb_Tecnologias.Size = new System.Drawing.Size(173, 23);
            this.cmb_Tecnologias.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AdicionarTecnologia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numup_ValorTec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_Tecnologias);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 149);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Nova Tecnologia";
            // 
            // btn_AdicionarTecnologia
            // 
            this.btn_AdicionarTecnologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdicionarTecnologia.Location = new System.Drawing.Point(130, 118);
            this.btn_AdicionarTecnologia.Name = "btn_AdicionarTecnologia";
            this.btn_AdicionarTecnologia.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarTecnologia.TabIndex = 3;
            this.btn_AdicionarTecnologia.Text = "Adicionar";
            this.btn_AdicionarTecnologia.UseVisualStyleBackColor = true;
            this.btn_AdicionarTecnologia.Click += new System.EventHandler(this.btn_AdicionarTecnologia_Click);
            // 
            // ColaboradorAdicionarTecnologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(367, 177);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColaboradorAdicionarTecnologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Tecnologia";
            ((System.ComponentModel.ISupportInitialize)(this.numup_ValorTec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.NumericUpDown numup_ValorTec;
        private System.Windows.Forms.ComboBox cmb_Tecnologias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AdicionarTecnologia;
    }
}