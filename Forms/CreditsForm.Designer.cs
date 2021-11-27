
namespace UnixcornTweakingUtility.Forms
{
    partial class CreditsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsForm));
            this.title = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.twitter = new System.Windows.Forms.LinkLabel();
            this.topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(46, 15);
            this.title.TabIndex = 1;
            this.title.Text = "Credits";
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.Black;
            this.topbar.Controls.Add(this.close);
            this.topbar.Controls.Add(this.title);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.ForeColor = System.Drawing.Color.White;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(450, 25);
            this.topbar.TabIndex = 23;
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Black;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(430, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // copyright
            // 
            this.copyright.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.copyright.ForeColor = System.Drawing.Color.White;
            this.copyright.Location = new System.Drawing.Point(-4, 24);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(617, 90);
            this.copyright.TabIndex = 24;
            this.copyright.Text = "UnixcornTweakingUtility has been created by Little Unixcorn.\r\n-Tweaks credits goe" +
    "s to a4kata, Nani, CatGamerOP and Melody.\r\n-Installers credits goes to the respe" +
    "ctive owners of each program.";
            // 
            // twitter
            // 
            this.twitter.ActiveLinkColor = System.Drawing.Color.Blue;
            this.twitter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitter.ForeColor = System.Drawing.Color.White;
            this.twitter.Location = new System.Drawing.Point(-3, 183);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(156, 17);
            this.twitter.TabIndex = 25;
            this.twitter.TabStop = true;
            this.twitter.Text = "twitter.com/LittleUnixcorn_";
            this.twitter.VisitedLinkColor = System.Drawing.Color.Blue;
            this.twitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.twitter_LinkClicked);
            // 
            // CreditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CreditsForm";
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.LinkLabel twitter;
    }
}