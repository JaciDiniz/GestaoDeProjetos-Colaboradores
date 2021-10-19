using System.Data.SqlClient;

namespace Gestão_de_Projetos
{
    public class Tecnologia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string AreaAtividade{ get; set; }
        public double Custo { get; set; }

        public Tecnologia(int id, string nome, string atividade, double custo)
        {
            Id = id;
            Nome = nome;
            AreaAtividade = atividade;
            Custo = custo;
        }

        public Tecnologia(int id)
        {
            Id = id;
         
        }

   
    }
}