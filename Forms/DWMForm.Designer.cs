
namespace UnixcornTweakingUtility.Forms
{
    partial class DWMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DWMForm));
            this.close = new System.Windows.Forms.Button();
            this.topbar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.killDWM = new System.Windows.Forms.Button();
            this.startDWM = new System.Windows.Forms.Button();
            this.topbar.SuspendLayout();
            this.SuspendLayout();
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
            this.close.Location = new System.Drawing.Point(318, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
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
            this.topbar.Size = new System.Drawing.Size(338, 25);
            this.topbar.TabIndex = 24;
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(39, 15);
            this.title.TabIndex = 1;
            this.title.Text = "DWM";
            // 
            // killDWM
            // 
            this.killDWM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.killDWM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.killDWM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.killDWM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.killDWM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.killDWM.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killDWM.ForeColor = System.Drawing.Color.White;
            this.killDWM.Location = new System.Drawing.Point(12, 31);
            this.killDWM.Name = "killDWM";
            this.killDWM.Size = new System.Drawing.Size(154, 35);
            this.killDWM.TabIndex = 25;
            this.killDWM.TabStop = false;
            this.killDWM.Text = "Kill DWM";
            this.killDWM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.killDWM.UseVisualStyleBackColor = false;
            this.killDWM.Click += new System.EventHandler(this.killDWM_Click);
            // 
            // startDWM
            // 
            this.startDWM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.startDWM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.startDWM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.startDWM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDWM.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDWM.ForeColor = System.Drawing.Color.White;
            this.startDWM.Location = new System.Drawing.Point(172, 31);
            this.startDWM.Name = "startDWM";
            this.startDWM.Size = new System.Drawing.Size(154, 35);
            this.startDWM.TabIndex = 26;
            this.startDWM.TabStop = false;
            this.startDWM.Text = "Start DWM";
            this.startDWM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.startDWM.UseVisualStyleBackColor = true;
            this.startDWM.Click += new System.EventHandler(this.startDWM_Click);
            // 
            // DWMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(338, 85);
            this.Controls.Add(this.startDWM);
            this.Controls.Add(this.killDWM);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DWMForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DWMForm";
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button killDWM;
        private System.Windows.Forms.Button startDWM;
    }
}