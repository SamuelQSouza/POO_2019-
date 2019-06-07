namespace wfPilhaDinamica
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
            this.tbPilha = new System.Windows.Forms.TextBox();
            this.lbPilha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btPush = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btMaior = new System.Windows.Forms.Button();
            this.btMenor = new System.Windows.Forms.Button();
            this.btInverte = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPilha
            // 
            this.tbPilha.AcceptsReturn = true;
            this.tbPilha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPilha.Location = new System.Drawing.Point(118, 28);
            this.tbPilha.Multiline = true;
            this.tbPilha.Name = "tbPilha";
            this.tbPilha.ReadOnly = true;
            this.tbPilha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPilha.Size = new System.Drawing.Size(223, 242);
            this.tbPilha.TabIndex = 0;
            // 
            // lbPilha
            // 
            this.lbPilha.AutoSize = true;
            this.lbPilha.Location = new System.Drawing.Point(118, 12);
            this.lbPilha.Name = "lbPilha";
            this.lbPilha.Size = new System.Drawing.Size(33, 13);
            this.lbPilha.TabIndex = 1;
            this.lbPilha.Text = "Pilha:";
            this.lbPilha.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "pop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btPop_Click);
            // 
            // btPush
            // 
            this.btPush.Location = new System.Drawing.Point(12, 54);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(100, 31);
            this.btPush.TabIndex = 3;
            this.btPush.Text = "push";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(12, 128);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(100, 31);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "imprime";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btMaior
            // 
            this.btMaior.Location = new System.Drawing.Point(12, 165);
            this.btMaior.Name = "btMaior";
            this.btMaior.Size = new System.Drawing.Size(100, 31);
            this.btMaior.TabIndex = 5;
            this.btMaior.Text = "maior";
            this.btMaior.UseVisualStyleBackColor = true;
            this.btMaior.Click += new System.EventHandler(this.btMaior_Click);
            // 
            // btMenor
            // 
            this.btMenor.Location = new System.Drawing.Point(12, 202);
            this.btMenor.Name = "btMenor";
            this.btMenor.Size = new System.Drawing.Size(100, 31);
            this.btMenor.TabIndex = 6;
            this.btMenor.Text = "menor";
            this.btMenor.UseVisualStyleBackColor = true;
            this.btMenor.Click += new System.EventHandler(this.btMenor_Click);
            // 
            // btInverte
            // 
            this.btInverte.Location = new System.Drawing.Point(12, 239);
            this.btInverte.Name = "btInverte";
            this.btInverte.Size = new System.Drawing.Size(100, 31);
            this.btInverte.TabIndex = 7;
            this.btInverte.Text = "inverte";
            this.btInverte.UseVisualStyleBackColor = true;
            this.btInverte.Click += new System.EventHandler(this.btInverte_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(12, 28);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 9;
            this.tbValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbValor_KeyUp);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(13, 12);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(33, 13);
            this.lbValor.TabIndex = 10;
            this.lbValor.Text = "valor:";
            this.lbValor.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 278);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btInverte);
            this.Controls.Add(this.btMenor);
            this.Controls.Add(this.btMaior);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btPush);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPilha);
            this.Controls.Add(this.tbPilha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPilha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btMaior;
        private System.Windows.Forms.Button btMenor;
        private System.Windows.Forms.Button btInverte;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lbValor;
        protected System.Windows.Forms.TextBox tbPilha;
    }
}

