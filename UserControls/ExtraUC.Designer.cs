
namespace UnixcornTweakingUtility.UserControls
{
    partial class ExtraUC
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
            this.credits = new System.Windows.Forms.Button();
            this.dwm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // credits
            // 
            this.credits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.credits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.credits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credits.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.ForeColor = System.Drawing.Color.White;
            this.credits.Location = new System.Drawing.Point(0, 0);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(154, 35);
            this.credits.TabIndex = 7;
            this.credits.TabStop = false;
            this.credits.Text = "Credits";
            this.credits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.credits.UseVisualStyleBackColor = true;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // dwm
            // 
            this.dwm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dwm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.dwm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.dwm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dwm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwm.ForeColor = System.Drawing.Color.White;
            this.dwm.Location = new System.Drawing.Point(160, 0);
            this.dwm.Name = "dwm";
            this.dwm.Size = new System.Drawing.Size(154, 35);
            this.dwm.TabIndex = 8;
            this.dwm.TabStop = false;
            this.dwm.Text = "DWM";
            this.dwm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dwm.UseVisualStyleBackColor = true;
            this.dwm.Click += new System.EventHandler(this.dwm_Click);
            // 
            // ExtraUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.dwm);
            this.Controls.Add(this.credits);
            this.Name = "ExtraUC";
            this.Size = new System.Drawing.Size(800, 363);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button credits;
        private System.Windows.Forms.Button dwm;
    }
}
