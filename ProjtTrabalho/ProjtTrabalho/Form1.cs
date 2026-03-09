using ProjtTrabalho.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjtTrabalho
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

        private void btnAluno_Click(object sender, EventArgs e)
        {
            Aula o_Mat = new Aula();
            o_Mat.HoraAula = DateTime.Now;
            o_Mat.NumSala = 10;
            o_Mat.DiasSemana = "Terça";

            Aula o_Por = new Aula();
            o_Por.HoraAula = DateTime.Now;
            o_Por.NumSala = 13;
            o_Por.DiasSemana = "Sexta";

            Aula o_Qui = new Aula();
            o_Qui.HoraAula = DateTime.Now;
            o_Qui.NumSala = 43;
            o_Qui.DiasSemana = "Quinta";


            Aluno o_Jorge = new Aluno();
            o_Jorge.RnAluno = 245;
            o_Jorge.NomeEscola = "Sesi Cat";
            o_Jorge.Serie = "2B";
            o_Jorge.roupas("Uniforme");
            o_Jorge.Aulas.Add(o_Mat);
            o_Jorge.Aulas.Add(o_Qui);
            o_Jorge.Imprimir();

            Aluno o_Ruan = new Aluno();
            o_Ruan.RnAluno = 434;
            o_Ruan.NomeEscola = "Sesi Vila";
            o_Ruan.Serie = "3B";
            o_Ruan.roupas("Uniforme");
            o_Ruan.Aulas.Add(o_Por);
            o_Ruan.Aulas.Add(o_Mat);
            o_Ruan.Imprimir();

            Aluno o_Luiz = new Aluno();
            o_Luiz.RnAluno = 345;
            o_Luiz.NomeEscola = "Sesi Planalto";
            o_Luiz.Serie = "1B";
            o_Luiz.roupas("Uniforme");
            o_Luiz.Aulas.Add(o_Qui);
            o_Luiz.Aulas.Add(o_Por);
            o_Luiz.Imprimir();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            
            Disciplina o_Mat = new Disciplina();
            o_Mat.NomeDis = "Matemática";
            o_Mat.CargaHora = 25.80f;
            o_Mat.




            Professor o_Gustavo = new Professor();
            o_Gustavo.IdProfessor = 983;
            o_Gustavo.DataNasc = new DateTime(1997, 3, 10, 0, 5, 0);
            o_Gustavo.NomeEscola = "Sesi Cat";
            o_Gustavo.Imprimir();
            o_Gustavo.roupas("Esporte Fino");

            Professor o_Camila = new Professor();
            o_Camila.IdProfessor = 645;
            o_Camila.DataNasc = new DateTime(1987, 3, 10, 0, 5, 0);
            o_Camila.NomeEscola = "Sesi Vila";
            o_Camila.Imprimir();
            o_Camila.roupas("Lazer");

            Professor o_Pedro = new Professor();
            o_Pedro.IdProfessor = 133;
            o_Pedro.DataNasc = new DateTime(1999, 3, 10, 0, 5, 0);
            o_Pedro.NomeEscola = "Sesi Planalto";
            o_Pedro.Imprimir();
            o_Pedro.roupas("Uniforme");
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            Administrativo o_Diretor = new Administrativo();
            o_Diretor.IdAdm = 2344;
            o_Diretor.Cargo = "Diretor do Castelo Branco";
            o_Diretor.Admissao = DateTime.Now;
            o_Diretor.Imprimir();
            o_Diretor.roupas("Vestido");

            Administrativo o_Diretor2 = new Administrativo();
            o_Diretor2.IdAdm = 2744;
            o_Diretor2.Cargo = "Diretor do Vila Recreio";
            o_Diretor2.Admissao = DateTime.Now;
            o_Diretor2.Imprimir();
            o_Diretor2.roupas("Terno");

            Administrativo o_Diretor3 = new Administrativo();
            o_Diretor3.IdAdm = 3573;
            o_Diretor3.Cargo = "Diretor do Planalto Verde";
            o_Diretor3.Admissao = DateTime.Now;
            o_Diretor3.Imprimir();
            o_Diretor3.roupas("Uniforme");
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
           Disciplina o_Disciplinas = new Disciplina();
           o_Disciplinas.NomeDis = "Mátematica";
           o_Disciplinas.CargaHora = 14.05f;
           o_Disciplinas.IdProfessor = 645;

            Aula o_Aula = new Aula();
            o_Aula.HoraAula = DateTime.Now;
            o_Aula.NumSala = 144;
            o_Aula.DiasSemana = "Sabado";
            o_Aula.Disciplinas[0] = o_Disciplinas;
            o_Aula.Imprimir();

        }
    }
}
