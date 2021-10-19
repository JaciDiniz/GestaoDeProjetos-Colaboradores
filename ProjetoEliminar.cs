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
    public partial class ProjetoEliminar : Form
    {
        IGestorProjetos gestor;
        public ProjetoEliminar()
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

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (lv_Consultar.SelectedItems.Count == 0)
                MessageBox.Show("Selecione um projeto", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);


            if (lv_Consultar.SelectedItems.Count != 0)
            {
                string nome = lv_Consultar.SelectedItems[0].Text;
                DialogResult confirm = MessageBox.Show("Tem certeza que você eliminar " + nome + " ?", "Eliminar Projeto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    bool resultado = gestor.EliminaProjeto(nome);
                    if (resultado)
                    {
                        CarregaProjetos(string.Empty);
                        MessageBox.Show(nome + " removido com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Erro ao Remover Projeto. ");
                }
            }
            else
            {
                MessageBox.Show("Selecione um Projeto. ", "Eliminar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txb_Nome_TextChanged_1(object sender, EventArgs e)
        {
            CarregaProjetos(txb_Nome.Text);

        }

        private void lv_Consultar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lv_Consultar.SelectedItems.Count != 0)
            {
                string nome = lv_Consultar.SelectedItems[0].Text;
                DialogResult confirm = MessageBox.Show("Tem certeza que você eliminar " + nome + " ?", "Eliminar Projeto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    bool resultado = gestor.EliminaProjeto(nome);
                    if (resultado)
                    {
                        CarregaProjetos(string.Empty);
                        MessageBox.Show(nome + " removido com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Erro ao Remover Projeto. ");
                }
            }
            else
            {
                MessageBox.Show("Selecione um Projeto. ", "Eliminar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
