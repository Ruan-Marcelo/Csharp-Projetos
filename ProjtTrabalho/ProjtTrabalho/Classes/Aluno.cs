using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjtTrabalho.Classes
{
    public class Aluno: Pessoa
    {
        //Atributos
        private int rnAluno;
        private string nomeEscola;
        private string serie;
        //Relacionamento 1..*
        private List<Aula> aulas;

        //Construtores
        public Aluno()
        {

        }
        public Aluno(int rnAluno, string nomeEscola)
        {
            this.rnAluno = rnAluno;
            this.nomeEscola = nomeEscola;
        }

        //Propriedades
        public List<Aula> Aulas
        {
            get
            {
                if(aulas == null)
                {
                    aulas = new List<Aula>();
                }
                return aulas;
            }
            set
            {
                if(aulas == null)
                {
                     aulas = new List<Aula>();
                }
                aulas = value;
            }
        }
        public int RnAluno
        {
            get { return rnAluno; }
            set { rnAluno = value; }
        }
        public string NomeEscola 
        { 
            get { return nomeEscola; } 
            set { nomeEscola = value; }
        }
        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        //Métodos
        public void Imprimir()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("          Aluno");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"RN Aluno: {rnAluno}");
            Console.WriteLine($"Nome da Escola: {nomeEscola}");
            Console.WriteLine($"Serie escolar : {serie}");

            if(aulas != null)
            {
                foreach(Aula aula in aulas)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("          Aulas");
                    Console.WriteLine($"Hora da aula: {aula.HoraAula}");
                    Console.WriteLine($"Número da aula: {aula.NumSala}");
                    Console.WriteLine($"Dias da semana: {aula.DiasSemana}");
                }
            }
        }

        public override void roupas(string nomeRoupa)
        {
            Console.WriteLine($"Nome da vestimento: {nomeRoupa}");
        }
    }
}
