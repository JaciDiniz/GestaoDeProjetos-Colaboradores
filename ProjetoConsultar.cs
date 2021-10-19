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
    public partial class ProjetoConsultar : Form
    {
        private IGestorProjetos gestor;
        public ProjetoConsultar()
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

        private void txb_Nome_TextChanged_1(object sender, EventArgs e)
        {
            CarregaProjetos(txb_Nome.Text);
        }
    }
}
