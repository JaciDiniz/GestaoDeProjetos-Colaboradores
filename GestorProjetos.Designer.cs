
namespace Gestão_de_Projetos
{
    partial class GestorProjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorProjetos));
            this.gpb_MenuPrincipal = new System.Windows.Forms.GroupBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_GestaoColaboradores = new System.Windows.Forms.Button();
            this.btn_GestaoProjetos = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_MenuPrincipal
            // 
            this.gpb_MenuPrincipal.Controls.Add(this.btn_Sair);
            this.gpb_MenuPrincipal.Controls.Add(this.btn_GestaoColaboradores);
            this.gpb_MenuPrincipal.Controls.Add(this.btn_GestaoProjetos);
            this.gpb_MenuPrincipal.Font = new System.Drawing.Font("Lucida Sans", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World);
            this.gpb_MenuPrincipal.ForeColor = System.Drawing.Color.Black;
            this.gpb_MenuPrincipal.Location = new System.Drawing.Point(17, 12);
            this.gpb_MenuPrincipal.Name = "gpb_MenuPrincipal";
            this.gpb_MenuPrincipal.Size = new System.Drawing.Size(288, 317);
            this.gpb_MenuPrincipal.TabIndex = 0;
            this.gpb_MenuPrincipal.TabStop = false;
            this.gpb_MenuPrincipal.Text = "Menu Principal";
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Sair.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.btn_Sair.Location = new System.Drawing.Point(45, 233);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(198, 43);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_GestaoColaboradores
            // 
            this.btn_GestaoColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_GestaoColaboradores.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.btn_GestaoColaboradores.Location = new System.Drawing.Point(45, 40);
            this.btn_GestaoColaboradores.Name = "btn_GestaoColaboradores";
            this.btn_GestaoColaboradores.Size = new System.Drawing.Size(198, 53);
            this.btn_GestaoColaboradores.TabIndex = 0;
            this.btn_GestaoColaboradores.Text = "Gestão de Colaboradores";
            this.btn_GestaoColaboradores.UseVisualStyleBackColor = true;
            this.btn_GestaoColaboradores.Click += new System.EventHandler(this.btn_GestaoColaboradores_Click);
            // 
            // btn_GestaoProjetos
            // 
            this.btn_GestaoProjetos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_GestaoProjetos.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.btn_GestaoProjetos.Location = new System.Drawing.Point(45, 111);
            this.btn_GestaoProjetos.Name = "btn_GestaoProjetos";
            this.btn_GestaoProjetos.Size = new System.Drawing.Size(198, 55);
            this.btn_GestaoProjetos.TabIndex = 1;
            this.btn_GestaoProjetos.Text = "Gestão de Projetos";
            this.btn_GestaoProjetos.UseVisualStyleBackColor = true;
            this.btn_GestaoProjetos.Click += new System.EventHandler(this.btn_GestaoProjetos_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(104, 334);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Jaci Diniz";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copyright © 2021 , Jaci Diniz - Todos os direitos reservados.";
            // 
            // GestorProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(323, 357);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpb_MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestorProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão da Empresa";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.gpb_MenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_MenuPrincipal;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_GestaoColaboradores;
        private System.Windows.Forms.Button btn_GestaoProjetos;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

