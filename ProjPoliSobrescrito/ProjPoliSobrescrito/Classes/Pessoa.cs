using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPoliSobrescrito.Classes
{
    public class Pessoa
    {
        //Atributos
        public int idPessoa;
        public string nome;
        public string senha;
        public string contato;

        //Construtores



        //Propriedades




        //Métodos
        public virtual void Imprimir()
        {
            Console.WriteLine($"ID Pessoa: {idPessoa}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Senha: {senha}");
            Console.WriteLine($"Contato: {contato}");

        }


    }
}
