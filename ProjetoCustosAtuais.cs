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
    public partial class CustosAtuais : Form
    {

        private IGestorProjetos gestor;

        public CustosAtuais()
        {
            InitializeComponent();
            gestor = new GestorProjeto();
            CarregaProjetos(string.Empty);
        }

        public void CarregaProjetos(string projeto)

        {
            List<Projetos> pro = gestor.ProcuraProjetos(projeto);
            

            lv_Projetos.Items.Clear();

            foreach (Projetos c in pro)
            {
                ListViewItem item = new ListViewItem(c.Nome);
                item.SubItems.Add(c.DescricaoIntervencao);
                lv_Projetos.Items.Add(item);
            }

        }


        private void txb_Nome_TextChanged(object sender, EventArgs e)
        {
            CarregaProjetos(txb_Nome.Text);
        }

        private void lv_Projetos_Click(object sender, EventArgs e)
        {
            double custosprojeto = 0;
            double custoscolaborador = 0;
            List<Tecnologia> tecnologias = gestor.MostrarTecnologias(lv_Projetos.SelectedItems[0].SubItems[0].Text);
            List<Colaborador> colaboadores = gestor.MostrarColaborador(lv_Projetos.SelectedItems[0].SubItems[0].Text);


            lv_Tecnologias.Items.Clear();
            lv_Colaborador.Items.Clear();
   

            foreach (Tecnologia t in tecnologias)
            {
                ListViewItem item = new ListViewItem(t.Nome);
                item.SubItems.Add(t.Custo.ToString());
                lv_Tecnologias.Items.Add(item);

                custosprojeto += t.Custo;

            }

            foreach (Colaborador c in colaboadores)
            {
                double custo = c.Horas * c.ValorHora;
                ListViewItem item = new ListViewItem(c.Nome);
                item.SubItems.Add(c.ValorHora.ToString());
                item.SubItems.Add(c.Horas.ToString());
                item.SubItems.Add(custo.ToString());
                lv_Colaborador.Items.Add(item);

                custoscolaborador += custo;
            }

            double total = custoscolaborador + custosprojeto;

            if (lv_Total.Items[1].SubItems.Count == 1) {
                lv_Total.Items[0].SubItems.Add(custoscolaborador.ToString());
                lv_Total.Items[1].SubItems.Add(custosprojeto.ToString());
                lv_Total.Items[2].SubItems.Add(total.ToString());
            }
            else {
                lv_Total.Items[0].SubItems[1].Text = custoscolaborador.ToString();
                lv_Total.Items[1].SubItems[1].Text = custosprojeto.ToString();
                lv_Total.Items[2].SubItems[1].Text = total.ToString();
            }
        }

    
    }
}
