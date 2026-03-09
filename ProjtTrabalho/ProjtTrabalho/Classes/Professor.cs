using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjtTrabalho.Classes
{
    public class Professor: Pessoa
    {
        //Atributos
        private int idProfessor;
        private string nomeEscola;
        private DateTime dataNasc;
        //Relacionamento 1..*
        private List<Disciplina> disciplinas;

        //Construtores
        public Professor()
        {

        }
        public Professor(int idProfessor, string nomeEscola)
        {
            this.idProfessor = idProfessor;
            this.nomeEscola = nomeEscola;
        }

        //Propriedades
        public List<Disciplina> Disciplinas
        {
            get
            {
                if (disciplinas == null)
                {
                    disciplinas = new List<Disciplina>();
                }
                return disciplinas;
            }
            set
            {
                if (disciplinas == null)
                {
                    disciplinas = new List<Disciplina>();
                }
                disciplinas = value;
            }
        }
        public int IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }
        public string NomeEscola
        {
            get { return nomeEscola;}
            set { nomeEscola = value; }
        }
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        //Métodos
        public  void Imprimir()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("          Professor");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"id Professor: {idProfessor}");
            Console.WriteLine($"Nome da Escola: {nomeEscola}");
            Console.WriteLine($"Data Nascimento: {dataNasc}");
        }
        public override void roupas(string nomeRoupa)
        {
            Console.WriteLine($"Nome da vestimento: {nomeRoupa}");
        }

    }
}
