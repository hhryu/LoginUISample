namespace LoginSample02
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
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_singup = new System.Windows.Forms.Button();
            this.pn_top1 = new System.Windows.Forms.Panel();
            this.pn_top2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_bottom = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pn_bottom4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_google = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pn_bottom3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_facebook = new System.Windows.Forms.PictureBox();
            this.pn_bottom2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_main = new System.Windows.Forms.Panel();
            this.chk_remember = new System.Windows.Forms.CheckBox();
            this.btn_forgot = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.underLineTextBox1 = new LoginSample02.UnderLineTextBox();
            this.underLineTextBox2 = new LoginSample02.UnderLineTextBox();
            this.pn_top1.SuspendLayout();
            this.pn_top2.SuspendLayout();
            this.pn_bottom.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pn_bottom4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_google)).BeginInit();
            this.panel3.SuspendLayout();
            this.pn_bottom3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_facebook)).BeginInit();
            this.pn_bottom2.SuspendLayout();
            this.pn_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.btn_account.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Georgia", 10F);
            this.btn_account.ForeColor = System.Drawing.Color.White;
            this.btn_account.Location = new System.Drawing.Point(0, 0);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(228, 40);
            this.btn_account.TabIndex = 0;
            this.btn_account.Text = "My Account";
            this.btn_account.UseVisualStyleBackColor = false;
            // 
            // btn_singup
            // 
            this.btn_singup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
            this.btn_singup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
            this.btn_singup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_singup.Font = new System.Drawing.Font("Georgia", 10F);
            this.btn_singup.ForeColor = System.Drawing.Color.White;
            this.btn_singup.Location = new System.Drawing.Point(228, 0);
            this.btn_singup.Name = "btn_singup";
            this.btn_singup.Size = new System.Drawing.Size(228, 40);
            this.btn_singup.TabIndex = 1;
            this.btn_singup.Text = "Sign Up";
            this.btn_singup.UseVisualStyleBackColor = false;
            // 
            // pn_top1
            // 
            this.pn_top1.Controls.Add(this.btn_account);
            this.pn_top1.Controls.Add(this.btn_singup);
            this.pn_top1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top1.Location = new System.Drawing.Point(0, 0);
            this.pn_top1.Name = "pn_top1";
            this.pn_top1.Size = new System.Drawing.Size(456, 40);
            this.pn_top1.TabIndex = 2;
            // 
            // pn_top2
            // 
            this.pn_top2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.pn_top2.Controls.Add(this.label1);
            this.pn_top2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top2.Location = new System.Drawing.Point(0, 40);
            this.pn_top2.Name = "pn_top2";
            this.pn_top2.Size = new System.Drawing.Size(456, 50);
            this.pn_top2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Got an account? Enter your details below to login";
            // 
            // pn_bottom
            // 
            this.pn_bottom.Controls.Add(this.panel4);
            this.pn_bottom.Controls.Add(this.panel3);
            this.pn_bottom.Controls.Add(this.pn_bottom2);
            this.pn_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_bottom.Location = new System.Drawing.Point(0, 328);
            this.pn_bottom.Name = "pn_bottom";
            this.pn_bottom.Size = new System.Drawing.Size(456, 50);
            this.pn_bottom.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pn_bottom4);
            this.panel4.Controls.Add(this.pic_google);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(304, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 50);
            this.panel4.TabIndex = 2;
            // 
            // pn_bottom4
            // 
            this.pn_bottom4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pn_bottom4.Controls.Add(this.label4);
            this.pn_bottom4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_bottom4.Location = new System.Drawing.Point(51, 0);
            this.pn_bottom4.Name = "pn_bottom4";
            this.pn_bottom4.Size = new System.Drawing.Size(101, 50);
            this.pn_bottom4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Google";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_google
            // 
            this.pic_google.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_google.Image = global::LoginSample02.Properties.Resources.google;
            this.pic_google.Location = new System.Drawing.Point(0, 0);
            this.pic_google.Name = "pic_google";
            this.pic_google.Size = new System.Drawing.Size(51, 50);
            this.pic_google.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_google.TabIndex = 1;
            this.pic_google.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.panel3.Controls.Add(this.pn_bottom3);
            this.panel3.Controls.Add(this.pic_facebook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(152, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 50);
            this.panel3.TabIndex = 1;
            // 
            // pn_bottom3
            // 
            this.pn_bottom3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.pn_bottom3.Controls.Add(this.label3);
            this.pn_bottom3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_bottom3.Location = new System.Drawing.Point(51, 0);
            this.pn_bottom3.Name = "pn_bottom3";
            this.pn_bottom3.Size = new System.Drawing.Size(101, 50);
            this.pn_bottom3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Facebook";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_facebook
            // 
            this.pic_facebook.BackColor = System.Drawing.Color.White;
            this.pic_facebook.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_facebook.Image = global::LoginSample02.Properties.Resources.facebook;
            this.pic_facebook.Location = new System.Drawing.Point(0, 0);
            this.pic_facebook.Margin = new System.Windows.Forms.Padding(0);
            this.pic_facebook.Name = "pic_facebook";
            this.pic_facebook.Size = new System.Drawing.Size(51, 50);
            this.pic_facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_facebook.TabIndex = 0;
            this.pic_facebook.TabStop = false;
            // 
            // pn_bottom2
            // 
            this.pn_bottom2.BackColor = System.Drawing.Color.Black;
            this.pn_bottom2.Controls.Add(this.label2);
            this.pn_bottom2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_bottom2.Location = new System.Drawing.Point(0, 0);
            this.pn_bottom2.Name = "pn_bottom2";
            this.pn_bottom2.Size = new System.Drawing.Size(152, 50);
            this.pn_bottom2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign in with :";
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.White;
            this.pn_main.Controls.Add(this.underLineTextBox2);
            this.pn_main.Controls.Add(this.underLineTextBox1);
            this.pn_main.Controls.Add(this.chk_remember);
            this.pn_main.Controls.Add(this.btn_forgot);
            this.pn_main.Controls.Add(this.btn_login);
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 90);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(456, 238);
            this.pn_main.TabIndex = 5;
            // 
            // chk_remember
            // 
            this.chk_remember.AutoSize = true;
            this.chk_remember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.chk_remember.Font = new System.Drawing.Font("Georgia", 10F);
            this.chk_remember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.chk_remember.Location = new System.Drawing.Point(46, 139);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(125, 21);
            this.chk_remember.TabIndex = 2;
            this.chk_remember.Text = "Remember me?";
            this.chk_remember.UseVisualStyleBackColor = true;
            // 
            // btn_forgot
            // 
            this.btn_forgot.BackColor = System.Drawing.Color.White;
            this.btn_forgot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_forgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forgot.Font = new System.Drawing.Font("Georgia", 10F);
            this.btn_forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btn_forgot.Location = new System.Drawing.Point(304, 182);
            this.btn_forgot.Name = "btn_forgot";
            this.btn_forgot.Size = new System.Drawing.Size(140, 33);
            this.btn_forgot.TabIndex = 4;
            this.btn_forgot.Text = "Forgot password?";
            this.btn_forgot.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Georgia", 10F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(50, 182);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(90, 33);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // underLineTextBox1
            // 
            this.underLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.underLineTextBox1.Font = new System.Drawing.Font("Georgia", 10F);
            this.underLineTextBox1.Location = new System.Drawing.Point(46, 45);
            this.underLineTextBox1.Name = "underLineTextBox1";
            this.underLineTextBox1.Size = new System.Drawing.Size(367, 27);
            this.underLineTextBox1.TabIndex = 5;
            this.underLineTextBox1.Watermark = "Email";
            // 
            // underLineTextBox2
            // 
            this.underLineTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.underLineTextBox2.Font = new System.Drawing.Font("Georgia", 10F);
            this.underLineTextBox2.Location = new System.Drawing.Point(46, 94);
            this.underLineTextBox2.Name = "underLineTextBox2";
            this.underLineTextBox2.Size = new System.Drawing.Size(367, 27);
            this.underLineTextBox2.TabIndex = 6;
            this.underLineTextBox2.UseSystemPasswordChar = true;
            this.underLineTextBox2.Watermark = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 378);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.pn_bottom);
            this.Controls.Add(this.pn_top2);
            this.Controls.Add(this.pn_top1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pn_top1.ResumeLayout(false);
            this.pn_top2.ResumeLayout(false);
            this.pn_top2.PerformLayout();
            this.pn_bottom.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pn_bottom4.ResumeLayout(false);
            this.pn_bottom4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_google)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pn_bottom3.ResumeLayout(false);
            this.pn_bottom3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_facebook)).EndInit();
            this.pn_bottom2.ResumeLayout(false);
            this.pn_bottom2.PerformLayout();
            this.pn_main.ResumeLayout(false);
            this.pn_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_singup;
        private System.Windows.Forms.Panel pn_top1;
        private System.Windows.Forms.Panel pn_top2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_bottom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pic_google;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pic_facebook;
        private System.Windows.Forms.Panel pn_bottom2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_bottom3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pn_bottom4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.CheckBox chk_remember;
        private UnderLineTextBox txt_pw;
        private UnderLineTextBox txt_email;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_forgot;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private UnderLineTextBox underLineTextBox2;
        private UnderLineTextBox underLineTextBox1;
    }
}

