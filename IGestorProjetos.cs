using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Projetos
{
    interface IGestorProjetos
    {
        bool AtualizarColaborador (Colaborador colaborador, int[] tecnologias);//
        bool InsereColaborador(Colaborador colaborador, int[] tecnologias);//
        bool EliminaColaborador(int NIF);//
        Colaborador ProcuraColaborador(string NIF);//
        int ProcuraColaboradorNome(string nome);//
        List<Colaborador> ProcuraColaboradores(string nif);   //
        bool InsereProjeto(Projetos projeto, int[] tecnologias); //
        bool InsereColaboradorProjeto(int idprojeto, int nifColaborador , int horas);//
        
      
        bool EliminaProjeto(string nome);//


        bool EliminaColaboradorProjeto(string nomeprojeto, int nifColaborador);//
        bool AlterarProjeto(Projetos projeto, string antigonome, int[] tecnologias); //
        List<Tecnologia> ProcuraTecnologia(string atividade);//

        int ProcuraIdTecnologia(string tec);//

       

        bool DeletarColId(string nif);//

        List<Projetos> ProcuraProjetos(string nome);//

        List<Colaborador> VerificarColabaroradorProjeto(string nome);//

        List<Colaborador> VerificarColabaroradorProjetoExcluir(string nome);//


        int PegarIdProjeto(string nome);//

        List<Tecnologia> MostrarTecnologias(string nomeProjeto);//

        List<Colaborador> MostrarColaborador(string nomeProjeto);//

        bool InsereNovaTecnologia(string nome, string competencia, double custo);//


    }
}
