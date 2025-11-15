namespace LoginForm
{
    partial class UserProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserProfilePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblSubscription = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.ba = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBdate = new System.Windows.Forms.TextBox();
            this.textBSubcriptionType = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBUsername = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserProfilePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserProfilePanel
            // 
            this.UserProfilePanel.BackColor = System.Drawing.Color.White;
            this.UserProfilePanel.Controls.Add(this.panel1);
            this.UserProfilePanel.Controls.Add(this.textBdate);
            this.UserProfilePanel.Controls.Add(this.textBSubcriptionType);
            this.UserProfilePanel.Controls.Add(this.btnBack);
            this.UserProfilePanel.Controls.Add(this.label1);
            this.UserProfilePanel.Controls.Add(this.textBUsername);
            this.UserProfilePanel.Controls.Add(this.btnLogout);
            this.UserProfilePanel.Controls.Add(this.pictureBox1);
            this.UserProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.UserProfilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserProfilePanel.Name = "UserProfilePanel";
            this.UserProfilePanel.Size = new System.Drawing.Size(821, 566);
            this.UserProfilePanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblJoiningDate);
            this.panel1.Controls.Add(this.lblSubscription);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.ba);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 566);
            this.panel1.TabIndex = 15;
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.lblJoiningDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblJoiningDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.lblJoiningDate.Location = new System.Drawing.Point(318, 399);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(86, 21);
            this.lblJoiningDate.TabIndex = 17;
            this.lblJoiningDate.Text = "Joined on:";
            // 
            // lblSubscription
            // 
            this.lblSubscription.AutoSize = true;
            this.lblSubscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.lblSubscription.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSubscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.lblSubscription.Location = new System.Drawing.Point(318, 358);
            this.lblSubscription.Name = "lblSubscription";
            this.lblSubscription.Size = new System.Drawing.Size(111, 21);
            this.lblSubscription.TabIndex = 16;
            this.lblSubscription.Text = "Subscription: ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.lblUserName.Location = new System.Drawing.Point(318, 317);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(64, 21);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "Name: ";
            // 
            // ba
            // 
            this.ba.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.ba.Location = new System.Drawing.Point(14, 15);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(41, 37);
            this.ba.TabIndex = 11;
            this.ba.Text = "<";
            this.ba.UseVisualStyleBackColor = true;
            this.ba.Click += new System.EventHandler(this.ba_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(97, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Profile";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(376, 449);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(322, 123);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 170);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // textBdate
            // 
            this.textBdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.textBdate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.textBdate.Location = new System.Drawing.Point(277, 399);
            this.textBdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBdate.Multiline = true;
            this.textBdate.Name = "textBdate";
            this.textBdate.Size = new System.Drawing.Size(291, 37);
            this.textBdate.TabIndex = 14;
            this.textBdate.Text = "Join Date";
            // 
            // textBSubcriptionType
            // 
            this.textBSubcriptionType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.textBSubcriptionType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBSubcriptionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.textBSubcriptionType.Location = new System.Drawing.Point(277, 358);
            this.textBSubcriptionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBSubcriptionType.Multiline = true;
            this.textBSubcriptionType.Name = "textBSubcriptionType";
            this.textBSubcriptionType.Size = new System.Drawing.Size(291, 37);
            this.textBSubcriptionType.TabIndex = 13;
            this.textBSubcriptionType.Text = "Subcription Type";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.btnBack.Location = new System.Drawing.Point(14, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 37);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.ba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(97, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Profile";
            // 
            // textBUsername
            // 
            this.textBUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.textBUsername.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.textBUsername.Location = new System.Drawing.Point(277, 317);
            this.textBUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBUsername.Multiline = true;
            this.textBUsername.Name = "textBUsername";
            this.textBUsername.Size = new System.Drawing.Size(291, 37);
            this.textBUsername.TabIndex = 8;
            this.textBUsername.Text = "Username";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(376, 449);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 29);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(322, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 566);
            this.Controls.Add(this.UserProfilePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UserProfilePanel.ResumeLayout(false);
            this.UserProfilePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserProfilePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBdate;
        private System.Windows.Forms.TextBox textBSubcriptionType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblSubscription;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button ba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
