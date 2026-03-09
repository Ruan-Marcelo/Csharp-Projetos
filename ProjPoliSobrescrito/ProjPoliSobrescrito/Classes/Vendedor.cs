using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPoliSobrescrito.Classes
{
    internal class Vendedor : Pessoa
    {
        //Atributos
        public int qtdVenda;
        public string setor;
        public float comissao;

        //Construtores



        //Propriedades



        //Métodos
        public override void Imprimir()
        {
            Console.WriteLine($"Qtde de Venda: {qtdVenda}");
            Console.WriteLine($"Setor: {setor}");
            Console.WriteLine($"Comissão: {comissao}");

            base.Imprimir();


        }
    }
}
