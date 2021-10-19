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
    public partial class ProjetoInserir : Form
    {
        IGestorProjetos gestor;
        
        public ProjetoInserir()
        {
            InitializeComponent();
            gestor = new GestorProjeto();

          
        }

        private void btn_adicionarProjeto_Click(object sender, EventArgs e)
        {
            if (txb_Nome.Text == "" || txb_Descricao.Text == "" || clb_Tec.SelectedIndex == 0)
                MessageBox.Show("Preencha todos os campos!");



            else
            {
                int num5 = clb_Tec.CheckedItems.Count;
                int[] numid = new int[num5];

                for (int i = 0; i < num5; i++)
                {
                    int num1 = gestor.ProcuraIdTecnologia(clb_Tec.CheckedItems[i].ToString());
                    if (num1 > 0)
                        numid[i] = num1;
                }


                Projetos projeto = new Projetos(txb_Nome.Text, txb_Descricao.Text);

                bool resultado = gestor.InsereProjeto(projeto, numid);
                if (resultado)
                    MessageBox.Show("Projeto: " + txb_Nome.Text + " adicionado(a) com sucesso.");
                else
                    MessageBox.Show("Erro ao adicionar o Projeto. ");

            }
        }

        private void ProjetoInserir_Load(object sender, EventArgs e)
        {
            List<Tecnologia> tec = gestor.ProcuraTecnologia(string.Empty);
            clb_Tec.Items.Clear();

            foreach (Tecnologia t in tec)
            {
                clb_Tec.Items.Add(t.Nome);

            }
        }
    }
}