﻿namespace wfArquivo
{
    partial class laboratorio
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
            this.buscafile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscafile
            // 
            this.buscafile.Location = new System.Drawing.Point(12, 30);
            this.buscafile.Name = "buscafile";
            this.buscafile.Size = new System.Drawing.Size(343, 20);
            this.buscafile.TabIndex = 0;
            this.buscafile.Text = "C:\\Users\\samuel\\Documents\\";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textfile
            // 
            this.textfile.Location = new System.Drawing.Point(12, 72);
            this.textfile.Multiline = true;
            this.textfile.Name = "textfile";
            this.textfile.Size = new System.Drawing.Size(440, 338);
            this.textfile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manipular Arquivo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscafile);
            this.Name = "laboratorio";
            this.Text = "Laboratorio 06";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscafile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

