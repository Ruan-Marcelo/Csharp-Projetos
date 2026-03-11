using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEncapsulamento.Classes
{
    internal class Alunos
    {
        private string codigo;
        private string nome;
        private float nota1;
        private float nota2;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                if (value.Count() <= 0)
                {
                    throw new Exception("O código não pode ser menor ou igual a 0.");
                }
                codigo = value;
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
                    throw new Exception("O nome não pode ser nulo");
                }

                nome = value; 
            }
        }

        public float Nota1
        {
            get 
            {
                return nota1; 
            }

            set 
            { 
                if(value < 0 || value > 10) 
                {
                    throw new Exception("Nota incorreta, a nota não pode ser menor que 0 e maior que 10");
                }

                nota1 = value;
            }
        }

        public float Nota2
        {
            get
            {
                return nota2;
            }

            set
            {
                if (value < 0 || value > 10)
                {
                    throw new Exception("Nota incorreta, a nota não pode ser menor que 0 e maior que 10");
                }

                nota2 = value;
            }
        }

    }
}
