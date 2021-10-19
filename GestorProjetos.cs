using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Projetos
{
    public partial class GestorProjetos : Form
    {            

        public GestorProjetos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btn_GestaoColaboradores_Click(object sender, EventArgs e)
        {
            GestaoColaboradores gestorcolaborador = new GestaoColaboradores();
           

            gestorcolaborador.StartPosition = FormStartPosition.CenterScreen;
            
            gestorcolaborador.Show();
            this.Hide();
        }

        private void btn_GestaoProjetos_Click(object sender, EventArgs e)
        {
            GestaoProjetos gestaoProjetos = new GestaoProjetos();
            

            gestaoProjetos.StartPosition = FormStartPosition.CenterScreen;
            gestaoProjetos.Show();
            this.Hide();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://jacidiniz89.000webhostapp.com/");

        }
    }
}
