﻿namespace WindowsFormsApp2
{
    partial class formPrincipal
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
            this.btnMensagem = new System.Windows.Forms.Button();
            this.chkMensagem = new System.Windows.Forms.CheckBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(194, 157);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(160, 71);
            this.btnMensagem.TabIndex = 0;
            this.btnMensagem.Text = "Clique aqui para receber uma mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkMensagem
            // 
            this.chkMensagem.AutoSize = true;
            this.chkMensagem.Location = new System.Drawing.Point(223, 293);
            this.chkMensagem.Name = "chkMensagem";
            this.chkMensagem.Size = new System.Drawing.Size(80, 17);
            this.chkMensagem.TabIndex = 1;
            this.chkMensagem.Text = "checkBox1";
            this.chkMensagem.UseVisualStyleBackColor = true;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(233, 365);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(35, 13);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "label1";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.chkMensagem);
            this.Controls.Add(this.btnMensagem);
            this.Name = "formPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.CheckBox chkMensagem;
        private System.Windows.Forms.Label lblMensagem;
    }
}

