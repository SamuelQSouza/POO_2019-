using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfEmpregados
{ 

    public partial class Form1 : Form
    {
        List<Empregado> empregadoslist = new List<Empregado>();
        public Form1()
        {
            InitializeComponent();
        }
        private void cadastroCTLCK_CheckedChanged(object sender, EventArgs e)
        {
            if (cadastroCTLCK.Checked)
            {
                cadastrohrTxt.Visible = false;
                exHr.Visible = false;
                cadastroHrCK.Checked = false;
            }
            else
                cadastroHrCK.Checked = true;

        }

        private void cadastroHrCK_CheckedChanged(object sender, EventArgs e)
        {
            if (cadastroHrCK.Checked)
            {
                exHr.Visible = true;
                cadastrohrTxt.Visible = true;
                cadastroCTLCK.Checked = false;
            }
            else
                cadastroCTLCK.Checked = true;

        }

        private void cadastrobuttom_Click(object sender, EventArgs e)
        {
            if (cadastroCTLCK.Checked)
            {
                double sal = 0.0;
                if (salarioCLTboxtxt.Text != "")
                    sal = Convert.ToDouble(salarioCLTboxtxt.Text);
                Empregado em1 = new EmpregadoCLT(cadastroNomeboxtxt.Text, segundoNomeboxtxt.Text, cpfboxtxt.Text, sal);
                empregadoslist.Add(em1);
                resultscad.Text = "0K";
            }
            else
            {
                double nro = 0.0;
                double qre = 0.0;
                if (salarioCLTboxtxt.Text != "")
                    nro = Convert.ToDouble(salarioCLTboxtxt.Text);
                if (cadastrohrTxt.Text != "")
                    qre = Convert.ToDouble(cadastrohrTxt.Text);
                Empregado em1 = new EmpregadoHorista(cadastroNomeboxtxt.Text, segundoNomeboxtxt.Text, cpfboxtxt.Text, nro, qre);
                empregadoslist.Add(em1);
                resultscad.Text = "OK";

            }
        }

        private void buttonsalario_Click(object sender, EventArgs e)
        {
            int j = empregadoslist.Count;
            for (int i = 0; i <= j; i++)
            {
                if (string.Equals(empregadoslist[i].getcpf(),pesquisa.Text))
                {
                    resultsvlw.Text = "R$ " + empregadoslist[i].getSalLiquido();
                    break;
                }
            }
        }

        private void Simular_Click(object sender, EventArgs e)
        {
            if (boxclttest.Checked)
            {

                double salario = 0.0;
                if (testetextbox.Text != "")
                    salario = Convert.ToDouble(testetextbox.Text);
                if (salario >= 4000.0)
                    exnewvalor.Text = "R$ " + Convert.ToString(salario + salario * 0.275);
                else
                    exnewvalor.Text = "R$ " + Convert.ToString(salario + salario * 0.15);
            }
            else
            {
                double nro = 0.0;
                double qte = 0.0;
                double salario = 0.0;
                if (testetextbox.Text != "")
                    nro = Convert.ToDouble(testetextbox.Text);
                if (testHrboxtext.Text != "")
                    qte = Convert.ToDouble(testHrboxtext.Text);
                salario = qte * nro;
                exnewvalor.Text = "R$ " + Convert.ToString(salario - salario * 0.15);
            }
        }

        private void boxclttest_CheckedChanged(object sender, EventArgs e)
        {
            if (boxclttest.Checked)
            {
                ex3Horastest.Visible = false;
                testHrboxtext.Visible = false;
                boxHrtest.Checked = false;
            }
            else
                boxHrtest.Checked = true;

        }

        private void boxHrtest_CheckedChanged(object sender, EventArgs e)
        {
            if (boxHrtest.Checked)
            {
                ex3Horastest.Visible = true;
                testHrboxtext.Visible = true;
                boxclttest.Checked = false;
            }
            else
                boxclttest.Checked = true;
        }

        private void boxHrtest_Click(object sender, EventArgs e){}

        private void salarioCLTboxtxt_TextChanged(object sender, EventArgs e){}

        private void testetextbox_TextChanged(object sender, EventArgs e){}

        private void label7_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
}