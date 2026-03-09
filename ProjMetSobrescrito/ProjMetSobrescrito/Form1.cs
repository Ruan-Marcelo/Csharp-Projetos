using ProjMetSobrescrito.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjMetSobrescrito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Conta o_Conta = new Conta();
        ContaEspecial contaEspecial = new ContaEspecial();
        private void btnSaqueEspecial_Click(object sender, EventArgs e)
        {
            contaEspecial.LimiteCta = 1000f;
            contaEspecial.EfetuarSaque(100f);

        }
        private void btnSaque_Click(object sender, EventArgs e)
        {
            o_Conta.EfetuarSaque(100f);

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {  
            o_Conta.EfetuarDeposito(100f);
        }

        private void btnDdos_Click(object sender, EventArgs e)
        {
            o_Conta.NroConta = 1533;
            o_Conta.NomeCliente = "El muio macho alfa mega omega";
            o_Conta.ImprimirDados();
        }
    }
}
