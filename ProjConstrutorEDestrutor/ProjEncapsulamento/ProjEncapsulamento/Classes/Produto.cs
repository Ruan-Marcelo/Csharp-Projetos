using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEncapsulamento.Classes
{
    internal class Produto
    {

        //atributos
        private int codProduto;
        private string descricao;    
        private float preco;
        private int qtdEstoque = 100;

        //métodos
        //Construtor
        public Produto()
        {
            qtdEstoque = 10 ;

            Console.WriteLine($"Qtde do produto em estoque: {qtdEstoque}");
        }

        //propriedades
        public int CodProduto
        {
            get
            {
                return codProduto;
            }
            set
            {
                codProduto = value;
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
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
        public void VendaProduto(int qtdeDeComprada)
        {
            qtdEstoque = qtdEstoque - qtdeDeComprada;
            Console.WriteLine($"Quantidade de estoque após a compra: {qtdEstoque}");


        }
        public void AumentarPreco(float novoPreco)
        {
            
            preco = preco * novoPreco ;
            Console.WriteLine($"Preço após o aumento: {preco}");

        }
        public void CalcularImpostos(float impostos)
        {
            preco = preco * impostos;
            Console.WriteLine($"Preço final: {preco}");

        }

        public void Imprimir()
        {
            Console.WriteLine($"Qtde do produto em estoque: {qtdEstoque.ToString()}");
            Console.WriteLine($"Codigo do Produto: {codProduto}");
            Console.WriteLine($"Decrição do Produto: {descricao}");
            Console.WriteLine($"Preço do Produto: {preco}");

        }
        ~Produto(){

            if (qtdEstoque < 5)
            {
                Console.WriteLine($"Qtde do produto abaixo do limite mínimo: {qtdEstoque}");
            }
            else
            {
                Console.WriteLine($"Quantidade suficiente para compra ");
            }
        }
    }
}
