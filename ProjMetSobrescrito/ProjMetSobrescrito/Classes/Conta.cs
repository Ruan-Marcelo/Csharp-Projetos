using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMetSobrescrito.Classes
{
    internal class Conta
    {
        //Atributos 
        protected int nroConta;
        protected string nomeCliente;
        protected float saldoConta;

        //Propriedades
        public int NroConta
        {
            get { return nroConta; }
            set { nroConta = value; }
        }
        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }
        public float SaldoConta
        {
            get { return saldoConta; }
            set { saldoConta = value; }
        }

        //Métodos
        public void EfetuarDeposito(float deposito)
        {
            saldoConta += deposito ;
            Console.WriteLine($"Quantia Depositada: {deposito}");
            Console.WriteLine($"Saldo da conta Após deposito: {saldoConta}");
        }
        public virtual void EfetuarSaque(float saque)
        {
            
            if(saque > saldoConta)
            {
                Console.WriteLine($"{nomeCliente} não pode sacar");
            }
            else
            {
                saldoConta -= saque;
                Console.WriteLine($"Quantia Sacada: {saque}");
                Console.WriteLine($"Saldo da conta Após Saque: {saldoConta}");
            }
           
        }
        public void ImprimirDados()
        {
            Console.WriteLine($"Número da Conta: {nroConta}");
            Console.WriteLine($"Nome do Cliente: {nomeCliente}");
            Console.WriteLine($"Saldo do Cliente: {saldoConta}");
        }


    }
}
