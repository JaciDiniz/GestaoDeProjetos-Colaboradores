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
    public partial class GestaoProjetos : Form
    {
        public GestaoProjetos()
        {
            InitializeComponent();
            
        }

        private void btn_VoltarMenuPrincipal_Click(object sender, EventArgs e)
        {
            GestorProjetos gestaoProjetos = new GestorProjetos();


            gestaoProjetos.StartPosition = FormStartPosition.CenterScreen;
            gestaoProjetos.Show();
            this.Hide();
        }

        private void btn_InserirProjeto_Click(object sender, EventArgs e)
        {
            ProjetoInserir inserir = new ProjetoInserir();
            inserir.Show();
        }

        private void btn_ConsultarProjeto_Click(object sender, EventArgs e)
        {
            ProjetoConsultar consultar = new ProjetoConsultar();
            consultar.Show();
        }

        private void btn_AlterarProjeto_Click(object sender, EventArgs e)
        {
            ProjetoAlterarLista alterar = new ProjetoAlterarLista();
            alterar.Show();
        }

        private void btn_EliminarProjeto_Click(object sender, EventArgs e)
        {
            ProjetoEliminar eliminar = new ProjetoEliminar();
            eliminar.Show();

        }

        private void btn_CustosAtuais_Click(object sender, EventArgs e)
        {
            CustosAtuais custosAtuais = new CustosAtuais();
            custosAtuais.Show();
        }
    }
}
