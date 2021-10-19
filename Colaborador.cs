using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Projetos
{
        abstract class Colaborador
    {
        public string Nome { get; set; }
        public int Nif { get; set; }
        public string Morada { get; set; }
        public string Habilitacao { get; set; }
        public double ValorHora { get; set; }
        public string TecnologiasDeDominio { get; set; }
        public double Horas { get; set; }

        public Colaborador(string nome , int nif , string morada, string habilitacao, double valorhora, string tec)
        {
            Nome = nome;
            Nif = nif;
            Morada = morada;
            Habilitacao = habilitacao;
            ValorHora = valorhora;
            TecnologiasDeDominio = tec;
        }

     
        public Colaborador(string nome, double valorhora, double horasproj)
        {
            Nome = nome;
            
            ValorHora = valorhora;
            
            Horas = horasproj;
        }

        public abstract SqlCommand ComandoInserir();

        public abstract SqlCommand ComandoInserirTec(int nif,int tec);

        public abstract SqlCommand ComandoAtualizar();

        public abstract SqlCommand ComandoAtualizarTec(int nif, int tec);


    }
}
