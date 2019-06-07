using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPilhaDinamica
{
    public partial class Form1 : Form
    {
        Pilha p = new Pilha();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}
        private void label2_Click(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e){}

        private void btPush_Click(object sender, EventArgs e)
        {
            int Value = Convert.ToInt32(tbValor.Text);
            p.push(Value);
            tbValor.Text = null;
            tbValor.Focus();
        }
        private void btPrint_Click(object sender, EventArgs e)
        {
            lbPilha.Text = "pilha:";
            tbPilha.Lines = p.print().Split();
            tbValor.Focus();
        }
        private void btPop_Click(object sender, EventArgs e)
        {
            lbPilha.Text = "Elemento removido da pilha:";
            tbPilha.Text = p.pop();
            tbValor.Focus();
        }
        private void btMaior_Click(object sender, EventArgs e)
        {
            lbPilha.Text = "maior elemento da pilha:";
            tbPilha.Text = p.Maior();
        }
        private void btMenor_Click(object sender, EventArgs e)
        {
            lbPilha.Text = "Menor elemento da pilha:";
            tbPilha.Text = p.Menor();
            tbValor.Focus();
        }
        private void btInverte_Click(object sender, EventArgs e)
        {
            lbPilha.Text = "pilha invertida:";
            tbPilha.Lines = p.inverte().print().Split();
            tbValor.Focus();
        }

        private void tbValor_KeyUp(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if(key == 13)
                push_func();
        }
        private void push_func()
        {
            try
            { 
                int Value = Convert.ToInt32(tbValor.Text);
                p.push(Value);
            }
            catch { }
            
            tbValor.Text = null;
            tbValor.Focus();
        }
    }
}