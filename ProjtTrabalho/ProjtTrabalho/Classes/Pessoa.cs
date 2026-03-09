using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjtTrabalho.Classes
{
    public class Pessoa 
    {
        //Atributo
        private string id;
        private string nome;
        private int idade;

        //Construtores
        public Pessoa()
        {

        }
        public Pessoa(string id, string nome, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
        }

        //Propriedades
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        //Métodos
        public  void ImprimirDados()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("          Pessoa");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"idade: {idade}");
        }

        public  virtual void roupas(string nomeRoupa)
        {
            Console.WriteLine($"Nome da vestimento: {nomeRoupa}");
        }


    }
}
