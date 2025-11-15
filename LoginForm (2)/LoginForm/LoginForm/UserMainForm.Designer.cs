namespace LoginForm
{
    partial class UserMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvLibrary = new System.Windows.Forms.DataGridView();
            this.LibraryTab = new System.Windows.Forms.TabPage();
            this.PlayingPanel = new System.Windows.Forms.TabControl();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.MenuTransition = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnPremium = new System.Windows.Forms.Button();
            this.pnHistory = new System.Windows.Forms.Button();
            this.pnTopMixes = new System.Windows.Forms.Button();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.Library = new System.Windows.Forms.Button();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnProfile = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).BeginInit();
            this.LibraryTab.SuspendLayout();
            this.PlayingPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvLibrary);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Library";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvLibrary
            // 
            this.dgvLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibrary.Location = new System.Drawing.Point(3, 3);
            this.dgvLibrary.MultiSelect = false;
            this.dgvLibrary.Name = "dgvLibrary";
            this.dgvLibrary.ReadOnly = true;
            this.dgvLibrary.RowHeadersWidth = 51;
            this.dgvLibrary.RowTemplate.Height = 24;
            this.dgvLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibrary.Size = new System.Drawing.Size(770, 576);
            this.dgvLibrary.TabIndex = 1;
            // 
            // LibraryTab
            // 
            this.LibraryTab.Controls.Add(this.axWindowsMediaPlayer1);
            this.LibraryTab.Location = new System.Drawing.Point(4, 4);
            this.LibraryTab.Name = "LibraryTab";
            this.LibraryTab.Padding = new System.Windows.Forms.Padding(3);
            this.LibraryTab.Size = new System.Drawing.Size(776, 582);
            this.LibraryTab.TabIndex = 0;
            this.LibraryTab.Text = "Playing";
            this.LibraryTab.UseVisualStyleBackColor = true;
            // 
            // PlayingPanel
            // 
            this.PlayingPanel.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.PlayingPanel.Controls.Add(this.LibraryTab);
            this.PlayingPanel.Controls.Add(this.tabPage2);
            this.PlayingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayingPanel.Location = new System.Drawing.Point(277, 54);
            this.PlayingPanel.Name = "PlayingPanel";
            this.PlayingPanel.SelectedIndex = 0;
            this.PlayingPanel.Size = new System.Drawing.Size(784, 611);
            this.PlayingPanel.TabIndex = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick_1);
            // 
            // MenuTransition
            // 
            this.MenuTransition.Interval = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 56);
            this.panel3.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(271, 56);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "     LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.panel6.Controls.Add(this.pnPremium);
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.panel6.Location = new System.Drawing.Point(0, 112);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 56);
            this.panel6.TabIndex = 5;
            // 
            // pnPremium
            // 
            this.pnPremium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.pnPremium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pnPremium.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.pnPremium.Image = ((System.Drawing.Image)(resources.GetObject("pnPremium.Image")));
            this.pnPremium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnPremium.Location = new System.Drawing.Point(0, 0);
            this.pnPremium.Name = "pnPremium";
            this.pnPremium.Size = new System.Drawing.Size(271, 56);
            this.pnPremium.TabIndex = 3;
            this.pnPremium.Text = "       Premium";
            this.pnPremium.UseVisualStyleBackColor = false;
            this.pnPremium.Click += new System.EventHandler(this.pnPremium_Click);
            // 
            // pnHistory
            // 
            this.pnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.pnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pnHistory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.pnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnHistory.Location = new System.Drawing.Point(0, 56);
            this.pnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnHistory.Name = "pnHistory";
            this.pnHistory.Size = new System.Drawing.Size(271, 56);
            this.pnHistory.TabIndex = 11;
            this.pnHistory.Text = "History";
            this.pnHistory.UseVisualStyleBackColor = false;
            // 
            // pnTopMixes
            // 
            this.pnTopMixes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.pnTopMixes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pnTopMixes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTopMixes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.pnTopMixes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnTopMixes.Location = new System.Drawing.Point(0, 112);
            this.pnTopMixes.Margin = new System.Windows.Forms.Padding(0);
            this.pnTopMixes.Name = "pnTopMixes";
            this.pnTopMixes.Size = new System.Drawing.Size(271, 56);
            this.pnTopMixes.TabIndex = 12;
            this.pnTopMixes.Text = "Top Mixes";
            this.pnTopMixes.UseVisualStyleBackColor = false;
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.MenuContainer.Controls.Add(this.Library);
            this.MenuContainer.Controls.Add(this.pnHistory);
            this.MenuContainer.Controls.Add(this.pnTopMixes);
            this.MenuContainer.Location = new System.Drawing.Point(0, 56);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(271, 56);
            this.MenuContainer.TabIndex = 9;
            // 
            // Library
            // 
            this.Library.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.Library.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Library.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.Library.Image = ((System.Drawing.Image)(resources.GetObject("Library.Image")));
            this.Library.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Library.Location = new System.Drawing.Point(0, 0);
            this.Library.Margin = new System.Windows.Forms.Padding(0);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(271, 56);
            this.Library.TabIndex = 10;
            this.Library.Text = "       Library";
            this.Library.UseVisualStyleBackColor = false;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.Black;
            this.Sidebar.Controls.Add(this.pnProfile);
            this.Sidebar.Controls.Add(this.MenuContainer);
            this.Sidebar.Controls.Add(this.panel6);
            this.Sidebar.Controls.Add(this.panel3);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Sidebar.Location = new System.Drawing.Point(0, 54);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(277, 611);
            this.Sidebar.TabIndex = 9;
            // 
            // pnProfile
            // 
            this.pnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.pnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pnProfile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.pnProfile.Image = ((System.Drawing.Image)(resources.GetObject("pnProfile.Image")));
            this.pnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnProfile.Location = new System.Drawing.Point(0, 0);
            this.pnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(271, 56);
            this.pnProfile.TabIndex = 4;
            this.pnProfile.Text = "      Profile";
            this.pnProfile.UseVisualStyleBackColor = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.close.Location = new System.Drawing.Point(1021, 19);
            this.close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 27);
            this.close.TabIndex = 11;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(49, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "MELODIFY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 54);
            this.panel1.TabIndex = 8;
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.Transparent;
            this.btnHam.Image = global::LoginForm.Properties.Resources.menu;
            this.btnHam.Location = new System.Drawing.Point(0, 15);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(43, 39);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click_1);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(770, 576);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 665);
            this.Controls.Add(this.PlayingPanel);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMainForm";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).EndInit();
            this.LibraryTab.ResumeLayout(false);
            this.PlayingPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.MenuContainer.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvLibrary;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TabPage LibraryTab;
        private System.Windows.Forms.TabControl PlayingPanel;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer MenuTransition;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button pnPremium;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Library;
        private System.Windows.Forms.Button pnHistory;
        private System.Windows.Forms.Button pnTopMixes;
        private System.Windows.Forms.Button pnProfile;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Panel panel1;
    }
}