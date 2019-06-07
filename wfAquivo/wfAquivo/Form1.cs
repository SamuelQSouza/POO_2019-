using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wfArquivo
{
   
    public partial class laboratorio : Form
    {
        public laboratorio()
        {
            InitializeComponent();

            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (textfile.Text != "" && buscafile.Text != "")
            {
                switch (MessageBox.Show(this, "Deseja salva o arquivo?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        using (StreamWriter outputFile = new StreamWriter(buscafile.Text))
                        {
                            outputFile.WriteLine(textfile.Text);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }

            }
            Application.Exit();

        }
        private void Form1_Load(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {   
                using (StreamReader sr = new StreamReader(buscafile.Text))
                {
                    String line = sr.ReadToEnd();
                    textfile.Text = line;
                }
            }
            catch (IOException er)
            {
                Console.WriteLine("No encontrado!");
                Console.WriteLine(er.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter(buscafile.Text))
            {
                outputFile.WriteLine(textfile.Text);
            }
        }
    }
}
