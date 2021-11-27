

using System.Drawing;

namespace UnixcornTweakingUtility.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topbar = new System.Windows.Forms.Panel();
            this.author = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.extra = new System.Windows.Forms.Button();
            this.installers = new System.Windows.Forms.Button();
            this.advancedTweaks = new System.Windows.Forms.Button();
            this.basicTweaks = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Label();
            this.items = new System.Windows.Forms.Panel();
            this.topbar.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.Black;
            this.topbar.Controls.Add(this.author);
            this.topbar.Controls.Add(this.title);
            this.topbar.Controls.Add(this.close);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.ForeColor = System.Drawing.Color.White;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(800, 25);
            this.topbar.TabIndex = 0;
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.ForeColor = System.Drawing.Color.White;
            this.author.Location = new System.Drawing.Point(171, 4);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(97, 15);
            this.author.TabIndex = 2;
            this.author.Text = "by Little Unixcorn";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(30, 15);
            this.title.TabIndex = 1;
            this.title.Text = "title";
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
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(780, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.Controls.Add(this.extra);
            this.menu.Controls.Add(this.installers);
            this.menu.Controls.Add(this.advancedTweaks);
            this.menu.Controls.Add(this.basicTweaks);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(0, 25);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 35);
            this.menu.TabIndex = 1;
            // 
            // extra
            // 
            this.extra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.extra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.extra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.extra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extra.ForeColor = System.Drawing.Color.White;
            this.extra.Location = new System.Drawing.Point(600, 0);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(200, 35);
            this.extra.TabIndex = 6;
            this.extra.TabStop = false;
            this.extra.Text = "Extra";
            this.extra.UseVisualStyleBackColor = true;
            this.extra.Click += new System.EventHandler(this.extra_Click);
            // 
            // installers
            // 
            this.installers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.installers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.installers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.installers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installers.ForeColor = System.Drawing.Color.White;
            this.installers.Location = new System.Drawing.Point(400, 0);
            this.installers.Name = "installers";
            this.installers.Size = new System.Drawing.Size(200, 35);
            this.installers.TabIndex = 5;
            this.installers.TabStop = false;
            this.installers.Text = "Installers";
            this.installers.UseVisualStyleBackColor = true;
            this.installers.Click += new System.EventHandler(this.installers_Click);
            // 
            // advancedTweaks
            // 
            this.advancedTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.advancedTweaks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.advancedTweaks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.advancedTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advancedTweaks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedTweaks.ForeColor = System.Drawing.Color.White;
            this.advancedTweaks.Location = new System.Drawing.Point(200, 0);
            this.advancedTweaks.Name = "advancedTweaks";
            this.advancedTweaks.Size = new System.Drawing.Size(200, 35);
            this.advancedTweaks.TabIndex = 4;
            this.advancedTweaks.TabStop = false;
            this.advancedTweaks.Text = "Advanced Tweaks";
            this.advancedTweaks.UseVisualStyleBackColor = true;
            this.advancedTweaks.Click += new System.EventHandler(this.advancedTweaks_Click);
            // 
            // basicTweaks
            // 
            this.basicTweaks.BackColor = System.Drawing.Color.Black;
            this.basicTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.basicTweaks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.basicTweaks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.basicTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicTweaks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicTweaks.ForeColor = System.Drawing.Color.White;
            this.basicTweaks.Location = new System.Drawing.Point(0, 0);
            this.basicTweaks.Name = "basicTweaks";
            this.basicTweaks.Size = new System.Drawing.Size(200, 35);
            this.basicTweaks.TabIndex = 3;
            this.basicTweaks.TabStop = false;
            this.basicTweaks.Text = "Basic tweaks";
            this.basicTweaks.UseVisualStyleBackColor = false;
            this.basicTweaks.Click += new System.EventHandler(this.basicTweaks_Click);
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.Black;
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.ForeColor = System.Drawing.Color.White;
            this.separator.Location = new System.Drawing.Point(0, 60);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(800, 2);
            this.separator.TabIndex = 2;
            // 
            // items
            // 
            this.items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.items.ForeColor = System.Drawing.Color.White;
            this.items.Location = new System.Drawing.Point(0, 62);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(800, 363);
            this.items.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.items);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainForm";
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button basicTweaks;
        private System.Windows.Forms.Button advancedTweaks;
        private System.Windows.Forms.Button installers;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Panel items;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Button extra;
    }
}
