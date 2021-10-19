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
    public partial class ProjetoAlterarLista : Form
    {
        private IGestorProjetos gestor;
        public ProjetoAlterarLista()
        {
            InitializeComponent();
            gestor = new GestorProjeto();
            CarregaProjetos(string.Empty);
        }

        public void CarregaProjetos(string projeto)

        {
            List<Projetos> pro = gestor.ProcuraProjetos(projeto);


            lv_Consultar.Items.Clear();

            foreach (Projetos c in pro)
            {
                ListViewItem item = new ListViewItem(c.Nome);
                item.SubItems.Add(c.DescricaoIntervencao);
                lv_Consultar.Items.Add(item);
            }

        }


        private void txb_Nome_TextChanged(object sender, EventArgs e)
        {
           CarregaProjetos(txb_Nome.Text);
        }

        private void btn_EditarProjeto_Click(object sender, EventArgs e)
        {
            if (lv_Consultar.SelectedItems.Count == 0)
                MessageBox.Show("Selecione um Projeto", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);




            if (lv_Consultar.SelectedItems.Count != 0)
            {
                string nome = (lv_Consultar.SelectedItems[0].Text);

                ProjetoAlterar editar = new ProjetoAlterar(nome);
                editar.MdiParent = this.MdiParent;

                editar.StartPosition = FormStartPosition.CenterScreen;
                editar.Show();
            }
            else
            {
                MessageBox.Show("Selecione um colaborador", "Editar Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lv_Consultar_DoubleClick(object sender, EventArgs e)
        {
            if (lv_Consultar.SelectedItems.Count != 0)
            {
                string nome = (lv_Consultar.SelectedItems[0].Text);

                ProjetoAlterar editar = new ProjetoAlterar(nome);
                editar.MdiParent = this.MdiParent;

                editar.StartPosition = FormStartPosition.CenterScreen;
                editar.Show();
            }
            else
            {
                MessageBox.Show("Selecione um colaborador", "Editar Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
