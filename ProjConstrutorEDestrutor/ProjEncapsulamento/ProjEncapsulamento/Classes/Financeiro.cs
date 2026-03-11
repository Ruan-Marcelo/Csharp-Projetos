using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEncapsulamento.Classes
{
    internal class Financeiro
    {
        //atributos
        private float saldoCaixa;
        private DateTime inicioAcesso;
        private DateTime fimAcesso;

        //métodos
        //Construtor
        public Financeiro()
        {
            inicioAcesso = DateTime.Now;
        }

        //propriedades
        public float Saldocaixa
        {
            get
            {
                return saldoCaixa;
            }
            set
            {
                saldoCaixa = value;
            }
        }

        //Método
        public void Imprimir()
        {
            Console.WriteLine($"Saldo: {saldoCaixa}");
            Console.WriteLine($"Início: {inicioAcesso.ToString()}");
            Console.WriteLine($"Fim: {fimAcesso.ToString()}");
        }


        //Destrutor
        ~Financeiro()
        {
            fimAcesso = DateTime.Now;
            Console.WriteLine($"Fim: {fimAcesso.ToString()}");
        }
    }
}
