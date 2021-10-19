using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Projetos
{
    class OperacionalTecnico : Colaborador
    {

        public OperacionalTecnico(string nome, int nif, string morada, string habilitacao, double valorhora, string tec)
            :base(nome,nif,morada,habilitacao,valorhora,tec)
        {

        }

        public override SqlCommand ComandoAtualizar()
        {
            SqlCommand command = new SqlCommand("UPDATE colaborador SET nome = @nome, morada = @morada, habilitacao = @habilitacao, valorhora = @valorhora, tecnologias = @tec WHERE nif ='" + Nif + "';");
            command.Parameters.AddWithValue("@nome", Nome);
            command.Parameters.AddWithValue("@morada", Morada);
            command.Parameters.AddWithValue("@habilitacao", Habilitacao);
            command.Parameters.AddWithValue("@valorhora", ValorHora);
            command.Parameters.AddWithValue("@tec", TecnologiasDeDominio);
            return command;
        }

        public override SqlCommand ComandoAtualizarTec(int nif, int tec)
        {
            SqlCommand command = new SqlCommand("UPDATE coltec SET id_tec = @tec WHERE nif ='" + nif + "';");
            command.Parameters.AddWithValue("@nome", tec);
            return command;
        }

        public override SqlCommand ComandoInserir()
        {
            SqlCommand command = new SqlCommand("INSERT INTO colaborador VALUES(@nome, @nif, @morada, @habilitacao, @valorhora, @tec);");

            command.Parameters.AddWithValue("@nome", Nome);
            command.Parameters.AddWithValue("@nif", Nif);
            command.Parameters.AddWithValue("@morada", Morada);
            command.Parameters.AddWithValue("@habilitacao", Habilitacao);
            command.Parameters.AddWithValue("@valorhora", ValorHora);
            command.Parameters.AddWithValue("@tec", TecnologiasDeDominio);
            return command;
        }

        public override SqlCommand ComandoInserirTec(int nif, int tec)
        {
            SqlCommand command = new SqlCommand("INSERT INTO coltec VALUES(@nif, @id_tec);");

            command.Parameters.AddWithValue("@nif", nif);
            command.Parameters.AddWithValue("@id_tec", tec);
            return command;
        }
    }
}
