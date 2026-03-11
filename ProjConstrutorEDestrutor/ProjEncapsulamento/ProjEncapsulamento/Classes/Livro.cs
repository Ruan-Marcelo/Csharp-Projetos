using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEncapsulamento.Classes
{
    internal class Livro
    {
        //atributos
        private string titulo;
        private float preco;
        private int qtdEstoque = 100;

        //propriedades
        public string Titulo
        {
            get 
            { 
                return titulo; 
            }
            set 
            { 
                titulo = value; 
            }
        }
        public float Preco
        {
            get 
            { 
                return preco; 
            }
            set 
            { 
                preco = value; 
            }
        }
        //métodos
        public float EfetuarDesconto(float desc)
        {
            float desconto;

            desconto = preco - desc;

            return desconto;
        }
        public void EfetuarVenda(int qtdVendida)
        {
            //outra forma = qtdEstoque = qtdEstoque - qtdVendida;

            qtdEstoque -= qtdVendida;
        }
        public void ImprimirDAdos()
        {
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Quantidade no estoque: {qtdEstoque}");
        }
    }
}
