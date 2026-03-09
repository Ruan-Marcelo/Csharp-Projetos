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
    public partial class infoAlunos : Form
    {
        public infoAlunos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
       private void btnAluno_Click(object sender, EventArgs e)
        {

            Aluno o_aluno = new Aluno();

            try
            {
                o_aluno.Nome = "";

                Console.WriteLine($"Nome do Usuário: { o_aluno.Nome}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            Aluno o_aluno = new Aluno();
            try
            {

                o_aluno.Codigo = 0;


                Console.WriteLine($"Código do Aluno: {o_aluno.Codigo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNotap1_Click(object sender, EventArgs e)
        {
            Aluno o_aluno = new Aluno();
            try
            {

                o_aluno.NotaP1 = 11;

                Console.WriteLine($"NotaP1: {o_aluno.NotaP1}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNotap2_Click(object sender, EventArgs e)
        {
            Aluno o_aluno = new Aluno();
            try
            {
                o_aluno.NotaP2 = 11;

                Console.WriteLine($"NotaP2: {o_aluno.NotaP2}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
