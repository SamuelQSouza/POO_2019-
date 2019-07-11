namespace LAB3_POO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tabControl1;
            this.tabAluno = new System.Windows.Forms.TabPage();
            this.btProcurarMateria = new System.Windows.Forms.Button();
            this.tbListaMateria = new System.Windows.Forms.TextBox();
            this.btProcurarAluno = new System.Windows.Forms.Button();
            this.tbListaAluno = new System.Windows.Forms.TextBox();
            this.btAssociar = new System.Windows.Forms.Button();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelAluno = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbPeriodo = new System.Windows.Forms.TextBox();
            this.tbNrMat = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.labelNrMat = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.tabMateria = new System.Windows.Forms.TabPage();
            this.btCadastrarMateria = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbDisciplina = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.lvMaterias = new System.Windows.Forms.ListView();
            this.cbAluno = new System.Windows.Forms.ComboBox();
            this.labelListaMaterias = new System.Windows.Forms.Label();
            this.labeListaAluno = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.tabAluno.SuspendLayout();
            this.tabMateria.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tabAluno);
            tabControl1.Controls.Add(this.tabMateria);
            tabControl1.Controls.Add(this.tabRelatorio);
            tabControl1.Location = new System.Drawing.Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(567, 327);
            tabControl1.TabIndex = 0;
            // 
            // tabAluno
            // 
            this.tabAluno.Controls.Add(this.btProcurarMateria);
            this.tabAluno.Controls.Add(this.tbListaMateria);
            this.tabAluno.Controls.Add(this.btProcurarAluno);
            this.tabAluno.Controls.Add(this.tbListaAluno);
            this.tabAluno.Controls.Add(this.btAssociar);
            this.tabAluno.Controls.Add(this.labelMateria);
            this.tabAluno.Controls.Add(this.labelAluno);
            this.tabAluno.Controls.Add(this.btCadastrar);
            this.tabAluno.Controls.Add(this.tbPeriodo);
            this.tabAluno.Controls.Add(this.tbNrMat);
            this.tabAluno.Controls.Add(this.tbNome);
            this.tabAluno.Controls.Add(this.labelPeriodo);
            this.tabAluno.Controls.Add(this.labelNrMat);
            this.tabAluno.Controls.Add(this.labelNome);
            this.tabAluno.Location = new System.Drawing.Point(4, 22);
            this.tabAluno.Name = "tabAluno";
            this.tabAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tabAluno.Size = new System.Drawing.Size(559, 301);
            this.tabAluno.TabIndex = 0;
            this.tabAluno.Text = "Aluno";
            this.tabAluno.UseVisualStyleBackColor = true;
            this.tabAluno.Click += new System.EventHandler(this.tabAluno_Click);
            // 
            // btProcurarMateria
            // 
            this.btProcurarMateria.Location = new System.Drawing.Point(76, 239);
            this.btProcurarMateria.Name = "btProcurarMateria";
            this.btProcurarMateria.Size = new System.Drawing.Size(75, 23);
            this.btProcurarMateria.TabIndex = 15;
            this.btProcurarMateria.Text = "Procurar";
            this.btProcurarMateria.UseVisualStyleBackColor = true;
            this.btProcurarMateria.Click += new System.EventHandler(this.btProcurarMateria_Click);
            // 
            // tbListaMateria
            // 
            this.tbListaMateria.Location = new System.Drawing.Point(76, 213);
            this.tbListaMateria.Name = "tbListaMateria";
            this.tbListaMateria.Size = new System.Drawing.Size(446, 20);
            this.tbListaMateria.TabIndex = 14;
            // 
            // btProcurarAluno
            // 
            this.btProcurarAluno.Location = new System.Drawing.Point(76, 181);
            this.btProcurarAluno.Name = "btProcurarAluno";
            this.btProcurarAluno.Size = new System.Drawing.Size(75, 23);
            this.btProcurarAluno.TabIndex = 13;
            this.btProcurarAluno.Text = "Procurar";
            this.btProcurarAluno.UseVisualStyleBackColor = true;
            this.btProcurarAluno.Click += new System.EventHandler(this.btProcurarAluno_Click);
            // 
            // tbListaAluno
            // 
            this.tbListaAluno.Location = new System.Drawing.Point(76, 155);
            this.tbListaAluno.Name = "tbListaAluno";
            this.tbListaAluno.Size = new System.Drawing.Size(446, 20);
            this.tbListaAluno.TabIndex = 12;
            // 
            // btAssociar
            // 
            this.btAssociar.Location = new System.Drawing.Point(381, 268);
            this.btAssociar.Name = "btAssociar";
            this.btAssociar.Size = new System.Drawing.Size(141, 23);
            this.btAssociar.TabIndex = 11;
            this.btAssociar.Text = "Associar";
            this.btAssociar.UseVisualStyleBackColor = true;
            this.btAssociar.Click += new System.EventHandler(this.btAssociar_Click);
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(25, 220);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(45, 13);
            this.labelMateria.TabIndex = 9;
            this.labelMateria.Text = "Matéria:";
            this.labelMateria.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelAluno
            // 
            this.labelAluno.AutoSize = true;
            this.labelAluno.Location = new System.Drawing.Point(25, 162);
            this.labelAluno.Name = "labelAluno";
            this.labelAluno.Size = new System.Drawing.Size(37, 13);
            this.labelAluno.TabIndex = 7;
            this.labelAluno.Text = "Aluno:";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(381, 110);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(141, 32);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(76, 84);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(446, 20);
            this.tbPeriodo.TabIndex = 5;
            // 
            // tbNrMat
            // 
            this.tbNrMat.Location = new System.Drawing.Point(76, 56);
            this.tbNrMat.Name = "tbNrMat";
            this.tbNrMat.Size = new System.Drawing.Size(446, 20);
            this.tbNrMat.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(76, 27);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(446, 20);
            this.tbNome.TabIndex = 3;
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Location = new System.Drawing.Point(21, 87);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(48, 13);
            this.labelPeriodo.TabIndex = 2;
            this.labelPeriodo.Text = "Período:";
            // 
            // labelNrMat
            // 
            this.labelNrMat.AutoSize = true;
            this.labelNrMat.Location = new System.Drawing.Point(21, 59);
            this.labelNrMat.Name = "labelNrMat";
            this.labelNrMat.Size = new System.Drawing.Size(55, 13);
            this.labelNrMat.TabIndex = 1;
            this.labelNrMat.Text = "Matrícula:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(21, 30);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(41, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome: ";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabMateria
            // 
            this.tabMateria.Controls.Add(this.btCadastrarMateria);
            this.tabMateria.Controls.Add(this.tbCodigo);
            this.tabMateria.Controls.Add(this.tbDisciplina);
            this.tabMateria.Controls.Add(this.labelCodigo);
            this.tabMateria.Controls.Add(this.labelDisciplina);
            this.tabMateria.Location = new System.Drawing.Point(4, 22);
            this.tabMateria.Name = "tabMateria";
            this.tabMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tabMateria.Size = new System.Drawing.Size(559, 301);
            this.tabMateria.TabIndex = 1;
            this.tabMateria.Text = "Materia";
            this.tabMateria.UseVisualStyleBackColor = true;
            // 
            // btCadastrarMateria
            // 
            this.btCadastrarMateria.Location = new System.Drawing.Point(420, 230);
            this.btCadastrarMateria.Name = "btCadastrarMateria";
            this.btCadastrarMateria.Size = new System.Drawing.Size(94, 32);
            this.btCadastrarMateria.TabIndex = 4;
            this.btCadastrarMateria.Text = "Cadastrar";
            this.btCadastrarMateria.UseVisualStyleBackColor = true;
            this.btCadastrarMateria.Click += new System.EventHandler(this.btCadastrarMateria_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(123, 55);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(391, 20);
            this.tbCodigo.TabIndex = 3;
            // 
            // tbDisciplina
            // 
            this.tbDisciplina.Location = new System.Drawing.Point(87, 17);
            this.tbDisciplina.Name = "tbDisciplina";
            this.tbDisciplina.Size = new System.Drawing.Size(427, 20);
            this.tbDisciplina.TabIndex = 2;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(26, 58);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(91, 13);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Código Disciplina:";
            this.labelCodigo.Click += new System.EventHandler(this.labelCodigo_Click);
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Location = new System.Drawing.Point(26, 20);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(55, 13);
            this.labelDisciplina.TabIndex = 0;
            this.labelDisciplina.Text = "Disciplina:";
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.lvMaterias);
            this.tabRelatorio.Controls.Add(this.cbAluno);
            this.tabRelatorio.Controls.Add(this.labelListaMaterias);
            this.tabRelatorio.Controls.Add(this.labeListaAluno);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(559, 301);
            this.tabRelatorio.TabIndex = 2;
            this.tabRelatorio.Text = "Relatorio";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // lvMaterias
            // 
            this.lvMaterias.HideSelection = false;
            this.lvMaterias.Location = new System.Drawing.Point(86, 60);
            this.lvMaterias.Name = "lvMaterias";
            this.lvMaterias.Size = new System.Drawing.Size(431, 212);
            this.lvMaterias.TabIndex = 5;
            this.lvMaterias.UseCompatibleStateImageBehavior = false;
            this.lvMaterias.SelectedIndexChanged += new System.EventHandler(this.lvMaterias_SelectedIndexChanged);
            // 
            // cbAluno
            // 
            this.cbAluno.FormattingEnabled = true;
            this.cbAluno.Location = new System.Drawing.Point(73, 22);
            this.cbAluno.Name = "cbAluno";
            this.cbAluno.Size = new System.Drawing.Size(444, 21);
            this.cbAluno.TabIndex = 4;
            this.cbAluno.SelectedIndexChanged += new System.EventHandler(this.cbAluno_SelectedIndexChanged);
            // 
            // labelListaMaterias
            // 
            this.labelListaMaterias.AutoSize = true;
            this.labelListaMaterias.Location = new System.Drawing.Point(30, 60);
            this.labelListaMaterias.Name = "labelListaMaterias";
            this.labelListaMaterias.Size = new System.Drawing.Size(50, 13);
            this.labelListaMaterias.TabIndex = 2;
            this.labelListaMaterias.Text = "Matérias:";
            // 
            // labeListaAluno
            // 
            this.labeListaAluno.AutoSize = true;
            this.labeListaAluno.Location = new System.Drawing.Point(30, 25);
            this.labeListaAluno.Name = "labeListaAluno";
            this.labeListaAluno.Size = new System.Drawing.Size(37, 13);
            this.labeListaAluno.TabIndex = 0;
            this.labeListaAluno.Text = "Aluno:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 328);
            this.Controls.Add(tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            tabControl1.ResumeLayout(false);
            this.tabAluno.ResumeLayout(false);
            this.tabAluno.PerformLayout();
            this.tabMateria.ResumeLayout(false);
            this.tabMateria.PerformLayout();
            this.tabRelatorio.ResumeLayout(false);
            this.tabRelatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAluno;
        private System.Windows.Forms.TabPage tabMateria;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNrMat;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.TextBox tbNrMat;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.Label labelAluno;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Button btAssociar;
        private System.Windows.Forms.TextBox tbDisciplina;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label labelListaMaterias;
        private System.Windows.Forms.Label labeListaAluno;
        private System.Windows.Forms.TextBox tbListaAluno;
        private System.Windows.Forms.Button btProcurarMateria;
        private System.Windows.Forms.TextBox tbListaMateria;
        private System.Windows.Forms.Button btProcurarAluno;
        private System.Windows.Forms.Button btCadastrarMateria;
        private System.Windows.Forms.ComboBox cbAluno;
        private System.Windows.Forms.ListView lvMaterias;
    }
}

