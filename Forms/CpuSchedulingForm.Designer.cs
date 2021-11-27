
namespace UnixcornTweakingUtility.Forms
{
    partial class CpuSchedulingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CpuSchedulingForm));
            this.title = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.loadRecommended = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.systemResponsivenessBox = new System.Windows.Forms.ComboBox();
            this.systemResponsiveness = new System.Windows.Forms.Label();
            this.variableValue = new System.Windows.Forms.Label();
            this.networkThrottlingIndex = new System.Windows.Forms.Label();
            this.loadDefaults = new System.Windows.Forms.Button();
            this.win32PrioritySeparationBox = new System.Windows.Forms.ComboBox();
            this.networkThrottlingIndexBox = new System.Windows.Forms.ComboBox();
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
            this.title.Size = new System.Drawing.Size(94, 15);
            this.title.TabIndex = 1;
            this.title.Text = "CPU Scheduling";
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
            this.topbar.TabIndex = 11;
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
            // loadRecommended
            // 
            this.loadRecommended.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.loadRecommended.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.loadRecommended.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.loadRecommended.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadRecommended.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadRecommended.ForeColor = System.Drawing.Color.White;
            this.loadRecommended.Location = new System.Drawing.Point(12, 153);
            this.loadRecommended.Name = "loadRecommended";
            this.loadRecommended.Size = new System.Drawing.Size(141, 35);
            this.loadRecommended.TabIndex = 19;
            this.loadRecommended.TabStop = false;
            this.loadRecommended.Text = "Load recommended";
            this.loadRecommended.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadRecommended.UseVisualStyleBackColor = true;
            this.loadRecommended.Click += new System.EventHandler(this.loadRecommended_Click);
            // 
            // save
            // 
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(360, 153);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(78, 35);
            this.save.TabIndex = 18;
            this.save.TabStop = false;
            this.save.Text = "Save";
            this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // systemResponsivenessBox
            // 
            this.systemResponsivenessBox.FormattingEnabled = true;
            this.systemResponsivenessBox.Items.AddRange(new object[] {
            "10",
            "20"});
            this.systemResponsivenessBox.Location = new System.Drawing.Point(267, 98);
            this.systemResponsivenessBox.Name = "systemResponsivenessBox";
            this.systemResponsivenessBox.Size = new System.Drawing.Size(171, 21);
            this.systemResponsivenessBox.TabIndex = 17;
            // 
            // systemResponsiveness
            // 
            this.systemResponsiveness.AutoSize = true;
            this.systemResponsiveness.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.systemResponsiveness.ForeColor = System.Drawing.Color.White;
            this.systemResponsiveness.Location = new System.Drawing.Point(3, 98);
            this.systemResponsiveness.Name = "systemResponsiveness";
            this.systemResponsiveness.Size = new System.Drawing.Size(151, 17);
            this.systemResponsiveness.TabIndex = 14;
            this.systemResponsiveness.Text = "System Responsiveness";
            // 
            // variableValue
            // 
            this.variableValue.AutoSize = true;
            this.variableValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.variableValue.ForeColor = System.Drawing.Color.White;
            this.variableValue.Location = new System.Drawing.Point(0, 66);
            this.variableValue.Name = "variableValue";
            this.variableValue.Size = new System.Drawing.Size(158, 17);
            this.variableValue.TabIndex = 13;
            this.variableValue.Text = "Win32PrioritySeparation:";
            // 
            // networkThrottlingIndex
            // 
            this.networkThrottlingIndex.AutoSize = true;
            this.networkThrottlingIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.networkThrottlingIndex.ForeColor = System.Drawing.Color.White;
            this.networkThrottlingIndex.Location = new System.Drawing.Point(0, 34);
            this.networkThrottlingIndex.Name = "networkThrottlingIndex";
            this.networkThrottlingIndex.Size = new System.Drawing.Size(165, 17);
            this.networkThrottlingIndex.TabIndex = 12;
            this.networkThrottlingIndex.Text = "Network Throttling Index:";
            // 
            // loadDefaults
            // 
            this.loadDefaults.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.loadDefaults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.loadDefaults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.loadDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadDefaults.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDefaults.ForeColor = System.Drawing.Color.White;
            this.loadDefaults.Location = new System.Drawing.Point(159, 153);
            this.loadDefaults.Name = "loadDefaults";
            this.loadDefaults.Size = new System.Drawing.Size(141, 35);
            this.loadDefaults.TabIndex = 20;
            this.loadDefaults.TabStop = false;
            this.loadDefaults.Text = "Load defaults";
            this.loadDefaults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadDefaults.UseVisualStyleBackColor = true;
            this.loadDefaults.Click += new System.EventHandler(this.loadDefaults_Click);
            // 
            // win32PrioritySeparationBox
            // 
            this.win32PrioritySeparationBox.FormattingEnabled = true;
            this.win32PrioritySeparationBox.Items.AddRange(new object[] {
            "02",
            "16",
            "26",
            "fff55555",
            "1a7daf1c",
            "41ffaca",
            "555fffff",
            "ecf7f79f1",
            "ecf55555"});
            this.win32PrioritySeparationBox.Location = new System.Drawing.Point(267, 66);
            this.win32PrioritySeparationBox.Name = "win32PrioritySeparationBox";
            this.win32PrioritySeparationBox.Size = new System.Drawing.Size(171, 21);
            this.win32PrioritySeparationBox.TabIndex = 21;
            // 
            // networkThrottlingIndexBox
            // 
            this.networkThrottlingIndexBox.FormattingEnabled = true;
            this.networkThrottlingIndexBox.Items.AddRange(new object[] {
            "0",
            "10"});
            this.networkThrottlingIndexBox.Location = new System.Drawing.Point(267, 34);
            this.networkThrottlingIndexBox.Name = "networkThrottlingIndexBox";
            this.networkThrottlingIndexBox.Size = new System.Drawing.Size(171, 21);
            this.networkThrottlingIndexBox.TabIndex = 22;
            // 
            // CpuSchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.networkThrottlingIndexBox);
            this.Controls.Add(this.win32PrioritySeparationBox);
            this.Controls.Add(this.loadDefaults);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.loadRecommended);
            this.Controls.Add(this.save);
            this.Controls.Add(this.systemResponsivenessBox);
            this.Controls.Add(this.systemResponsiveness);
            this.Controls.Add(this.variableValue);
            this.Controls.Add(this.networkThrottlingIndex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CpuSchedulingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CpuSchedulingForm";
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button loadRecommended;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox systemResponsivenessBox;
        private System.Windows.Forms.Label systemResponsiveness;
        private System.Windows.Forms.Label variableValue;
        private System.Windows.Forms.Label networkThrottlingIndex;
        private System.Windows.Forms.Button loadDefaults;
        private System.Windows.Forms.ComboBox win32PrioritySeparationBox;
        private System.Windows.Forms.ComboBox networkThrottlingIndexBox;
    }
}