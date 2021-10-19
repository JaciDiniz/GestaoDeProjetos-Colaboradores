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
    public partial class ColaboradorEditar : Form
    {
        IGestorProjetos gestor;
        string nif;
        public ColaboradorEditar(string nif)
        {
            InitializeComponent();
            gestor = new GestorProjeto();
            this.nif = nif;

            if (gestor.ProcuraColaborador(nif).TecnologiasDeDominio == "Programador")
            {
                Programador programador = (Programador)gestor.ProcuraColaborador(nif);
                txb_Nome.Text = programador.Nome;
                txb_Nif.Text = programador.Nif.ToString();
                txb_Morada.Text = programador.Morada;
                clb_Habilitacao.Text = programador.Habilitacao;
                numup_ValorHora.Value = Convert.ToDecimal(programador.ValorHora);
                cmb_Tecnologias.Text = programador.TecnologiasDeDominio;

            }
            else if (gestor.ProcuraColaborador(nif).TecnologiasDeDominio == "Gestor de Redes")
            {
                GestorRedes gestorRedes = (GestorRedes)gestor.ProcuraColaborador(nif);
                txb_Nome.Text = gestorRedes.Nome;
                txb_Nif.Text = gestorRedes.Nif.ToString();
                txb_Morada.Text = gestorRedes.Morada;
                clb_Habilitacao.Text = gestorRedes.Habilitacao;
                numup_ValorHora.Value = Convert.ToDecimal(gestorRedes.ValorHora);
                cmb_Tecnologias.Text = gestorRedes.TecnologiasDeDominio;


            }
            else
            {
                OperacionalTecnico operacional = (OperacionalTecnico)gestor.ProcuraColaborador(nif);
                txb_Nome.Text = operacional.Nome;
                txb_Nif.Text = operacional.Nif.ToString();
                txb_Morada.Text = operacional.Morada;
                clb_Habilitacao.Text = operacional.Habilitacao;
                numup_ValorHora.Value = Convert.ToDecimal(operacional.ValorHora);
                cmb_Tecnologias.Text = operacional.TecnologiasDeDominio;

            }
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


            if (txb_Morada.Text == "" || txb_Nome.Text == "" || numup_ValorHora.Value == 0 || cmb_Tecnologias.Text == "" || clb_Habilitacao.Text == "")
                MessageBox.Show("Preencha todos os campos!", "Editar Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                if (Int32.TryParse(txb_Nif.Text, out int nif) && txb_Nif.Text.Length == 9)
                {
                    if (cmb_Tecnologias.Text == "Programador")
                    {
                        Programador programador = new Programador(txb_Nome.Text, nif, txb_Morada.Text, clb_Habilitacao.Text, (double)numup_ValorHora.Value, cmb_Tecnologias.Text);


                        bool resultado = gestor.AtualizarColaborador(programador,numid);
                        if (resultado)
                            MessageBox.Show("Programador(a) " + txb_Nome.Text + " atualizado(a) com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Erro ao atualizar o Programador(a). ", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cmb_Tecnologias.Text == "Gestor de Redes")
                    {
                        GestorRedes gestorRedes = new GestorRedes(txb_Nome.Text, nif, txb_Morada.Text, clb_Habilitacao.Text, (double)numup_ValorHora.Value, cmb_Tecnologias.Text);


                        bool resultado = gestor.AtualizarColaborador(gestorRedes,numid);
                        if (resultado)
                            MessageBox.Show("Gestor(a) de Redes " + txb_Nome.Text + " atualizado(a) com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Erro ao atualizar o Gestor(a) de Redes. ", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        OperacionalTecnico operacional = new OperacionalTecnico(txb_Nome.Text, nif, txb_Morada.Text, clb_Habilitacao.Text, (double)numup_ValorHora.Value, cmb_Tecnologias.Text);


                        bool resultado = gestor.AtualizarColaborador(operacional,numid);
                        if (resultado)
                            MessageBox.Show("Operacional Técnico " + txb_Nome.Text + " atualizado com sucesso.", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Erro ao atualizar o Operacional Tecnico ", ".:Mensagem:.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
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
    }
}
