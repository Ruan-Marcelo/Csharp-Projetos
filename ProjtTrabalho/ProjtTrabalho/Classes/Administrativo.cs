using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjtTrabalho.Classes
{
    public class Administrativo: Pessoa
    {
        //Atributos
        private int idAdm;
        private string cargo;
        private DateTime admissao;

        //Construtores
        public Administrativo()
        {

        }
        public Administrativo(int idAdm, string cargo)
        {
            this.idAdm = idAdm;
            this.cargo = cargo;
        }

        //Propriedades
        public int IdAdm
        {
            get { return idAdm; }
            set { idAdm = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public DateTime Admissao
        {
            get { return admissao; }
            set { admissao = value; }
        }

        //Métodos
        public void Imprimir()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("          Administrativo");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"id Administrador: {idAdm}");
            Console.WriteLine($"Nome do cargo: {cargo}");
            Console.WriteLine($"Data admissão do cargo: {admissao}");
        }

        public override void roupas(string nomeRoupa)
        {
            Console.WriteLine($"Nome da vestimento: {nomeRoupa}");
        }
    }
}
