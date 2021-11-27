
namespace UnixcornTweakingUtility.UserControls
{
    partial class AdvancedTweaksUC
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
            this.biosInterface = new System.Windows.Forms.Button();
            this.affinities = new System.Windows.Forms.Button();
            this.gpuTweaks = new System.Windows.Forms.Button();
            this.importNip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // biosInterface
            // 
            this.biosInterface.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.biosInterface.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.biosInterface.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.biosInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.biosInterface.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biosInterface.ForeColor = System.Drawing.Color.White;
            this.biosInterface.Location = new System.Drawing.Point(0, 0);
            this.biosInterface.Name = "biosInterface";
            this.biosInterface.Size = new System.Drawing.Size(154, 35);
            this.biosInterface.TabIndex = 5;
            this.biosInterface.TabStop = false;
            this.biosInterface.Text = "BIOS Interface";
            this.biosInterface.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.biosInterface.UseVisualStyleBackColor = true;
            this.biosInterface.Click += new System.EventHandler(this.biosInterface_Click);
            // 
            // affinities
            // 
            this.affinities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.affinities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.affinities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.affinities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.affinities.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affinities.ForeColor = System.Drawing.Color.White;
            this.affinities.Location = new System.Drawing.Point(160, 0);
            this.affinities.Name = "affinities";
            this.affinities.Size = new System.Drawing.Size(154, 35);
            this.affinities.TabIndex = 6;
            this.affinities.TabStop = false;
            this.affinities.Text = "Affinities Interface";
            this.affinities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.affinities.UseVisualStyleBackColor = true;
            this.affinities.Click += new System.EventHandler(this.affinities_Click);
            // 
            // gpuTweaks
            // 
            this.gpuTweaks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gpuTweaks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.gpuTweaks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.gpuTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpuTweaks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTweaks.ForeColor = System.Drawing.Color.White;
            this.gpuTweaks.Location = new System.Drawing.Point(320, 0);
            this.gpuTweaks.Name = "gpuTweaks";
            this.gpuTweaks.Size = new System.Drawing.Size(154, 35);
            this.gpuTweaks.TabIndex = 7;
            this.gpuTweaks.TabStop = false;
            this.gpuTweaks.Text = "GPU Tweaks";
            this.gpuTweaks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gpuTweaks.UseVisualStyleBackColor = true;
            this.gpuTweaks.Click += new System.EventHandler(this.gpuTweaks_Click);
            // 
            // importNip
            // 
            this.importNip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.importNip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.importNip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.importNip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importNip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importNip.ForeColor = System.Drawing.Color.White;
            this.importNip.Location = new System.Drawing.Point(480, 0);
            this.importNip.Name = "importNip";
            this.importNip.Size = new System.Drawing.Size(154, 35);
            this.importNip.TabIndex = 8;
            this.importNip.TabStop = false;
            this.importNip.Text = "Import NIP";
            this.importNip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importNip.UseVisualStyleBackColor = true;
            this.importNip.Click += new System.EventHandler(this.importNip_Click);
            // 
            // AdvancedTweaksUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.importNip);
            this.Controls.Add(this.gpuTweaks);
            this.Controls.Add(this.affinities);
            this.Controls.Add(this.biosInterface);
            this.Name = "AdvancedTweaksUC";
            this.Size = new System.Drawing.Size(800, 363);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button biosInterface;
        private System.Windows.Forms.Button affinities;
        private System.Windows.Forms.Button gpuTweaks;
        private System.Windows.Forms.Button importNip;
    }
}
