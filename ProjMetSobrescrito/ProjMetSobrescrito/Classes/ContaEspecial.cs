using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMetSobrescrito.Classes
{
    internal class ContaEspecial : Conta
    {
        //Atributos 
        private float limiteCta;

        //Propiredades
        public float LimiteCta
        {
            get { return limiteCta; }
            set { limiteCta = value; }
        }

        //Construtor
        
        //Métodos
        public override void EfetuarSaque(float saque)
        {
            limiteCta += saldoConta;
            if (saque > limiteCta)
            {
                Console.WriteLine($"{NomeCliente} não pode sacar pois o limite ja foi atingido");
            }
            else
            {
                saldoConta -= saque;
                Console.WriteLine($"Quantia Sacada: {saque}");
                Console.WriteLine($"Saldo da conta Após Saque: {saldoConta}");
            }

        }
    }
}
