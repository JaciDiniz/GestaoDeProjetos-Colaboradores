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
    public partial class ColaboradorAdicionarTecnologia : Form
    {
        IGestorProjetos gestor;
        public ColaboradorAdicionarTecnologia()
        {
            InitializeComponent();
            gestor = new GestorProjeto();
        }

        private void btn_AdicionarTecnologia_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "" || cmb_Tecnologias.Text == "" || numup_ValorTec.Value == 0 )
                MessageBox.Show("Preencha todos os campos!", "Adicionar Tecnologia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else {
                DialogResult confirm = MessageBox.Show("Você quer adicionar a tecnologia " + txt_Nome.Text + " à competência "+ cmb_Tecnologias.Text +" com o custo de "+numup_ValorTec.Value +" € ?", "Eliminar Colaborador", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    bool resultado = gestor.InsereNovaTecnologia(txt_Nome.Text, cmb_Tecnologias.Text, Convert.ToDouble(numup_ValorTec.Value));
                    if (resultado)
                        MessageBox.Show("Tecnologia " + txt_Nome.Text + " adicionado(a) com sucesso.", "Adicionar Tecnologia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro ao adicionar o Tecnologia. ", "Adicionar Tecnologia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
