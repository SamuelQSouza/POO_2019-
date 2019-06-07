namespace wfEmpregados
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsvlw = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.Label();
            this.buttonsalario = new System.Windows.Forms.Button();
            this.pesquisa = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resultscad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cadastrohrTxt = new System.Windows.Forms.TextBox();
            this.salarioCLTboxtxt = new System.Windows.Forms.TextBox();
            this.exHr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastroHrCK = new System.Windows.Forms.CheckBox();
            this.cadastroCTLCK = new System.Windows.Forms.CheckBox();
            this.cpfboxtxt = new System.Windows.Forms.TextBox();
            this.segundoNomeboxtxt = new System.Windows.Forms.TextBox();
            this.cadastroNomeboxtxt = new System.Windows.Forms.TextBox();
            this.cadastrobuttom = new System.Windows.Forms.Button();
            this.boxfunt = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.exnewvalor = new System.Windows.Forms.Label();
            this.testHrboxtext = new System.Windows.Forms.TextBox();
            this.testetextbox = new System.Windows.Forms.TextBox();
            this.ex3Horastest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxHrtest = new System.Windows.Forms.CheckBox();
            this.boxclttest = new System.Windows.Forms.CheckBox();
            this.Simular = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.boxfunt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.boxfunt);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.resultsvlw);
            this.tabPage1.Controls.Add(this.salario);
            this.tabPage1.Controls.Add(this.buttonsalario);
            this.tabPage1.Controls.Add(this.pesquisa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pesquise o CPF:";
            // 
            // resultsvlw
            // 
            this.resultsvlw.AutoSize = true;
            this.resultsvlw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsvlw.Location = new System.Drawing.Point(30, 205);
            this.resultsvlw.Name = "resultsvlw";
            this.resultsvlw.Size = new System.Drawing.Size(16, 15);
            this.resultsvlw.TabIndex = 3;
            this.resultsvlw.Text = "...";
            // 
            // salario
            // 
            this.salario.AutoSize = true;
            this.salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario.Location = new System.Drawing.Point(30, 146);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(178, 16);
            this.salario.TabIndex = 2;
            this.salario.Text = "Informações do empregado:";
            // 
            // buttonsalario
            // 
            this.buttonsalario.Location = new System.Drawing.Point(295, 102);
            this.buttonsalario.Name = "buttonsalario";
            this.buttonsalario.Size = new System.Drawing.Size(121, 20);
            this.buttonsalario.TabIndex = 1;
            this.buttonsalario.Text = "Pesquisar";
            this.buttonsalario.UseVisualStyleBackColor = true;
            this.buttonsalario.Click += new System.EventHandler(this.buttonsalario_Click);
            // 
            // pesquisa
            // 
            this.pesquisa.Location = new System.Drawing.Point(33, 76);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(383, 20);
            this.pesquisa.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resultscad);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cadastrohrTxt);
            this.tabPage2.Controls.Add(this.salarioCLTboxtxt);
            this.tabPage2.Controls.Add(this.exHr);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cadastroHrCK);
            this.tabPage2.Controls.Add(this.cadastroCTLCK);
            this.tabPage2.Controls.Add(this.cpfboxtxt);
            this.tabPage2.Controls.Add(this.segundoNomeboxtxt);
            this.tabPage2.Controls.Add(this.cadastroNomeboxtxt);
            this.tabPage2.Controls.Add(this.cadastrobuttom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(453, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // resultscad
            // 
            this.resultscad.AutoSize = true;
            this.resultscad.Location = new System.Drawing.Point(30, 282);
            this.resultscad.Name = "resultscad";
            this.resultscad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultscad.Size = new System.Drawing.Size(16, 13);
            this.resultscad.TabIndex = 13;
            this.resultscad.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sobre Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome: ";
            // 
            // cadastrohrTxt
            // 
            this.cadastrohrTxt.Location = new System.Drawing.Point(30, 238);
            this.cadastrohrTxt.Name = "cadastrohrTxt";
            this.cadastrohrTxt.Size = new System.Drawing.Size(166, 20);
            this.cadastrohrTxt.TabIndex = 9;
            this.cadastrohrTxt.Visible = false;
            // 
            // salarioCLTboxtxt
            // 
            this.salarioCLTboxtxt.Location = new System.Drawing.Point(30, 188);
            this.salarioCLTboxtxt.Name = "salarioCLTboxtxt";
            this.salarioCLTboxtxt.Size = new System.Drawing.Size(166, 20);
            this.salarioCLTboxtxt.TabIndex = 8;
            this.salarioCLTboxtxt.TextChanged += new System.EventHandler(this.salarioCLTboxtxt_TextChanged);
            // 
            // exHr
            // 
            this.exHr.AutoSize = true;
            this.exHr.Location = new System.Drawing.Point(27, 222);
            this.exHr.Name = "exHr";
            this.exHr.Size = new System.Drawing.Size(38, 13);
            this.exHr.TabIndex = 7;
            this.exHr.Text = "Horas:";
            this.exHr.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Salario:";
            // 
            // cadastroHrCK
            // 
            this.cadastroHrCK.AutoSize = true;
            this.cadastroHrCK.Location = new System.Drawing.Point(327, 240);
            this.cadastroHrCK.Name = "cadastroHrCK";
            this.cadastroHrCK.Size = new System.Drawing.Size(116, 17);
            this.cadastroHrCK.TabIndex = 5;
            this.cadastroHrCK.Text = "Empregado Horista";
            this.cadastroHrCK.UseVisualStyleBackColor = true;
            this.cadastroHrCK.CheckedChanged += new System.EventHandler(this.cadastroHrCK_CheckedChanged);
            // 
            // cadastroCTLCK
            // 
            this.cadastroCTLCK.AutoSize = true;
            this.cadastroCTLCK.Checked = true;
            this.cadastroCTLCK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cadastroCTLCK.Location = new System.Drawing.Point(340, 190);
            this.cadastroCTLCK.Name = "cadastroCTLCK";
            this.cadastroCTLCK.Size = new System.Drawing.Size(103, 17);
            this.cadastroCTLCK.TabIndex = 4;
            this.cadastroCTLCK.Text = "Empregado CLT";
            this.cadastroCTLCK.UseVisualStyleBackColor = true;
            this.cadastroCTLCK.CheckedChanged += new System.EventHandler(this.cadastroCTLCK_CheckedChanged);
            // 
            // cpfboxtxt
            // 
            this.cpfboxtxt.Location = new System.Drawing.Point(30, 139);
            this.cpfboxtxt.Name = "cpfboxtxt";
            this.cpfboxtxt.Size = new System.Drawing.Size(402, 20);
            this.cpfboxtxt.TabIndex = 3;
            // 
            // segundoNomeboxtxt
            // 
            this.segundoNomeboxtxt.Location = new System.Drawing.Point(30, 91);
            this.segundoNomeboxtxt.Name = "segundoNomeboxtxt";
            this.segundoNomeboxtxt.Size = new System.Drawing.Size(402, 20);
            this.segundoNomeboxtxt.TabIndex = 2;
            // 
            // cadastroNomeboxtxt
            // 
            this.cadastroNomeboxtxt.Location = new System.Drawing.Point(30, 40);
            this.cadastroNomeboxtxt.Name = "cadastroNomeboxtxt";
            this.cadastroNomeboxtxt.Size = new System.Drawing.Size(402, 20);
            this.cadastroNomeboxtxt.TabIndex = 1;
            // 
            // cadastrobuttom
            // 
            this.cadastrobuttom.Location = new System.Drawing.Point(351, 348);
            this.cadastrobuttom.Name = "cadastrobuttom";
            this.cadastrobuttom.Size = new System.Drawing.Size(92, 31);
            this.cadastrobuttom.TabIndex = 0;
            this.cadastrobuttom.Text = "Cadastrar";
            this.cadastrobuttom.UseVisualStyleBackColor = true;
            this.cadastrobuttom.Click += new System.EventHandler(this.cadastrobuttom_Click);
            // 
            // boxfunt
            // 
            this.boxfunt.Controls.Add(this.label7);
            this.boxfunt.Controls.Add(this.exnewvalor);
            this.boxfunt.Controls.Add(this.testHrboxtext);
            this.boxfunt.Controls.Add(this.testetextbox);
            this.boxfunt.Controls.Add(this.ex3Horastest);
            this.boxfunt.Controls.Add(this.label4);
            this.boxfunt.Controls.Add(this.boxHrtest);
            this.boxfunt.Controls.Add(this.boxclttest);
            this.boxfunt.Controls.Add(this.Simular);
            this.boxfunt.Location = new System.Drawing.Point(4, 22);
            this.boxfunt.Name = "boxfunt";
            this.boxfunt.Size = new System.Drawing.Size(453, 407);
            this.boxfunt.TabIndex = 2;
            this.boxfunt.Text = "Simulate";
            this.boxfunt.UseVisualStyleBackColor = true;
            this.boxfunt.Click += new System.EventHandler(this.boxHrtest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 50);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Valor da hora:";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // exnewvalor
            // 
            this.exnewvalor.AutoSize = true;
            this.exnewvalor.Location = new System.Drawing.Point(130, 239);
            this.exnewvalor.Name = "exnewvalor";
            this.exnewvalor.Size = new System.Drawing.Size(16, 13);
            this.exnewvalor.TabIndex = 7;
            this.exnewvalor.Text = "...";
            // 
            // testHrboxtext
            // 
            this.testHrboxtext.Location = new System.Drawing.Point(43, 121);
            this.testHrboxtext.Name = "testHrboxtext";
            this.testHrboxtext.Size = new System.Drawing.Size(305, 20);
            this.testHrboxtext.TabIndex = 6;
            this.testHrboxtext.Visible = false;
            // 
            // testetextbox
            // 
            this.testetextbox.Location = new System.Drawing.Point(43, 66);
            this.testetextbox.Name = "testetextbox";
            this.testetextbox.Size = new System.Drawing.Size(305, 20);
            this.testetextbox.TabIndex = 5;
            this.testetextbox.TextChanged += new System.EventHandler(this.testetextbox_TextChanged);
            // 
            // ex3Horastest
            // 
            this.ex3Horastest.AutoSize = true;
            this.ex3Horastest.Location = new System.Drawing.Point(44, 105);
            this.ex3Horastest.Name = "ex3Horastest";
            this.ex3Horastest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ex3Horastest.Size = new System.Drawing.Size(38, 13);
            this.ex3Horastest.TabIndex = 4;
            this.ex3Horastest.Text = "Horas:";
            this.ex3Horastest.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // boxHrtest
            // 
            this.boxHrtest.AutoSize = true;
            this.boxHrtest.Location = new System.Drawing.Point(232, 157);
            this.boxHrtest.Name = "boxHrtest";
            this.boxHrtest.Size = new System.Drawing.Size(116, 17);
            this.boxHrtest.TabIndex = 2;
            this.boxHrtest.Text = "Empregado Horista";
            this.boxHrtest.UseVisualStyleBackColor = true;
            this.boxHrtest.CheckedChanged += new System.EventHandler(this.boxHrtest_CheckedChanged);
            // 
            // boxclttest
            // 
            this.boxclttest.AutoSize = true;
            this.boxclttest.Checked = true;
            this.boxclttest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boxclttest.Location = new System.Drawing.Point(43, 157);
            this.boxclttest.Name = "boxclttest";
            this.boxclttest.Size = new System.Drawing.Size(103, 17);
            this.boxclttest.TabIndex = 1;
            this.boxclttest.Text = "Empregado CLT";
            this.boxclttest.UseVisualStyleBackColor = true;
            this.boxclttest.CheckedChanged += new System.EventHandler(this.boxclttest_CheckedChanged);
            // 
            // Simular
            // 
            this.Simular.Location = new System.Drawing.Point(273, 189);
            this.Simular.Name = "Simular";
            this.Simular.Size = new System.Drawing.Size(75, 23);
            this.Simular.TabIndex = 0;
            this.Simular.Text = "Simulate";
            this.Simular.UseVisualStyleBackColor = true;
            this.Simular.Click += new System.EventHandler(this.Simular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 433);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Empregados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.boxfunt.ResumeLayout(false);
            this.boxfunt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label resultsvlw;
        private System.Windows.Forms.Label salario;
        private System.Windows.Forms.Button buttonsalario;
        private System.Windows.Forms.TextBox pesquisa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cadastrohrTxt;
        private System.Windows.Forms.TextBox salarioCLTboxtxt;
        private System.Windows.Forms.Label exHr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cadastroHrCK;
        private System.Windows.Forms.CheckBox cadastroCTLCK;
        private System.Windows.Forms.TextBox cpfboxtxt;
        private System.Windows.Forms.TextBox segundoNomeboxtxt;
        private System.Windows.Forms.TextBox cadastroNomeboxtxt;
        private System.Windows.Forms.Button cadastrobuttom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage boxfunt;
        private System.Windows.Forms.TextBox testetextbox;
        private System.Windows.Forms.Label ex3Horastest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox boxHrtest;
        private System.Windows.Forms.CheckBox boxclttest;
        private System.Windows.Forms.Button Simular;
        private System.Windows.Forms.Label exnewvalor;
        private System.Windows.Forms.TextBox testHrboxtext;
        private System.Windows.Forms.Label resultscad;
        private System.Windows.Forms.Label label7;
    }
}

