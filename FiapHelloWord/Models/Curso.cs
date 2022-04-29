using FiapHelloWord.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWord.Models
{
    public class Curso: IAluno, IInstrutor
    {


        public Curso()
        {

        }

        public Curso(string nome, string instrutor)
        {
            this.NomeCurso = nome;
            this.NomeInstrutor = instrutor;
        }

        int Codigo;
        internal string NomeCurso;
        public string NomeInstrutor;
        private int cargaHoraria;
        protected int minAlunos;
        protected internal int maxAlunos;

        public void CriarCurso(string nome, string instrutor)
        {
            this.NomeCurso = nome;
            this.NomeInstrutor = instrutor;
        }

        public Curso(string nome, int minAlunos, int maxAlunos)
        {
            this.NomeCurso = nome;
            this.minAlunos = minAlunos; 
            this.maxAlunos = maxAlunos;
        }

        public bool MatricularAluno(string nomeAluno)
        {
            return true;
        }

        public int ConsultarMaximoAlunos()
        {
            return this.maxAlunos;
        }

        public void CriarInstrutor()
        {
            Console.WriteLine("Criado");
        }

        public void CriarAluno(string nome)
        {
            if(nome == null)
            {
                throw new Exception("Nome invalido");
            }
            Console.WriteLine("Aluno Criado");
        }

        public void CriarAluno()
        {
            throw new NotImplementedException();
        }
    }
}
