using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEncapsulamento.Classes
{
    internal class Usuario
    {
        //atributos
        public string nome;
        private string senha;
        private int anoNasc;

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                if (value.Count() < 6)
                {
                    throw new Exception("A senha não pode ter menos de 6 caracteres.");
                }

                senha = value;
            }
        }

        public int AnoNasc
        {
            get
            {
                return anoNasc;
            }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new Exception("Ano de nascimento não pode ser maior que o ano atual");
                }
                anoNasc = value;
            }
        }

    }
}
