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
    public partial class ColaboradorEditarLista : Form
    {
        private IGestorProjetos gestor;

        public ColaboradorEditarLista()
        {
            InitializeComponent();
            gestor = new GestorProjeto();
            CarregaColaborador(string.Empty);
        }

      
        public void CarregaColaborador(string nif)
        {
            List<Colaborador> colaboradores = gestor.ProcuraColaboradores(nif);

            lv_Consultar.Items.Clear();

            foreach (Colaborador c in colaboradores)
            {
                ListViewItem item = new ListViewItem(c.Nif.ToString());
                item.SubItems.Add(c.Nome);
                item.SubItems.Add(c.Morada);
                item.SubItems.Add(c.ValorHora.ToString());
                item.SubItems.Add(c.Habilitacao);
                item.SubItems.Add(c.TecnologiasDeDominio);
                lv_Consultar.Items.Add(item);
            }

        }

        private void lv_Consultar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string nif = lv_Consultar.SelectedItems[0].Text;
            

            ColaboradorEditar editar = new ColaboradorEditar(nif);
            editar.MdiParent = this.MdiParent;

            editar.StartPosition = FormStartPosition.CenterScreen;
            editar.Show();

        }

        private void ColaboradorEditarLista_Load(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
        }

        private void lv_Consultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Editar.Enabled = true;

        }

        private void ColaboradorEditarLista_Activated(object sender, EventArgs e)
        {
            CarregaColaborador(string.Empty);

        }

        private void btn_Editar_Click_1(object sender, EventArgs e)
        {
            if (lv_Consultar.SelectedItems.Count == 0)
                MessageBox.Show("Selecione um Colaborador", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (lv_Consultar.SelectedItems.Count != 0)
            {
                string nif = (lv_Consultar.SelectedItems[0].Text);

                ColaboradorEditar editar = new ColaboradorEditar(nif);
                editar.MdiParent = this.MdiParent;

                editar.StartPosition = FormStartPosition.CenterScreen;
                editar.Show();
            }
            else
            {
                MessageBox.Show("Selecione um colaborador", "Editar Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txt_Consultar_TextChanged_1(object sender, EventArgs e)
        {
            CarregaColaborador(txt_Consultar.Text);
        }
    }
}
