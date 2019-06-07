using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfTestMatExp
{
    public partial class Form1 : Form
    {
        Pilha p = new Pilha();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private string verify()
        {
            int i = 0;
            char[] a = tbExp.Text.ToCharArray();
            while (i < a.Length)
            {
                if (a[i] == '{' | a[i] == '[' | a[i] == '(')
                {
                    p.push(a[i]);
                }
                else if ((a[i] == '}' || a[i] == ']' || a[i] == ')') && p.Topo == null)
                {
                    return "Errrrouuuu!";
                }
                else if (a[i] == '}' && p.Topo.Data == '{' || a[i] == ']' && p.Topo.Data == '[' || a[i] == ')' && p.Topo.Data == '(')
                    {
                        if (p.Topo != null)
                            p.pop();
                    }
                
                i++;
            }
        
            if (p.Topo == null)
            {
                return "ah bom! Expressão ok!";
            }
            else
            {
                return "Errrrouuuu!";
            }
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            input();

        }
        private void tbValor_KeyUp(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if (key == 13)
                input();
        }
        private void input()
        {
            lbOut.Visible = true;
            lbOut.Text = verify();
            tbExp.Text = null;
            tbExp.Focus();
        }
    }
}
