using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Projetos
{
    class Projetos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DescricaoIntervencao { get; set; }

        public string Tecnologias { get; set; }
        public string ColaboradorAssociado { get; set; }
        public int Horas { get; set; }


        public Projetos( string nome, string descricao)
        {
           
            Nome = nome;
            DescricaoIntervencao = descricao;
            
        }


        public SqlCommand ComandoInserir()
        {
            SqlCommand command = new SqlCommand("INSERT INTO projeto (nome,descricao) VALUES(@nome,@des);");

            command.Parameters.AddWithValue("@nome", Nome);
            command.Parameters.AddWithValue("@des", DescricaoIntervencao);
           
            return command;
        }

        public SqlCommand ComandoAlterar(int id, string novadesc, string novonome)
        {
            SqlCommand command = new SqlCommand("UPDATE projeto SET nome= @nome, descricao = @des WHERE id = " + id + ";");

            command.Parameters.AddWithValue("@nome", novonome);
            command.Parameters.AddWithValue("@des", novadesc);

            return command;
        }

        public SqlCommand ComandoInserirProjetoTec(int id, int tec)
        {
            SqlCommand command = new SqlCommand("INSERT INTO projtec (id_projeto,id_tec) VALUES('"+ id + "', '" + tec + "');");
            return command;
        }

    }
}
