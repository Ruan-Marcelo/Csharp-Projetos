using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjtTrabalho.Classes
{
    public class Disciplina
    {
        //Atributos
        private string nomeDis;
        private float cargaHora;
        private int idProfessor;

        //Construtores
        public Disciplina()
        {

        }
        public Disciplina(string nomeDis, int idProfessor)
        {
            this.nomeDis = nomeDis;
            this.idProfessor = idProfessor;
        }

        //Propriedades
        public string NomeDis
        {
            get { return nomeDis; }
            set { nomeDis = value; }
        }
        public float CargaHora
        {
            get { return cargaHora; }
            set { cargaHora = value; }
        }
        public int IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        //Métodos
        public void Imprimi()
        {
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"           Disciplinas");
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Nome da Disciplinas: {nomeDis}");
            Console.WriteLine($"Carga horario da Disciplinas: {cargaHora}");
            Console.WriteLine($"Id Professor: {idProfessor}");
        }
    }
}
