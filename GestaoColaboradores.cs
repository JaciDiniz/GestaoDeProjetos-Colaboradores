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
    public partial class GestaoColaboradores : Form
    {
        public GestaoColaboradores()
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

        private void btn_InserirColaborador_Click(object sender, EventArgs e)
        {
            ColaboradorAdicionar adicinar = new ColaboradorAdicionar();
            adicinar.StartPosition = FormStartPosition.CenterScreen;
            adicinar.Show();

        }

        private void btn_AlterarColaborador_Click(object sender, EventArgs e)
        {
            ColaboradorEditarLista editar = new ColaboradorEditarLista();
            editar.StartPosition = FormStartPosition.CenterScreen;
            editar.Show();
        }

        private void btn_ConsultarColaborador_Click(object sender, EventArgs e)
        {
            ColaboradorConsultar consultar = new ColaboradorConsultar();
            consultar.StartPosition = FormStartPosition.CenterScreen;
            consultar.Show();

        }

        private void btn_ListarColaboradores_Click(object sender, EventArgs e)
        {
            ColaboradorListar listar = new ColaboradorListar();
            listar.StartPosition = FormStartPosition.CenterScreen;
            listar.Show();
        }

        private void btn_EliminarColaborador_Click(object sender, EventArgs e)
        {
            ColaboradorEliminar eliminar = new ColaboradorEliminar();
            eliminar.StartPosition = FormStartPosition.CenterScreen;
            eliminar.Show();
        }
    }
}
