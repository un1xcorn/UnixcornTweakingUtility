
namespace UnixcornTweakingUtility.Forms
{
    partial class PeripheralsBuffersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeripheralsBuffersForm));
            this.title = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.mouseBufferSize = new System.Windows.Forms.Label();
            this.keyboardBufferSize = new System.Windows.Forms.Label();
            this.mouseBufferSizeBox = new System.Windows.Forms.ComboBox();
            this.keyboardBufferSizeBox = new System.Windows.Forms.ComboBox();
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
            this.title.Size = new System.Drawing.Size(114, 15);
            this.title.TabIndex = 1;
            this.title.Text = "Peripherals Buffers";
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
            // mouseBufferSize
            // 
            this.mouseBufferSize.AutoSize = true;
            this.mouseBufferSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mouseBufferSize.ForeColor = System.Drawing.Color.White;
            this.mouseBufferSize.Location = new System.Drawing.Point(0, 66);
            this.mouseBufferSize.Name = "mouseBufferSize";
            this.mouseBufferSize.Size = new System.Drawing.Size(119, 17);
            this.mouseBufferSize.TabIndex = 13;
            this.mouseBufferSize.Text = "Mouse Buffer Size:";
            // 
            // keyboardBufferSize
            // 
            this.keyboardBufferSize.AutoSize = true;
            this.keyboardBufferSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.keyboardBufferSize.ForeColor = System.Drawing.Color.White;
            this.keyboardBufferSize.Location = new System.Drawing.Point(0, 34);
            this.keyboardBufferSize.Name = "keyboardBufferSize";
            this.keyboardBufferSize.Size = new System.Drawing.Size(136, 17);
            this.keyboardBufferSize.TabIndex = 12;
            this.keyboardBufferSize.Text = "Keyboard Buffer Size:";
            // 
            // mouseBufferSizeBox
            // 
            this.mouseBufferSizeBox.FormattingEnabled = true;
            this.mouseBufferSizeBox.Location = new System.Drawing.Point(267, 66);
            this.mouseBufferSizeBox.Name = "mouseBufferSizeBox";
            this.mouseBufferSizeBox.Size = new System.Drawing.Size(171, 21);
            this.mouseBufferSizeBox.TabIndex = 21;
            // 
            // keyboardBufferSizeBox
            // 
            this.keyboardBufferSizeBox.FormattingEnabled = true;
            this.keyboardBufferSizeBox.Location = new System.Drawing.Point(267, 34);
            this.keyboardBufferSizeBox.Name = "keyboardBufferSizeBox";
            this.keyboardBufferSizeBox.Size = new System.Drawing.Size(171, 21);
            this.keyboardBufferSizeBox.TabIndex = 22;
            // 
            // PeripheralsBuffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.keyboardBufferSizeBox);
            this.Controls.Add(this.mouseBufferSizeBox);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.save);
            this.Controls.Add(this.mouseBufferSize);
            this.Controls.Add(this.keyboardBufferSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeripheralsBuffersForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PeripheralsBuffersForm";
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label mouseBufferSize;
        private System.Windows.Forms.Label keyboardBufferSize;
        private System.Windows.Forms.ComboBox mouseBufferSizeBox;
        private System.Windows.Forms.ComboBox keyboardBufferSizeBox;
    }
}