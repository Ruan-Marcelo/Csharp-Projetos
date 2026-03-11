using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEncapsulamento.Classes
{
    internal class Carpete
    {   //atributos
        private float comprimento;
        private float largura;

        //métodos
        public void ConfigurarDados(float comp, float larg)
        {
            comprimento = comp; 
            largura = larg;
        }

        public void CalcularArea()
        {
            float area;

            area = comprimento * largura;

            Console.WriteLine($"Área: {area}");

        }

        public float CalcularTotalCompra(float preco, float qtde)
        {
            float totalCompra;

            totalCompra = preco * qtde ;

            return totalCompra;
        }

        public float CalcularTroco(float totalCompra, float pagamento)
        {
            float troco;

            troco = pagamento - totalCompra;

            return troco;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Comprimento: {comprimento}");
            Console.WriteLine($"Largura: {largura}");

        }

    }
}
