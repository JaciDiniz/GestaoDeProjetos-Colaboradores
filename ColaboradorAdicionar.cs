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
    public partial class ColaboradorAdicionar : Form
    {
        IGestorProjetos gestor;


        public ColaboradorAdicionar()
        {
            InitializeComponent();
            gestor = new GestorProjeto();
        }

        private void btn_AdicionarColaborador_Click(object sender, EventArgs e)
        {
            int num5 = ckl_tecnologia.CheckedItems.Count;
            int[] numid = new int[num5];

            for (int i = 0; i < num5; i++)
            {
                int num1 = gestor.ProcuraIdTecnologia(ckl_tecnologia.CheckedItems[i].ToString());
                if (num1 > 0)
                    numid[i] = num1;
            }

            if (txb_Morada.Text == "" || txb_Nome.Text == "" || txb_Nif.Text == "" || numup_ValorHora.Value == 0 || cmb_Tecnologias.Text == "" || clb_Habilitacao.Text == "" || ckl_tecnologia.Text == "")
                MessageBox.Show("Preencha todos os campos!", " .:Mensagem:. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                if (Int32.TryParse(txb_Nif.Text, out int nif) && txb_Nif.Text.Length == 9)
                {
                    if (cmb_Tecnologias.Text == "Programador")
                    {
                        Programador colaborador = new Programador(txb_Nome.Text, nif, txb_Morada.Text, clb_Habilitacao.Text, (Double)numup_ValorHora.Value, cmb_Tecnologias.Text);


                        bool resultado = gestor.InsereColaborador(colaborador, numid);
                        if (resultado)
                            MessageBox.Show("Programador(a) " + txb_Nome.Text + " adicionado(a) com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Erro ao adicionar o Programador(a). ", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cmb_Tecnologias.Text == "Gestor de Redes")
                    {
                        GestorRedes gestorRedes = new GestorRedes(txb_Nome.Text, nif, txb_Morada.Text, clb_Habilitacao.Text, (Double)numup_ValorHora.Value, cmb_Tecnologias.Text);


                        bool resultado = gestor.InsereColaborador(gestorRedes, numid);
                        if (resultado)
                            MessageBox.Show("Gestor(a) de Redes " + txb_Nome.Text + " adicionado(a) com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Erro ao adicionar o Gestor(a) de Redes. ", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        OperacionalTecnico operacional = new OperacionalTecnico(txb_Nome.Text, nif, txb_Morada.Text, clb_Habilitacao.Text, (Double)numup_ValorHora.Value, cmb_Tecnologias.Text);


                        bool resultado = gestor.InsereColaborador(operacional, numid);
                        if (resultado)
                            MessageBox.Show("Operacional Técnico " + txb_Nome.Text + " adicionado com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Erro ao adicionar o Operacional Tecnico ", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else if ((Int32.TryParse(txb_Nif.Text, out nif) && txb_Nif.Text.Length != 9))
                {
                    MessageBox.Show("O NIF deve conter 9 números", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O NIF deve conter apenas números", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmb_Tecnologias_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Tecnologia> tec = gestor.ProcuraTecnologia(cmb_Tecnologias.Text);
            ckl_tecnologia.Items.Clear();

            foreach (Tecnologia t in tec)
            {
                ckl_tecnologia.Items.Add(t.Nome);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColaboradorAdicionarTecnologia adicionarTecnologia = new ColaboradorAdicionarTecnologia();
            adicionarTecnologia.Show();
        }
    }
}

