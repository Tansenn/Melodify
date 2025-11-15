namespace LoginForm
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister_login = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.lblRegister_Pass = new System.Windows.Forms.Label();
            this.txtRegister_pass = new System.Windows.Forms.TextBox();
            this.Register_showpass = new System.Windows.Forms.CheckBox();
            this.lblRegister_Email = new System.Windows.Forms.Label();
            this.txtRegister_Email = new System.Windows.Forms.TextBox();
            this.lblRegister_username = new System.Windows.Forms.Label();
            this.txtRegister_username = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegister_login);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 613);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(122, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "MELODIFY";
            // 
            // btnRegister_login
            // 
            this.btnRegister_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.btnRegister_login.FlatAppearance.BorderSize = 0;
            this.btnRegister_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.btnRegister_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.btnRegister_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.btnRegister_login.Location = new System.Drawing.Point(90, 544);
            this.btnRegister_login.Name = "btnRegister_login";
            this.btnRegister_login.Size = new System.Drawing.Size(192, 42);
            this.btnRegister_login.TabIndex = 11;
            this.btnRegister_login.Text = "SIGN IN";
            this.btnRegister_login.UseVisualStyleBackColor = false;
            this.btnRegister_login.Click += new System.EventHandler(this.btnRegister_login_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.lblLogin.Location = new System.Drawing.Point(135, 516);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(125, 22);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "SIGN IN HERE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(129, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 133);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.close.Location = new System.Drawing.Point(805, 10);
            this.close.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 21);
            this.close.TabIndex = 10;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lblRegister_Pass
            // 
            this.lblRegister_Pass.AutoSize = true;
            this.lblRegister_Pass.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblRegister_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.lblRegister_Pass.Location = new System.Drawing.Point(482, 339);
            this.lblRegister_Pass.Name = "lblRegister_Pass";
            this.lblRegister_Pass.Size = new System.Drawing.Size(84, 22);
            this.lblRegister_Pass.TabIndex = 28;
            this.lblRegister_Pass.Text = "Password";
            // 
            // txtRegister_pass
            // 
            this.txtRegister_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.txtRegister_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegister_pass.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtRegister_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.txtRegister_pass.Location = new System.Drawing.Point(486, 367);
            this.txtRegister_pass.Multiline = true;
            this.txtRegister_pass.Name = "txtRegister_pass";
            this.txtRegister_pass.PasswordChar = '*';
            this.txtRegister_pass.Size = new System.Drawing.Size(291, 38);
            this.txtRegister_pass.TabIndex = 27;
            // 
            // Register_showpass
            // 
            this.Register_showpass.AutoSize = true;
            this.Register_showpass.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.Register_showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.Register_showpass.Location = new System.Drawing.Point(629, 412);
            this.Register_showpass.Name = "Register_showpass";
            this.Register_showpass.Size = new System.Drawing.Size(155, 26);
            this.Register_showpass.TabIndex = 24;
            this.Register_showpass.Text = "Show Password";
            this.Register_showpass.UseVisualStyleBackColor = true;
            this.Register_showpass.CheckedChanged += new System.EventHandler(this.Register_showpass_CheckedChanged);
            // 
            // lblRegister_Email
            // 
            this.lblRegister_Email.AutoSize = true;
            this.lblRegister_Email.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblRegister_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.lblRegister_Email.Location = new System.Drawing.Point(482, 260);
            this.lblRegister_Email.Name = "lblRegister_Email";
            this.lblRegister_Email.Size = new System.Drawing.Size(120, 22);
            this.lblRegister_Email.TabIndex = 23;
            this.lblRegister_Email.Text = "Email Address";
            // 
            // txtRegister_Email
            // 
            this.txtRegister_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.txtRegister_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegister_Email.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtRegister_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.txtRegister_Email.Location = new System.Drawing.Point(486, 288);
            this.txtRegister_Email.Multiline = true;
            this.txtRegister_Email.Name = "txtRegister_Email";
            this.txtRegister_Email.Size = new System.Drawing.Size(291, 38);
            this.txtRegister_Email.TabIndex = 22;
            // 
            // lblRegister_username
            // 
            this.lblRegister_username.AutoSize = true;
            this.lblRegister_username.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblRegister_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.lblRegister_username.Location = new System.Drawing.Point(482, 187);
            this.lblRegister_username.Name = "lblRegister_username";
            this.lblRegister_username.Size = new System.Drawing.Size(88, 22);
            this.lblRegister_username.TabIndex = 21;
            this.lblRegister_username.Text = "Username";
            // 
            // txtRegister_username
            // 
            this.txtRegister_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.txtRegister_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegister_username.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtRegister_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.txtRegister_username.Location = new System.Drawing.Point(486, 215);
            this.txtRegister_username.Multiline = true;
            this.txtRegister_username.Name = "txtRegister_username";
            this.txtRegister_username.Size = new System.Drawing.Size(291, 38);
            this.txtRegister_username.TabIndex = 20;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.White;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.btnSignup.Location = new System.Drawing.Point(481, 431);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(101, 45);
            this.btnSignup.TabIndex = 26;
            this.btnSignup.Text = "SIGN UP";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.lblSignIn.Location = new System.Drawing.Point(476, 116);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(116, 28);
            this.lblSignIn.TabIndex = 25;
            this.lblSignIn.Text = "REGISTER";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(839, 613);
            this.Controls.Add(this.lblRegister_Pass);
            this.Controls.Add(this.txtRegister_pass);
            this.Controls.Add(this.Register_showpass);
            this.Controls.Add(this.lblRegister_Email);
            this.Controls.Add(this.txtRegister_Email);
            this.Controls.Add(this.lblRegister_username);
            this.Controls.Add(this.txtRegister_username);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button btnRegister_login;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblRegister_Pass;
        private System.Windows.Forms.TextBox txtRegister_pass;
        private System.Windows.Forms.CheckBox Register_showpass;
        private System.Windows.Forms.Label lblRegister_Email;
        private System.Windows.Forms.TextBox txtRegister_Email;
        private System.Windows.Forms.Label lblRegister_username;
        private System.Windows.Forms.TextBox txtRegister_username;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label label1;
    }
}