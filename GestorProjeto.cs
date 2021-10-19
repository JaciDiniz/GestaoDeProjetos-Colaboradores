using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gestão_de_Projetos
{
    class GestorProjeto : IGestorProjetos
    {
        private SqlConnection connection;

        public GestorProjeto()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Jaci\GestãoDeProjetos\db_Colaboradores.mdf;Integrated Security=True");
        }



        public bool AlterarProjeto(Projetos projeto, string antigonome, int[] tecnologias)
        {
            int idprojeto = PegarIdProjeto(antigonome);


            SqlCommand command = projeto.ComandoAlterar(idprojeto, projeto.DescricaoIntervencao, projeto.Nome);

            command.Connection = connection;
            int rows = 0;

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();


                connection.Close();
            }
            catch (SqlException)
            {
                connection.Close();
                return false;

            }



            connection.Open();

            SqlCommand coltec = new SqlCommand("DELETE FROM projtec WHERE id_projeto = " + idprojeto, connection);


            try
            {

                coltec.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }

            connection.Open();

            SqlCommand sql = new SqlCommand("SELECT id FROM projeto WHERE CONVERT(VARCHAR,nome) = @nome", connection);
            sql.Parameters.AddWithValue("@nome", projeto.Nome);

            SqlDataReader sqlDataReader = sql.ExecuteReader();


            if (sqlDataReader.Read())
            {

                int id = int.Parse(sqlDataReader["id"].ToString());


                rows = 0;
                connection.Close();
                for (int i = 0; i < tecnologias.Length; i++)
                {
                    command = projeto.ComandoInserirProjetoTec(id, tecnologias[i]);
                    command.Connection = connection;

                    try
                    {

                        connection.Open();

                        rows = command.ExecuteNonQuery();


                        connection.Close();
                    }
                    catch (SqlException)
                    {
                        connection.Close();
                        return false;

                    }


                }

            }

            return rows > 0;


        }

        public bool AtualizarColaborador(Colaborador colaborador, int[] tecnologias)
        {
            SqlCommand command = colaborador.ComandoAtualizar();
            command.Connection = connection;
            int rows = 0;

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException)
            {
                connection.Close();
                return false;

            }
            SqlCommand coltec = new SqlCommand("DELETE FROM coltec WHERE nif = @nif", connection);
            coltec.Parameters.AddWithValue("@nif", colaborador.Nif);

            try
            {
                connection.Open();
                coltec.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }


            rows = 0;
            for (int i = 0; i < tecnologias.Length; i++)
            {
                SqlCommand commandtec = colaborador.ComandoInserirTec(colaborador.Nif, tecnologias[i]);
                commandtec.Connection = connection;

                try
                {
                    connection.Open();
                    rows = commandtec.ExecuteNonQuery();


                    connection.Close();
                }
                catch (SqlException)
                {
                    connection.Close();
                    return false;

                }


            }

            return rows > 0;
        }


        public bool DeletarColId(string nif)
        {
            SqlCommand sql = new SqlCommand("DELETE FROM coltec WHERE nif =" + nif, connection);
            sql.Parameters.AddWithValue("@nif", nif);
            connection.Open();
            int rows = sql.ExecuteNonQuery();

            if (rows > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public bool EliminaColaborador(int NIF)
        {
            SqlCommand sql = new SqlCommand("DELETE FROM coltec WHERE nif =" + NIF, connection);
            sql.Parameters.AddWithValue("@nif", NIF);
            connection.Open();
            int rows = sql.ExecuteNonQuery();

            sql = new SqlCommand("DELETE FROM projeto_colaborador WHERE nif_colaborador =" + NIF, connection);
            sql.Parameters.AddWithValue("@nif", NIF);
            rows = sql.ExecuteNonQuery();


            sql = new SqlCommand("DELETE FROM colaborador WHERE nif =" + NIF, connection);
            sql.Parameters.AddWithValue("@nif", NIF);
            rows = sql.ExecuteNonQuery();


            if (rows > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }

        }

        public bool EliminaColaboradorProjeto(string nomeprojeto, int nifColaborador)
        {
            int id = PegarIdProjeto(nomeprojeto);

            SqlCommand sql = new SqlCommand("DELETE FROM projeto_colaborador WHERE id_projeto =" + id + " AND nif_colaborador = " + nifColaborador, connection);
            connection.Open();
            int rows = sql.ExecuteNonQuery();

            if (rows > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public bool EliminaProjeto(string nome)
        {
            int id = PegarIdProjeto(nome);

            SqlCommand sql = new SqlCommand("DELETE FROM projeto_colaborador WHERE id_projeto =" + id, connection);
            connection.Open();
            int rows = sql.ExecuteNonQuery();

            sql = new SqlCommand("DELETE FROM projtec WHERE id_projeto =" + id, connection);
            rows = sql.ExecuteNonQuery();

            sql = new SqlCommand("DELETE FROM projeto WHERE id =" + id, connection);
            rows = sql.ExecuteNonQuery();


            if (rows > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public bool InsereColaborador(Colaborador colaborador, int[] tecnologias)
        {
            SqlCommand command = colaborador.ComandoInserir();

            command.Connection = connection;
            int rows = 0;

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();


                connection.Close();
            }
            catch (SqlException)
            {
                connection.Close();
                return false;

            }


            rows = 0;
            for (int i = 0; i < tecnologias.Length; i++)
            {
                SqlCommand commandtec = colaborador.ComandoInserirTec(colaborador.Nif, tecnologias[i]);
                commandtec.Connection = connection;

                try
                {
                    connection.Open();
                    rows = commandtec.ExecuteNonQuery();


                    connection.Close();
                }
                catch (SqlException)
                {
                    connection.Close();
                    return false;

                }


            }

            return rows > 0;
        }



        public bool InsereColaboradorProjeto(int idprojeto, int nifColaborador, int horas)
        {

            SqlCommand sql = new SqlCommand("INSERT INTO projeto_colaborador VALUES( @idprojeto,@nifColaborador,@horas)", connection);
            sql.Parameters.AddWithValue("@idprojeto", idprojeto);
            sql.Parameters.AddWithValue("@nifColaborador", nifColaborador);
            sql.Parameters.AddWithValue("@horas", horas);
            connection.Open();
            int rows = sql.ExecuteNonQuery();


            if (rows > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }



        }

        public bool InsereNovaTecnologia(string nome, string competencia, double custo)
        {
            SqlCommand sql = new SqlCommand("INSERT INTO tecnologia VALUES(@nome, @competencia, @valor);", connection);
            sql.Parameters.AddWithValue("@nome", nome);
            sql.Parameters.AddWithValue("@competencia", competencia);
            sql.Parameters.AddWithValue("@valor", custo);
            connection.Open();
            int rows = sql.ExecuteNonQuery();


            if (rows > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }

        }

        public bool InsereProjeto(Projetos projeto, int[] tecnologias)
        {
            SqlCommand command = projeto.ComandoInserir();

            command.Connection = connection;
            int rows = 0;

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();


                connection.Close();
            }
            catch (SqlException)
            {
                connection.Close();
                return false;

            }


            connection.Open();


            SqlCommand sql = new SqlCommand("SELECT id FROM projeto WHERE CONVERT(VARCHAR,nome) = @nome", connection);
            sql.Parameters.AddWithValue("@nome", projeto.Nome);

            SqlDataReader sqlDataReader = sql.ExecuteReader();


            if (sqlDataReader.Read())
            {

                int id = int.Parse(sqlDataReader["id"].ToString());


                rows = 0;
                connection.Close();
                for (int i = 0; i < tecnologias.Length; i++)
                {
                    command = projeto.ComandoInserirProjetoTec(id, tecnologias[i]);
                    command.Connection = connection;

                    try
                    {

                        connection.Open();

                        rows = command.ExecuteNonQuery();


                        connection.Close();
                    }
                    catch (SqlException)
                    {
                        connection.Close();
                        return false;

                    }


                }

            }

            return rows > 0;
        }

        public List<Colaborador> MostrarColaborador(string nomeProjeto)
        {

            int idprojeto = PegarIdProjeto(nomeProjeto);

            List<Colaborador> colaboradores = new List<Colaborador>();
            string query = "SELECT * FROM colaborador INNER JOIN projeto_colaborador ON colaborador.nif = projeto_colaborador.nif_colaborador WHERE id_projeto = '" + idprojeto + "';";


            SqlCommand sql = new SqlCommand(query);

            sql.Connection = connection;
            connection.Open();
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                Colaborador colaborador = null;


                string nome = reader["nome"].ToString();
                double valorhora = double.Parse(reader["valorhora"].ToString());
                double horas = double.Parse(reader["horas"].ToString());

                colaborador = new Programador(nome, valorhora, horas);

                colaboradores.Add(colaborador);
            }




            connection.Close();
            return colaboradores;
        }

        public List<Tecnologia> MostrarTecnologias(string nomeProjeto)
        {
            int idprojeto = PegarIdProjeto(nomeProjeto);

            List<Tecnologia> tecnologias = new List<Tecnologia>();
            string query = "SELECT id, tecnologias,area_atividade,custo FROM projtec INNER JOIN tecnologia ON projtec.id_tec = tecnologia.id WHERE projtec.id_projeto = '" + idprojeto + "';";


            SqlCommand sql = new SqlCommand(query);

            sql.Connection = connection;
            connection.Open();
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                Tecnologia tecnologia = null;

                int id = int.Parse(reader["id"].ToString());
                string tec = reader["tecnologias"].ToString();
                string area_atividade = reader["area_atividade"].ToString();
                double custo = double.Parse(reader["custo"].ToString());

                tecnologia = new Tecnologia(id, tec, area_atividade, custo);

                tecnologias.Add(tecnologia);
            }
            connection.Close();
            return tecnologias;
        }

        public int PegarIdProjeto(string nome)
        {

            connection.Open();
            SqlCommand sql = new SqlCommand("SELECT id FROM projeto WHERE CONVERT(VARCHAR,nome) = @nome", connection);
            sql.Parameters.AddWithValue("@nome", nome);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            if (sqlDataReader.Read())
            {

                int idTec = int.Parse(sqlDataReader["id"].ToString());
                connection.Close();
                return idTec;



            }


            connection.Close();

            return 0;
        }

        public List<Tecnologia> PegarIdTecnologias(int id)
        {

            List<Tecnologia> tecnologias = new List<Tecnologia>();
            string query = "SELECT id_tec FROM projtec WHERE id_projeto =" + id;


            SqlCommand sql = new SqlCommand(query);

            sql.Connection = connection;
            connection.Open();
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                Tecnologia tecnologia = null;

                int id_tec = int.Parse(reader["id_tec"].ToString());


                tecnologia = new Tecnologia(id_tec);

                tecnologias.Add(tecnologia);
            }
            connection.Close();
            return tecnologias;
        }

        public List<Colaborador> PegarNifTec(int id)
        {

            List<Colaborador> tecnologias = new List<Colaborador>();
            string query = "SELECT nif FROM coltec WHERE id_tec = " + id;


            SqlCommand sql = new SqlCommand(query);

            sql.Connection = connection;
            connection.Open();
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                Colaborador tecnologia = null;

                int nif = int.Parse(reader["nif"].ToString());

                tecnologias.Add(tecnologia);
            }
            connection.Close();
            return tecnologias;
        }

        public Colaborador ProcuraColaborador(string NIF)
        {
            Colaborador colaborador = null;


            connection.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM colaborador WHERE nif = @nif", connection);
            sql.Parameters.AddWithValue("@nif", NIF);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string nome = sqlDataReader["nome"].ToString();
                int colabNif = int.Parse(sqlDataReader["nif"].ToString());
                string morada = sqlDataReader["morada"].ToString();
                string habilitacao = sqlDataReader["habilitacao"].ToString();
                double valhora = double.Parse(sqlDataReader["valorhora"].ToString());
                string tecno = sqlDataReader["tecnologias"].ToString();



                if (tecno == "Programador")
                    colaborador = new Programador(nome, colabNif, morada, habilitacao, valhora, tecno);
                else if (tecno == "Gestor de Redes")
                    colaborador = new GestorRedes(nome, colabNif, morada, habilitacao, valhora, tecno);
                else
                    colaborador = new OperacionalTecnico(nome, colabNif, morada, habilitacao, valhora, tecno);

            }


            connection.Close();

            return colaborador;
        }

        public List<Colaborador> ProcuraColaboradores(string nif)
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            string query = "SELECT * FROM colaborador ";
            if (nif != string.Empty)
            {
                query += " WHERE nif LIKE '" + @nif + "%' OR nome LIKE '" + @nif + "%' OR tecnologias LIKE '" + @nif + "%' ";
            }

            SqlCommand sql = new SqlCommand(query);

            sql.Connection = connection;
            connection.Open();
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                Colaborador colaborador = null;

                string nome = reader["nome"].ToString();
                int colabNif = int.Parse(reader["nif"].ToString());
                string morada = reader["morada"].ToString();
                string habilitacao = reader["habilitacao"].ToString();
                double valhora = double.Parse(reader["valorhora"].ToString());
                string tecno = reader["tecnologias"].ToString();

                if (tecno == "Programador")
                    colaborador = new Programador(nome, colabNif, morada, habilitacao, valhora, tecno);
                else if (tecno == "Gestor de Redes")
                    colaborador = new GestorRedes(nome, colabNif, morada, habilitacao, valhora, tecno);
                else
                    colaborador = new OperacionalTecnico(nome, colabNif, morada, habilitacao, valhora, tecno);

                colaboradores.Add(colaborador);
            }
            connection.Close();
            return colaboradores;
        }

        public int ProcuraColaboradorNome(string nome)
        {
            connection.Open();
            SqlCommand sql = new SqlCommand("SELECT nif FROM colaborador WHERE nome LIKE @nome;", connection);
            sql.Parameters.AddWithValue("@nome", nome);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            if (sqlDataReader.Read())
            {

                int nif = int.Parse(sqlDataReader["nif"].ToString());
                connection.Close();
                return nif;



            }


            connection.Close();

            return 0;
        }



        public int ProcuraIdTecnologia(string tec)
        {

            connection.Open();
            SqlCommand sql = new SqlCommand("SElECT id FROM tecnologia where tecnologias LIKE @tec", connection);
            sql.Parameters.AddWithValue("@tec", tec);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            if (sqlDataReader.Read())
            {

                int idTec = int.Parse(sqlDataReader["id"].ToString());
                connection.Close();
                return idTec;



            }


            connection.Close();

            return 0;
        }



        public List<Projetos> ProcuraProjetos(string nome)
        {
            List<Projetos> projetos = new List<Projetos>();
            string query = "SELECT * FROM projeto ";
            if (nome != string.Empty)
            {
                query += " WHERE nome LIKE '%" + nome + "%' OR descricao LIKE '%" + nome + "%' OR id LIKE '" + nome + "'";
            }

            SqlCommand sql = new SqlCommand(query);

            sql.Connection = connection;
            connection.Open();
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                Projetos projeto = null;
                string name = reader["nome"].ToString();
                string descricao = reader["descricao"].ToString();

                projeto = new Projetos(name, descricao);

                projetos.Add(projeto);
            }
            connection.Close();
            return projetos;

        }



        public List<Tecnologia> ProcuraTecnologia(string atividade)
        {
            List<Tecnologia> tecnologias = new List<Tecnologia>();
            string query = "SELECT * FROM tecnologia ";
            if (atividade != string.Empty)
            {
                query += " WHERE area_atividade LIKE '" + atividade + "'";
            }

            SqlCommand sql = new SqlCommand(query);

            sql.Connection = connection;
            connection.Open();
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                Tecnologia tecnologia = null;

                int id = int.Parse(reader["id"].ToString());
                string tec = reader["tecnologias"].ToString();
                string area_atividade = reader["area_atividade"].ToString();
                double custo = double.Parse(reader["custo"].ToString());

                tecnologia = new Tecnologia(id, tec, area_atividade, custo);

                tecnologias.Add(tecnologia);
            }
            connection.Close();
            return tecnologias;
        }

        public List<Colaborador> VerificarColabaroradorProjeto(string nome)
        {

            int id = PegarIdProjeto(nome);

            List<Tecnologia> tec = PegarIdTecnologias(id);

            List<Colaborador> colaboradores = new List<Colaborador>();
            string query = "SELECT nif FROM projtec INNER JOIN coltec ON projtec.id_tec = coltec.id_tec WHERE projtec.id_projeto =  " + id + ";";

            SqlCommand sql = new SqlCommand(query);

            sql.Connection = connection;
            connection.Open();
            SqlDataReader reader = sql.ExecuteReader();

            List<string> nifs = new List<string>();

            while (reader.Read())
            {

                if (!nifs.Contains(reader["nif"].ToString()))
                    nifs.Add(reader["nif"].ToString());
            }


            connection.Close();
            foreach (string n in nifs)
            {
                colaboradores.Add(ProcuraColaborador(n));
            }
            return colaboradores;
        }

        public List<Colaborador> VerificarColabaroradorProjetoExcluir(string nome)
        {
            int id = PegarIdProjeto(nome);

            List<Tecnologia> tec = PegarIdTecnologias(id);

            List<Colaborador> colaboradores = new List<Colaborador>();
            string query = "SELECT nif FROM colaborador INNER JOIN projeto_colaborador ON colaborador.nif = projeto_colaborador.nif_colaborador WHERE id_projeto =" + id + ";";
            SqlCommand sql = new SqlCommand(query);

            sql.Connection = connection;
            connection.Open();
            SqlDataReader reader = sql.ExecuteReader();

            List<string> nifs = new List<string>();

            while (reader.Read())
            {

                if (!nifs.Contains(reader["nif"].ToString()))
                    nifs.Add(reader["nif"].ToString());
            }


            connection.Close();
            foreach (string n in nifs)
            {
                colaboradores.Add(ProcuraColaborador(n));
            }
            return colaboradores;
        }
    }
}
