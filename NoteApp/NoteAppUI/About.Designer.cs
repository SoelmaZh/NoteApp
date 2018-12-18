namespace NoteAppUI
{
    partial class About
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
            this.NoteApp = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.github = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailforfeedback = new System.Windows.Forms.LinkLabel();
            this.githubnoteapp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NoteApp
            // 
            this.NoteApp.AutoSize = true;
            this.NoteApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteApp.Location = new System.Drawing.Point(12, 20);
            this.NoteApp.Name = "NoteApp";
            this.NoteApp.Size = new System.Drawing.Size(102, 25);
            this.NoteApp.TabIndex = 0;
            this.NoteApp.Text = "NoteApp";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(46, 121);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(133, 13);
            this.Author.TabIndex = 1;
            this.Author.Text = "Author:Soelma Zhargalova";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "v. 1.0.0";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(46, 166);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(97, 13);
            this.Email.TabIndex = 3;
            this.Email.Text = "email for feedback:";
            // 
            // github
            // 
            this.github.AutoSize = true;
            this.github.Location = new System.Drawing.Point(71, 201);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(43, 13);
            this.github.TabIndex = 4;
            this.github.Text = "GitHub:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "2018 Soelma Zhargalova ";
            // 
            // emailforfeedback
            // 
            this.emailforfeedback.AutoSize = true;
            this.emailforfeedback.Location = new System.Drawing.Point(173, 166);
            this.emailforfeedback.Name = "emailforfeedback";
            this.emailforfeedback.Size = new System.Drawing.Size(86, 13);
            this.emailforfeedback.TabIndex = 6;
            this.emailforfeedback.TabStop = true;
            this.emailforfeedback.Text = "soyayos@mail.ru";
            // 
            // githubnoteapp
            // 
            this.githubnoteapp.AutoSize = true;
            this.githubnoteapp.Location = new System.Drawing.Point(157, 201);
            this.githubnoteapp.Name = "githubnoteapp";
            this.githubnoteapp.Size = new System.Drawing.Size(102, 13);
            this.githubnoteapp.TabIndex = 7;
            this.githubnoteapp.TabStop = true;
            this.githubnoteapp.Text = "SoelmaZh/NoteApp";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 329);
            this.Controls.Add(this.githubnoteapp);
            this.Controls.Add(this.emailforfeedback);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.github);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.NoteApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteApp;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label github;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel emailforfeedback;
        private System.Windows.Forms.LinkLabel githubnoteapp;
    }
}