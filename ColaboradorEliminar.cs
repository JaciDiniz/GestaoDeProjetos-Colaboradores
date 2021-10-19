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
    public partial class ColaboradorEliminar : Form
    {
        IGestorProjetos gestor;


        public ColaboradorEliminar()
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
                ListViewItem item = new ListViewItem(c.Nome);
                item.SubItems.Add(c.Nif.ToString());
                item.SubItems.Add(c.Morada);
                item.SubItems.Add(c.ValorHora.ToString());
                item.SubItems.Add(c.Habilitacao);
                item.SubItems.Add(c.TecnologiasDeDominio);
                lv_Consultar.Items.Add(item);
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lv_Consultar.SelectedItems.Count != 0)
            {
                string nome = lv_Consultar.SelectedItems[0].Text;
                DialogResult confirm = MessageBox.Show("Tem certeza que você eliminar " + nome + " ?", "Eliminar Colaborador", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {

                    string nif = lv_Consultar.SelectedItems[0].SubItems[1].Text;


                    bool resultado = gestor.EliminaColaborador(Convert.ToInt32(nif));
                    if (resultado)
                    {
                        CarregaColaborador(string.Empty);
                        MessageBox.Show(nome + " removido com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Erro ao Remover Colaborador. ");
                }
            }
            else
            {
                MessageBox.Show("Selecione um Colaborador. ", "Eliminar Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lv_Consultar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lv_Consultar.SelectedItems.Count != 0)
            {
                string nome = lv_Consultar.SelectedItems[0].Text;
                DialogResult confirm = MessageBox.Show("Tem certeza que você eliminar " + nome + " ?", "Eliminar Colaborador", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    string nif = lv_Consultar.SelectedItems[0].SubItems[1].Text;


                    bool resultado = gestor.EliminaColaborador(Convert.ToInt32(nif));
                    if (resultado)
                    {
                        CarregaColaborador(string.Empty);
                        MessageBox.Show(nome + " removido com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Erro ao Remover Colaborador. ");
                }

            }
        }

        private void txb_Nif_TextChanged_1(object sender, EventArgs e)
        {
            CarregaColaborador(txb_Nif.Text);
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {

            if (lv_Consultar.SelectedItems.Count == 0)
                MessageBox.Show("Selecione um Colaborador", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (lv_Consultar.SelectedItems.Count != 0)
            {
                string nome = lv_Consultar.SelectedItems[0].Text;
                DialogResult confirm = MessageBox.Show("Tem certeza que você eliminar " + nome + " ?", "Eliminar Colaborador", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    string nif = lv_Consultar.SelectedItems[0].SubItems[1].Text;


                    bool resultado = gestor.EliminaColaborador(Convert.ToInt32(nif));
                    if (resultado)
                    {
                        CarregaColaborador(string.Empty);
                        MessageBox.Show(nome + " removido com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Erro ao Remover Colaborador. ", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
