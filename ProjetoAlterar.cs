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
    public partial class ProjetoAlterar : Form
    {
        IGestorProjetos gestor;
        string nome;
        string antigonome;
        public ProjetoAlterar(string nome)
        {
            InitializeComponent();
            gestor = new GestorProjeto();
            this.nome = nome;
            antigonome = nome;

            List<Projetos> projeto = gestor.ProcuraProjetos(nome);

            foreach(Projetos p in projeto)
            {
                txb_Nome.Text = p.Nome;
                txb_Descricao.Text = p.DescricaoIntervencao;
                cmb_Removerprojeto.Text = p.Nome;
                cmb_AdicionarProjeto.Text = p.Nome;
            }
            
        }

        private void btn_adicionarProjeto_Click(object sender, EventArgs e)
        {
            if (txb_Nome.Text == "" || txb_Descricao.Text == "" || clb_Tec.Items.Count < 1)
                MessageBox.Show("Preencha todos os campos!", " .:Mensagem:. ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                bool resultado = gestor.AlterarProjeto(projeto, antigonome,numid) ;
                 if (resultado)
                     MessageBox.Show("Projeto: " + txb_Nome.Text + " Alterado com sucesso.", " .:Mensagem:. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 else
                     MessageBox.Show("Erro ao alterar o projeto " + txb_Nome.Text, " .:Mensagem:. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


           
            }
        }

    

        private void ProjetoAlterar_Load(object sender, EventArgs e)
        {
            List<Tecnologia> tec = gestor.ProcuraTecnologia(string.Empty);
            clb_Tec.Items.Clear();

            foreach (Tecnologia t in tec)
            {
                clb_Tec.Items.Add(t.Nome);

            }

            List<Colaborador> col = gestor.VerificarColabaroradorProjetoExcluir(cmb_Removerprojeto.Text);
            cmb_RemoverColaboradores.Items.Clear();

            foreach (Colaborador c in col)
            {
                cmb_RemoverColaboradores.Items.Add(c.Nome);

            }

            List<Colaborador> cola = gestor.VerificarColabaroradorProjeto(cmb_AdicionarProjeto.Text);
            cmb_AdicionarColaboradores.Items.Clear();

            foreach (Colaborador c in cola)
            {
                cmb_AdicionarColaboradores.Items.Add(c.Nome);

            }


        }

    

        private void btn_RemoverColaborador_Click(object sender, EventArgs e)
        {
            bool resultado = gestor.EliminaColaboradorProjeto(cmb_Removerprojeto.Text, gestor.ProcuraColaboradorNome(cmb_RemoverColaboradores.Text));

            if (resultado)
                MessageBox.Show(cmb_RemoverColaboradores.Text + " foi removido do Projeto " + cmb_Removerprojeto.Text + " com sucesso.", " .:Mensagem:. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao remover  " + cmb_RemoverColaboradores.Text + " do projeto " + cmb_Removerprojeto.Text, " .:Mensagem:. ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<Colaborador> col = gestor.VerificarColabaroradorProjetoExcluir(cmb_Removerprojeto.Text);
            cmb_RemoverColaboradores.Items.Clear();

            foreach (Colaborador c in col)
            {
                cmb_RemoverColaboradores.Items.Add(c.Nome);

            }

        }

        private void btn_AdicionarColaborador_Click_1(object sender, EventArgs e)
        {

            bool resultado = gestor.InsereColaboradorProjeto(gestor.PegarIdProjeto(cmb_AdicionarProjeto.Text), gestor.ProcuraColaboradorNome(cmb_AdicionarColaboradores.Text), Convert.ToInt32(nud_HorasColaborador.Value));

            if (resultado)
                MessageBox.Show(cmb_AdicionarColaboradores.Text + " foi adicionado(a) ao Projeto " + cmb_Removerprojeto.Text + " com sucesso.", " .:Mensagem:. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao adicionar  " + cmb_RemoverColaboradores.Text + " ao projeto " + cmb_Removerprojeto.Text, " .:Mensagem:. ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<Colaborador> col = gestor.VerificarColabaroradorProjetoExcluir(cmb_Removerprojeto.Text);
            cmb_RemoverColaboradores.Items.Clear();

            foreach (Colaborador c in col)
            {
                cmb_RemoverColaboradores.Items.Add(c.Nome);

            }
        }
    }
}
