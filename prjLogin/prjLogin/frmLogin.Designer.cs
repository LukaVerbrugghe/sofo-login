﻿namespace prjLogin
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistreren = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnWijzigWachtwoord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNieuwWachtwoord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(202, 57);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wachtwoord";
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(213, 103);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(100, 20);
            this.txtWachtwoord.TabIndex = 2;
            this.txtWachtwoord.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(116, 129);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(186, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Location = new System.Drawing.Point(116, 159);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreren.TabIndex = 4;
            this.btnRegistreren.Text = "Registratie";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(116, 188);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(186, 23);
            this.btnVerwijder.TabIndex = 5;
            this.btnVerwijder.Text = "verwijder gebruiker";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnWijzigWachtwoord
            // 
            this.btnWijzigWachtwoord.Location = new System.Drawing.Point(116, 246);
            this.btnWijzigWachtwoord.Name = "btnWijzigWachtwoord";
            this.btnWijzigWachtwoord.Size = new System.Drawing.Size(186, 23);
            this.btnWijzigWachtwoord.TabIndex = 6;
            this.btnWijzigWachtwoord.Text = "Verander wachtwoord";
            this.btnWijzigWachtwoord.UseVisualStyleBackColor = true;
            this.btnWijzigWachtwoord.Click += new System.EventHandler(this.btnWijzigWachtwoord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nieuw wachtwoord";
            // 
            // txtNieuwWachtwoord
            // 
            this.txtNieuwWachtwoord.Location = new System.Drawing.Point(221, 220);
            this.txtNieuwWachtwoord.Name = "txtNieuwWachtwoord";
            this.txtNieuwWachtwoord.Size = new System.Drawing.Size(100, 20);
            this.txtNieuwWachtwoord.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 287);
            this.Controls.Add(this.txtNieuwWachtwoord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWijzigWachtwoord);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnRegistreren);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistreren;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnWijzigWachtwoord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNieuwWachtwoord;
    }
}

