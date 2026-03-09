using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEncapsulamento.Classes
{
    internal class Aluno
    {
        private double notaP2;
        private double notaP1;
        private string nome;
        private int codigo;

        public int Codigo
        {
            get
            {
               return codigo;
            }

            set
            {
                if (value <= 0 )
                {

                    throw new Exception("O código do aluno não pode ser menor ou igual a zero.");
                }
                else
                {
                    codigo = value;
                }

            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new Exception("O nome não pode ser nulo.");
                }
                else
                {
                    nome = value;
                }

            }

        }

        public double NotaP2
        {
            get
            {
                return notaP2;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new Exception("A nota P2 não pode ser menor que zero e maior que 10");
                }
                else
                {
                    notaP2 = value;
                }
            }
        }
        public double NotaP1
        {
            get
            {
                return notaP1;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new Exception("A nota P1 não pode ser menor que zero e maior que 10");
                }
                else
                {
                    notaP1 = value;
                }
            }
        }
    }
}
