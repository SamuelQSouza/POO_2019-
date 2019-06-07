namespace wfTestMatExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbExp = new System.Windows.Forms.Label();
            this.tbExp = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.lbOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbExp
            // 
            this.lbExp.AutoSize = true;
            this.lbExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExp.Location = new System.Drawing.Point(12, 9);
            this.lbExp.Name = "lbExp";
            this.lbExp.Size = new System.Drawing.Size(194, 16);
            this.lbExp.TabIndex = 0;
            this.lbExp.Text = "Insira a expressão matematica:";
            this.lbExp.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbExp
            // 
            this.tbExp.Location = new System.Drawing.Point(12, 28);
            this.tbExp.Name = "tbExp";
            this.tbExp.Size = new System.Drawing.Size(381, 20);
            this.tbExp.TabIndex = 1;
            this.tbExp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbValor_KeyUp);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(12, 54);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(381, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "TESTAR EXPRESSÃO";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // lbOut
            // 
            this.lbOut.AutoSize = true;
            this.lbOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOut.Location = new System.Drawing.Point(12, 101);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(16, 17);
            this.lbOut.TabIndex = 3;
            this.lbOut.Text = "..";
            this.lbOut.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 167);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbExp);
            this.Controls.Add(this.lbExp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "math expression";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExp;
        private System.Windows.Forms.TextBox tbExp;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbOut;
    }
}

