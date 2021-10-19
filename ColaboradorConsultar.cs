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
    public partial class ColaboradorConsultar : Form
    {
        private IGestorProjetos gestor;

        public ColaboradorConsultar()
        {
            InitializeComponent();
            gestor = new GestorProjeto();
            CarregaColaborador(string.Empty);
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            CarregaColaborador(txb_Nif.Text);
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

        private void txb_Nif_TextChanged(object sender, EventArgs e)
        {
            CarregaColaborador(txb_Nif.Text);
        }
    }
}
