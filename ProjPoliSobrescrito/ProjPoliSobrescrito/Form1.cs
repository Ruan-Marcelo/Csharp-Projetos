using ProjPoliSobrescrito.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjPoliSobrescrito
{
    public partial class Form1 : frmPrincipal
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSobrescrito_Click(object sender, EventArgs e)
        {
            Pessoa O_Pessoa = new Pessoa();
            O_Pessoa.idPessoa = 100;
            O_Pessoa.nome = "Xablau";
            O_Pessoa.senha = "xablau123";
            O_Pessoa.contato = "4002-8922";

            O_Pessoa.Imprimir();


        }

        private void btnSobrescrita2_Click(object sender, EventArgs e)
        {
            Vendedor o_Vendedor = new Vendedor();

            o_Vendedor.idPessoa = 200;
            o_Vendedor.nome = "El mui macho";
            o_Vendedor.senha = "MakeItAL";
            o_Vendedor.contato = "69696969";
            o_Vendedor.qtdVenda = 1533;
            o_Vendedor.setor = "Provador de xere";
            o_Vendedor.comissao = 10.99f;
            o_Vendedor.Imprimir();



        }
    }
}
