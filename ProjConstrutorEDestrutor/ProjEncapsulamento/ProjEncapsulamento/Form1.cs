using ProjEncapsulamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjEncapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario o_Usuario = new Usuario();
                o_Usuario.nome = "Marcola";
                o_Usuario.Senha = "123456";
                o_Usuario.AnoNasc = 2533;

                Console.WriteLine($"Nome do Usuário: { o_Usuario.nome}");
                Console.WriteLine($"Senha do Usuário: { o_Usuario.Senha}");
                Console.WriteLine($"Ano de nascimento: {o_Usuario.AnoNasc}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            try
            {
                int valor;
                int resultado;

                valor = 100;

                resultado = valor / 0;

                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }

            
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            
            try
            {
                Alunos o_alunos = new Alunos();
                o_alunos.Nome = "Lucas";
                o_alunos.Codigo = "2024";
                o_alunos.Nota1 = 11f;
                o_alunos.Nota2 = 7.5f;

                Console.WriteLine($"Nome do aluno: {o_alunos.Nome}");
                Console.WriteLine($"Codigo do aluno: {o_alunos.Codigo}");
                Console.WriteLine($"1ª nota do aluno: {o_alunos.Nota1}");
                Console.WriteLine($"2ª nota do aluno: {o_alunos.Nota2}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            Carpete o_carpete = new Carpete();

            float totalCompra;
            float troco;

            o_carpete.ConfigurarDados(10f, 10f);

            o_carpete.Imprimir();

            o_carpete.CalcularArea();

            totalCompra = o_carpete.CalcularTotalCompra(100f, 5);


            Console.WriteLine($"Total: {totalCompra}");

            troco = o_carpete.CalcularTroco(79.8f, 100f);

            Console.WriteLine($"Troco: {troco}");
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {

            Livro o_livro = new Livro();

            float totalDesconto;

            o_livro.Titulo = "Cabras da peste";
            o_livro.Preco = 100f;

            totalDesconto = o_livro.EfetuarDesconto(20);

            o_livro.ImprimirDAdos();

            Console.WriteLine($"Preço com desconto: {totalDesconto}");

            o_livro.EfetuarVenda(20);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConstrutor_Click(object sender, EventArgs e)
        {
            Financeiro o_Financeiro = new Financeiro();
            float saldo = 1000;

            o_Financeiro.Saldocaixa = saldo; 
            o_Financeiro.Imprimir();
        }
        Produto o_Produto = new Produto();
        private void btnProduto_Click(object sender, EventArgs e)
        {
               o_Produto.CodProduto = 1533;
                o_Produto.Preco = 22;
                o_Produto.Descricao = "Bolsonaro";
                o_Produto.Imprimir();

                o_Produto.AumentarPreco(5.0f);

                o_Produto.CalcularImpostos(9.0f);

                o_Produto.VendaProduto(7);
        }
    }
}
