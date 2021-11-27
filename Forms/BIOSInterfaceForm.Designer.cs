
namespace UnixcornTweakingUtility.Forms
{
    partial class BIOSInterfaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIOSInterfaceForm));
            this.title = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.variableName = new System.Windows.Forms.Label();
            this.variableValue = new System.Windows.Forms.Label();
            this.method = new System.Windows.Forms.Label();
            this.variableNameBox = new System.Windows.Forms.TextBox();
            this.variableValueBox = new System.Windows.Forms.TextBox();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.modify = new System.Windows.Forms.Button();
            this.modifyByFile = new System.Windows.Forms.Button();
            this.saveVariables = new System.Windows.Forms.Button();
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
            this.title.Size = new System.Drawing.Size(35, 15);
            this.title.TabIndex = 1;
            this.title.Text = "BIOS";
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
            this.topbar.Size = new System.Drawing.Size(350, 25);
            this.topbar.TabIndex = 1;
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
            this.close.Location = new System.Drawing.Point(330, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // variableName
            // 
            this.variableName.AutoSize = true;
            this.variableName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.variableName.ForeColor = System.Drawing.Color.White;
            this.variableName.Location = new System.Drawing.Point(0, 28);
            this.variableName.Name = "variableName";
            this.variableName.Size = new System.Drawing.Size(97, 17);
            this.variableName.TabIndex = 2;
            this.variableName.Text = "Variable name:";
            // 
            // variableValue
            // 
            this.variableValue.AutoSize = true;
            this.variableValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.variableValue.ForeColor = System.Drawing.Color.White;
            this.variableValue.Location = new System.Drawing.Point(0, 59);
            this.variableValue.Name = "variableValue";
            this.variableValue.Size = new System.Drawing.Size(95, 17);
            this.variableValue.TabIndex = 3;
            this.variableValue.Text = "Variable value:";
            // 
            // method
            // 
            this.method.AutoSize = true;
            this.method.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.method.ForeColor = System.Drawing.Color.White;
            this.method.Location = new System.Drawing.Point(0, 90);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(59, 17);
            this.method.TabIndex = 4;
            this.method.Text = "Method:";
            // 
            // variableNameBox
            // 
            this.variableNameBox.Location = new System.Drawing.Point(167, 31);
            this.variableNameBox.Name = "variableNameBox";
            this.variableNameBox.Size = new System.Drawing.Size(171, 20);
            this.variableNameBox.TabIndex = 5;
            // 
            // variableValueBox
            // 
            this.variableValueBox.Location = new System.Drawing.Point(167, 62);
            this.variableValueBox.Name = "variableValueBox";
            this.variableValueBox.Size = new System.Drawing.Size(171, 20);
            this.variableValueBox.TabIndex = 6;
            // 
            // methodBox
            // 
            this.methodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "Contains",
            "Only"});
            this.methodBox.Location = new System.Drawing.Point(167, 93);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(171, 21);
            this.methodBox.TabIndex = 7;
            // 
            // modify
            // 
            this.modify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.modify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.modify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.ForeColor = System.Drawing.Color.White;
            this.modify.Location = new System.Drawing.Point(260, 153);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(78, 35);
            this.modify.TabIndex = 8;
            this.modify.TabStop = false;
            this.modify.Text = "Modify";
            this.modify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // modifyByFile
            // 
            this.modifyByFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.modifyByFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.modifyByFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.modifyByFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyByFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyByFile.ForeColor = System.Drawing.Color.White;
            this.modifyByFile.Location = new System.Drawing.Point(154, 153);
            this.modifyByFile.Name = "modifyByFile";
            this.modifyByFile.Size = new System.Drawing.Size(100, 35);
            this.modifyByFile.TabIndex = 9;
            this.modifyByFile.TabStop = false;
            this.modifyByFile.Text = "Modify by file";
            this.modifyByFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modifyByFile.UseVisualStyleBackColor = true;
            this.modifyByFile.Click += new System.EventHandler(this.modifyByFile_Click);
            // 
            // saveVariables
            // 
            this.saveVariables.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveVariables.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.saveVariables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.saveVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveVariables.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveVariables.ForeColor = System.Drawing.Color.White;
            this.saveVariables.Location = new System.Drawing.Point(6, 153);
            this.saveVariables.Name = "saveVariables";
            this.saveVariables.Size = new System.Drawing.Size(142, 35);
            this.saveVariables.TabIndex = 10;
            this.saveVariables.TabStop = false;
            this.saveVariables.Text = "Save variables";
            this.saveVariables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveVariables.UseVisualStyleBackColor = true;
            this.saveVariables.Click += new System.EventHandler(this.saveVariables_Click);
            // 
            // BIOSInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.saveVariables);
            this.Controls.Add(this.modifyByFile);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.variableValueBox);
            this.Controls.Add(this.variableNameBox);
            this.Controls.Add(this.method);
            this.Controls.Add(this.variableValue);
            this.Controls.Add(this.variableName);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BIOSInterfaceForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BIOSInterfaceForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label variableName;
        private System.Windows.Forms.Label variableValue;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label method;
        private System.Windows.Forms.TextBox variableNameBox;
        private System.Windows.Forms.TextBox variableValueBox;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button modifyByFile;
        private System.Windows.Forms.Button saveVariables;
    }
}