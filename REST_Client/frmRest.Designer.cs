namespace REST_Client
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtURI = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MsAboutParent = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(90, 38);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(321, 20);
            this.txtURI.TabIndex = 0;
            this.txtURI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURI_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(417, 35);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Request";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(90, 64);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(402, 163);
            this.txtResponse.TabIndex = 2;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(10, 41);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(66, 13);
            this.lblURL.TabIndex = 3;
            this.lblURL.Text = "RequestURI";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(10, 70);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(58, 13);
            this.lblResponse.TabIndex = 4;
            this.lblResponse.Text = "Response:";
            // 
            // msMenu
            // 
            this.msMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.MsAboutParent});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMenu.Size = new System.Drawing.Size(517, 24);
            this.msMenu.TabIndex = 5;
            this.msMenu.Text = "msMenu";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msExit});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(37, 20);
            this.msFile.Text = "File";
            // 
            // MsAboutParent
            // 
            this.MsAboutParent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAbout,
            this.msGitHub});
            this.MsAboutParent.Name = "MsAboutParent";
            this.MsAboutParent.Size = new System.Drawing.Size(52, 20);
            this.MsAboutParent.Text = "About";
            // 
            // msExit
            // 
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(152, 22);
            this.msExit.Text = "Exit";
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // msAbout
            // 
            this.msAbout.Name = "msAbout";
            this.msAbout.Size = new System.Drawing.Size(152, 22);
            this.msAbout.Text = "About";
            this.msAbout.Click += new System.EventHandler(this.msAbout_Click);
            // 
            // msGitHub
            // 
            this.msGitHub.Name = "msGitHub";
            this.msGitHub.Size = new System.Drawing.Size(152, 22);
            this.msGitHub.Text = "GitHub";
            this.msGitHub.Click += new System.EventHandler(this.msGitHub_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 248);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "C# REST Client";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.ToolStripMenuItem MsAboutParent;
        private System.Windows.Forms.ToolStripMenuItem msAbout;
        private System.Windows.Forms.ToolStripMenuItem msGitHub;
    }
}

