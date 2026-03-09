using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjtTrabalho.Classes
{
    public class Aula
    {
        //Atributos
        private DateTime horaAula;
        private int numSala;
        private string diasSemana;
        //Relacionamento
        private Disciplina[] disciplinas;

        //Construtores
        public Aula()
        {

        }
        public Aula(string diasSemana,int numSala)
        {
            this.diasSemana = diasSemana;
            this.numSala = numSala;
        }

        //Propriedades
        public Disciplina[] Disciplinas
        {
            get
            {
                if (disciplinas == null)
                {
                    disciplinas = new Disciplina[1];
                }
                return disciplinas;
            }
            set
            {
                if (disciplinas == null)
                {
                    disciplinas = new Disciplina[1];
                }
                disciplinas = value;
            }
        }
        public DateTime HoraAula
        {
            get { return horaAula; }
            set { horaAula = value; }
        }
        public int NumSala
        {
            get { return numSala; }
            set { numSala = value; }
        }
        public string DiasSemana
        {
            get { return diasSemana; }
            set { diasSemana = value; }
        }

        //Métodos
        public void Imprimir()
        {
            Console.WriteLine($"Hora da aula: {horaAula}");
            Console.WriteLine($"Número da aula: {numSala}");
            Console.WriteLine($"Dias da semana: {diasSemana}");

            if(disciplinas != null)
            {
                foreach(Disciplina disciplina in disciplinas)
                {
                    Console.WriteLine($"------------------------------------");
                    Console.WriteLine($"           Disciplinas");
                    Console.WriteLine($"------------------------------------");
                    Console.WriteLine($"Nome da Disciplinas: {disciplina.NomeDis}");
                    Console.WriteLine($"Carga horario da Disciplinas: {disciplina.CargaHora}");
                    Console.WriteLine($"Id Professor: {disciplina.IdProfessor}");
                }
            }
        }
        
    }
}
