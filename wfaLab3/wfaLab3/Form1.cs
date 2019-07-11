using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Fernando Henrique da Cruz
 * 11551ECP008*/

namespace LAB3_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Aluno> listaAlunos = new List<Aluno>();
        List<Materia> listaMaterias = new List<Materia>();

        String nome_aluno, matricula;
        int periodo;

        String nome_materia, codigo_materia;

        Aluno aL;
        Materia mL;

        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos)
        {
            Aluno achei_aluno = null;
            for (int i = 0; i < alunos.Count(); i++)
            {
                if (nome_aluno == alunos[i].getNome())
                {
                    achei_aluno = alunos[i];
                    break;
                }
            }
            return achei_aluno;
        }

        static Materia achaMateria(String nome_materia, List<Materia> materias)
        {
            Materia achei_materia = null;

            for (int i = 0; i < materias.Count(); i++)
            {
                if (nome_materia == materias[i].Nome)
                {
                    achei_materia = materias[i];
                    break;
                }
            }
            return achei_materia;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btProcurarAluno_Click(object sender, EventArgs e)
        {
            nome_aluno = tbListaAluno.Text;
            aL = achaAluno(nome_aluno, listaAlunos);
        }

        private void btAssociar_Click(object sender, EventArgs e)
        {
            aL.associaMateria(mL);
            tbListaAluno.Clear();
            tbListaMateria.Clear();
        }

        private void btCadastrarMateria_Click(object sender, EventArgs e)
        {
            nome_materia = tbDisciplina.Text;
            codigo_materia = tbCodigo.Text;

            Materia a = new Materia(nome_materia, codigo_materia);
            listaMaterias.Add(a);

            tbDisciplina.Clear();
            tbCodigo.Clear();
        }

        private void lbListaAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMaterias.Clear();
            Aluno a1 = listaAlunos[cbAluno.SelectedIndex];

            for (int n = 0; n < listaMaterias.Count; n++)
            {
                Materia temp = a1.Lista_materias[n];
                lvMaterias.Items.Add(temp.Nome);
            }
            
        }

        private void lvMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabAluno_Click(object sender, EventArgs e)
        {

        }

        private void btProcurarMateria_Click(object sender, EventArgs e)
        {
            nome_materia = tbListaMateria.Text;
            mL = achaMateria(nome_materia, listaMaterias);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            nome_aluno = tbNome.Text;
            matricula = tbNrMat.Text;
            periodo = Convert.ToInt32(tbPeriodo.Text);

            Aluno a = new Aluno(nome_aluno, matricula, periodo);
            listaAlunos.Add(a);
            cbAluno.Items.Add(a.getNome());

            tbNome.Clear();
            tbNrMat.Clear();
            tbPeriodo.Clear();

        }
    }
}
