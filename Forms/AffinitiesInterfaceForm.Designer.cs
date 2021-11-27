
namespace UnixcornTweakingUtility.Forms
{
    partial class AffinitiesInterfaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffinitiesInterfaceForm));
            this.title = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.deviceName = new System.Windows.Forms.Label();
            this.deviceNameBox = new System.Windows.Forms.ComboBox();
            this.devicePath = new System.Windows.Forms.Label();
            this.devicePathLabel = new System.Windows.Forms.Label();
            this.affinityMask = new System.Windows.Forms.Label();
            this.cpu0 = new System.Windows.Forms.CheckBox();
            this.cpu1 = new System.Windows.Forms.CheckBox();
            this.cpu2 = new System.Windows.Forms.CheckBox();
            this.cpu3 = new System.Windows.Forms.CheckBox();
            this.cpu4 = new System.Windows.Forms.CheckBox();
            this.cpu5 = new System.Windows.Forms.CheckBox();
            this.cpu11 = new System.Windows.Forms.CheckBox();
            this.cpu10 = new System.Windows.Forms.CheckBox();
            this.cpu9 = new System.Windows.Forms.CheckBox();
            this.cpu8 = new System.Windows.Forms.CheckBox();
            this.cpu7 = new System.Windows.Forms.CheckBox();
            this.cpu6 = new System.Windows.Forms.CheckBox();
            this.cpu17 = new System.Windows.Forms.CheckBox();
            this.cpu16 = new System.Windows.Forms.CheckBox();
            this.cpu15 = new System.Windows.Forms.CheckBox();
            this.cpu14 = new System.Windows.Forms.CheckBox();
            this.cpu13 = new System.Windows.Forms.CheckBox();
            this.cpu12 = new System.Windows.Forms.CheckBox();
            this.cpu23 = new System.Windows.Forms.CheckBox();
            this.cpu22 = new System.Windows.Forms.CheckBox();
            this.cpu21 = new System.Windows.Forms.CheckBox();
            this.cpu20 = new System.Windows.Forms.CheckBox();
            this.cpu19 = new System.Windows.Forms.CheckBox();
            this.cpu18 = new System.Windows.Forms.CheckBox();
            this.cpu29 = new System.Windows.Forms.CheckBox();
            this.cpu28 = new System.Windows.Forms.CheckBox();
            this.cpu27 = new System.Windows.Forms.CheckBox();
            this.cpu26 = new System.Windows.Forms.CheckBox();
            this.cpu25 = new System.Windows.Forms.CheckBox();
            this.cpu24 = new System.Windows.Forms.CheckBox();
            this.cpu35 = new System.Windows.Forms.CheckBox();
            this.cpu34 = new System.Windows.Forms.CheckBox();
            this.cpu33 = new System.Windows.Forms.CheckBox();
            this.cpu32 = new System.Windows.Forms.CheckBox();
            this.cpu31 = new System.Windows.Forms.CheckBox();
            this.cpu30 = new System.Windows.Forms.CheckBox();
            this.cpu41 = new System.Windows.Forms.CheckBox();
            this.cpu40 = new System.Windows.Forms.CheckBox();
            this.cpu39 = new System.Windows.Forms.CheckBox();
            this.cpu38 = new System.Windows.Forms.CheckBox();
            this.cpu37 = new System.Windows.Forms.CheckBox();
            this.cpu36 = new System.Windows.Forms.CheckBox();
            this.cpu47 = new System.Windows.Forms.CheckBox();
            this.cpu46 = new System.Windows.Forms.CheckBox();
            this.cpu45 = new System.Windows.Forms.CheckBox();
            this.cpu44 = new System.Windows.Forms.CheckBox();
            this.cpu43 = new System.Windows.Forms.CheckBox();
            this.cpu42 = new System.Windows.Forms.CheckBox();
            this.cpu53 = new System.Windows.Forms.CheckBox();
            this.cpu52 = new System.Windows.Forms.CheckBox();
            this.cpu51 = new System.Windows.Forms.CheckBox();
            this.cpu50 = new System.Windows.Forms.CheckBox();
            this.cpu49 = new System.Windows.Forms.CheckBox();
            this.cpu48 = new System.Windows.Forms.CheckBox();
            this.cpu59 = new System.Windows.Forms.CheckBox();
            this.cpu58 = new System.Windows.Forms.CheckBox();
            this.cpu57 = new System.Windows.Forms.CheckBox();
            this.cpu56 = new System.Windows.Forms.CheckBox();
            this.cpu55 = new System.Windows.Forms.CheckBox();
            this.cpu54 = new System.Windows.Forms.CheckBox();
            this.cpu63 = new System.Windows.Forms.CheckBox();
            this.cpu62 = new System.Windows.Forms.CheckBox();
            this.cpu61 = new System.Windows.Forms.CheckBox();
            this.cpu60 = new System.Windows.Forms.CheckBox();
            this.setMask = new System.Windows.Forms.Button();
            this.deleteMask = new System.Windows.Forms.Button();
            this.msiMode = new System.Windows.Forms.CheckBox();
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
            this.title.Size = new System.Drawing.Size(58, 15);
            this.title.TabIndex = 1;
            this.title.Text = "Affinities";
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
            this.topbar.Size = new System.Drawing.Size(400, 25);
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
            this.close.Location = new System.Drawing.Point(380, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // deviceName
            // 
            this.deviceName.AutoSize = true;
            this.deviceName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.deviceName.ForeColor = System.Drawing.Color.White;
            this.deviceName.Location = new System.Drawing.Point(0, 28);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(88, 17);
            this.deviceName.TabIndex = 12;
            this.deviceName.Text = "Device name:";
            // 
            // deviceNameBox
            // 
            this.deviceNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceNameBox.FormattingEnabled = true;
            this.deviceNameBox.Location = new System.Drawing.Point(121, 27);
            this.deviceNameBox.Name = "deviceNameBox";
            this.deviceNameBox.Size = new System.Drawing.Size(279, 21);
            this.deviceNameBox.TabIndex = 13;
            this.deviceNameBox.SelectedIndexChanged += new System.EventHandler(this.deviceNameBox_SelectedIndexChanged);
            // 
            // devicePath
            // 
            this.devicePath.AutoSize = true;
            this.devicePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.devicePath.ForeColor = System.Drawing.Color.White;
            this.devicePath.Location = new System.Drawing.Point(0, 59);
            this.devicePath.Name = "devicePath";
            this.devicePath.Size = new System.Drawing.Size(82, 17);
            this.devicePath.TabIndex = 14;
            this.devicePath.Text = "Device path:";
            // 
            // devicePathLabel
            // 
            this.devicePathLabel.AutoSize = true;
            this.devicePathLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.devicePathLabel.ForeColor = System.Drawing.Color.White;
            this.devicePathLabel.Location = new System.Drawing.Point(118, 59);
            this.devicePathLabel.Name = "devicePathLabel";
            this.devicePathLabel.Size = new System.Drawing.Size(36, 17);
            this.devicePathLabel.TabIndex = 15;
            this.devicePathLabel.Text = "path";
            // 
            // affinityMask
            // 
            this.affinityMask.AutoSize = true;
            this.affinityMask.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.affinityMask.ForeColor = System.Drawing.Color.White;
            this.affinityMask.Location = new System.Drawing.Point(0, 91);
            this.affinityMask.Name = "affinityMask";
            this.affinityMask.Size = new System.Drawing.Size(90, 17);
            this.affinityMask.TabIndex = 16;
            this.affinityMask.Text = "Affinity mask:";
            // 
            // cpu0
            // 
            this.cpu0.AutoSize = true;
            this.cpu0.Enabled = false;
            this.cpu0.ForeColor = System.Drawing.Color.White;
            this.cpu0.Location = new System.Drawing.Point(6, 111);
            this.cpu0.Name = "cpu0";
            this.cpu0.Size = new System.Drawing.Size(57, 17);
            this.cpu0.TabIndex = 17;
            this.cpu0.Text = "CPU 0";
            this.cpu0.UseVisualStyleBackColor = true;
            // 
            // cpu1
            // 
            this.cpu1.AutoSize = true;
            this.cpu1.Enabled = false;
            this.cpu1.ForeColor = System.Drawing.Color.White;
            this.cpu1.Location = new System.Drawing.Point(69, 111);
            this.cpu1.Name = "cpu1";
            this.cpu1.Size = new System.Drawing.Size(57, 17);
            this.cpu1.TabIndex = 18;
            this.cpu1.Text = "CPU 1";
            this.cpu1.UseVisualStyleBackColor = true;
            // 
            // cpu2
            // 
            this.cpu2.AutoSize = true;
            this.cpu2.Enabled = false;
            this.cpu2.ForeColor = System.Drawing.Color.White;
            this.cpu2.Location = new System.Drawing.Point(132, 111);
            this.cpu2.Name = "cpu2";
            this.cpu2.Size = new System.Drawing.Size(57, 17);
            this.cpu2.TabIndex = 19;
            this.cpu2.Text = "CPU 2";
            this.cpu2.UseVisualStyleBackColor = true;
            // 
            // cpu3
            // 
            this.cpu3.AutoSize = true;
            this.cpu3.Enabled = false;
            this.cpu3.ForeColor = System.Drawing.Color.White;
            this.cpu3.Location = new System.Drawing.Point(195, 111);
            this.cpu3.Name = "cpu3";
            this.cpu3.Size = new System.Drawing.Size(57, 17);
            this.cpu3.TabIndex = 20;
            this.cpu3.Text = "CPU 3";
            this.cpu3.UseVisualStyleBackColor = true;
            // 
            // cpu4
            // 
            this.cpu4.AutoSize = true;
            this.cpu4.Enabled = false;
            this.cpu4.ForeColor = System.Drawing.Color.White;
            this.cpu4.Location = new System.Drawing.Point(258, 111);
            this.cpu4.Name = "cpu4";
            this.cpu4.Size = new System.Drawing.Size(57, 17);
            this.cpu4.TabIndex = 21;
            this.cpu4.Text = "CPU 4";
            this.cpu4.UseVisualStyleBackColor = true;
            // 
            // cpu5
            // 
            this.cpu5.AutoSize = true;
            this.cpu5.Enabled = false;
            this.cpu5.ForeColor = System.Drawing.Color.White;
            this.cpu5.Location = new System.Drawing.Point(321, 111);
            this.cpu5.Name = "cpu5";
            this.cpu5.Size = new System.Drawing.Size(57, 17);
            this.cpu5.TabIndex = 22;
            this.cpu5.Text = "CPU 5";
            this.cpu5.UseVisualStyleBackColor = true;
            // 
            // cpu11
            // 
            this.cpu11.AutoSize = true;
            this.cpu11.Enabled = false;
            this.cpu11.ForeColor = System.Drawing.Color.White;
            this.cpu11.Location = new System.Drawing.Point(321, 134);
            this.cpu11.Name = "cpu11";
            this.cpu11.Size = new System.Drawing.Size(63, 17);
            this.cpu11.TabIndex = 28;
            this.cpu11.Text = "CPU 11";
            this.cpu11.UseVisualStyleBackColor = true;
            // 
            // cpu10
            // 
            this.cpu10.AutoSize = true;
            this.cpu10.Enabled = false;
            this.cpu10.ForeColor = System.Drawing.Color.White;
            this.cpu10.Location = new System.Drawing.Point(258, 134);
            this.cpu10.Name = "cpu10";
            this.cpu10.Size = new System.Drawing.Size(63, 17);
            this.cpu10.TabIndex = 27;
            this.cpu10.Text = "CPU 10";
            this.cpu10.UseVisualStyleBackColor = true;
            // 
            // cpu9
            // 
            this.cpu9.AutoSize = true;
            this.cpu9.Enabled = false;
            this.cpu9.ForeColor = System.Drawing.Color.White;
            this.cpu9.Location = new System.Drawing.Point(195, 134);
            this.cpu9.Name = "cpu9";
            this.cpu9.Size = new System.Drawing.Size(57, 17);
            this.cpu9.TabIndex = 26;
            this.cpu9.Text = "CPU 9";
            this.cpu9.UseVisualStyleBackColor = true;
            // 
            // cpu8
            // 
            this.cpu8.AutoSize = true;
            this.cpu8.Enabled = false;
            this.cpu8.ForeColor = System.Drawing.Color.White;
            this.cpu8.Location = new System.Drawing.Point(132, 134);
            this.cpu8.Name = "cpu8";
            this.cpu8.Size = new System.Drawing.Size(57, 17);
            this.cpu8.TabIndex = 25;
            this.cpu8.Text = "CPU 8";
            this.cpu8.UseVisualStyleBackColor = true;
            // 
            // cpu7
            // 
            this.cpu7.AutoSize = true;
            this.cpu7.Enabled = false;
            this.cpu7.ForeColor = System.Drawing.Color.White;
            this.cpu7.Location = new System.Drawing.Point(69, 134);
            this.cpu7.Name = "cpu7";
            this.cpu7.Size = new System.Drawing.Size(57, 17);
            this.cpu7.TabIndex = 24;
            this.cpu7.Text = "CPU 7";
            this.cpu7.UseVisualStyleBackColor = true;
            // 
            // cpu6
            // 
            this.cpu6.AutoSize = true;
            this.cpu6.Enabled = false;
            this.cpu6.ForeColor = System.Drawing.Color.White;
            this.cpu6.Location = new System.Drawing.Point(6, 134);
            this.cpu6.Name = "cpu6";
            this.cpu6.Size = new System.Drawing.Size(57, 17);
            this.cpu6.TabIndex = 23;
            this.cpu6.Text = "CPU 6";
            this.cpu6.UseVisualStyleBackColor = true;
            // 
            // cpu17
            // 
            this.cpu17.AutoSize = true;
            this.cpu17.Enabled = false;
            this.cpu17.ForeColor = System.Drawing.Color.White;
            this.cpu17.Location = new System.Drawing.Point(321, 157);
            this.cpu17.Name = "cpu17";
            this.cpu17.Size = new System.Drawing.Size(63, 17);
            this.cpu17.TabIndex = 34;
            this.cpu17.Text = "CPU 17";
            this.cpu17.UseVisualStyleBackColor = true;
            // 
            // cpu16
            // 
            this.cpu16.AutoSize = true;
            this.cpu16.Enabled = false;
            this.cpu16.ForeColor = System.Drawing.Color.White;
            this.cpu16.Location = new System.Drawing.Point(258, 157);
            this.cpu16.Name = "cpu16";
            this.cpu16.Size = new System.Drawing.Size(63, 17);
            this.cpu16.TabIndex = 33;
            this.cpu16.Text = "CPU 16";
            this.cpu16.UseVisualStyleBackColor = true;
            // 
            // cpu15
            // 
            this.cpu15.AutoSize = true;
            this.cpu15.Enabled = false;
            this.cpu15.ForeColor = System.Drawing.Color.White;
            this.cpu15.Location = new System.Drawing.Point(195, 157);
            this.cpu15.Name = "cpu15";
            this.cpu15.Size = new System.Drawing.Size(63, 17);
            this.cpu15.TabIndex = 32;
            this.cpu15.Text = "CPU 15";
            this.cpu15.UseVisualStyleBackColor = true;
            // 
            // cpu14
            // 
            this.cpu14.AutoSize = true;
            this.cpu14.Enabled = false;
            this.cpu14.ForeColor = System.Drawing.Color.White;
            this.cpu14.Location = new System.Drawing.Point(132, 157);
            this.cpu14.Name = "cpu14";
            this.cpu14.Size = new System.Drawing.Size(63, 17);
            this.cpu14.TabIndex = 31;
            this.cpu14.Text = "CPU 14";
            this.cpu14.UseVisualStyleBackColor = true;
            // 
            // cpu13
            // 
            this.cpu13.AutoSize = true;
            this.cpu13.Enabled = false;
            this.cpu13.ForeColor = System.Drawing.Color.White;
            this.cpu13.Location = new System.Drawing.Point(69, 157);
            this.cpu13.Name = "cpu13";
            this.cpu13.Size = new System.Drawing.Size(63, 17);
            this.cpu13.TabIndex = 30;
            this.cpu13.Text = "CPU 13";
            this.cpu13.UseVisualStyleBackColor = true;
            // 
            // cpu12
            // 
            this.cpu12.AutoSize = true;
            this.cpu12.Enabled = false;
            this.cpu12.ForeColor = System.Drawing.Color.White;
            this.cpu12.Location = new System.Drawing.Point(6, 157);
            this.cpu12.Name = "cpu12";
            this.cpu12.Size = new System.Drawing.Size(63, 17);
            this.cpu12.TabIndex = 29;
            this.cpu12.Text = "CPU 12";
            this.cpu12.UseVisualStyleBackColor = true;
            // 
            // cpu23
            // 
            this.cpu23.AutoSize = true;
            this.cpu23.Enabled = false;
            this.cpu23.ForeColor = System.Drawing.Color.White;
            this.cpu23.Location = new System.Drawing.Point(321, 180);
            this.cpu23.Name = "cpu23";
            this.cpu23.Size = new System.Drawing.Size(63, 17);
            this.cpu23.TabIndex = 40;
            this.cpu23.Text = "CPU 23";
            this.cpu23.UseVisualStyleBackColor = true;
            // 
            // cpu22
            // 
            this.cpu22.AutoSize = true;
            this.cpu22.Enabled = false;
            this.cpu22.ForeColor = System.Drawing.Color.White;
            this.cpu22.Location = new System.Drawing.Point(258, 180);
            this.cpu22.Name = "cpu22";
            this.cpu22.Size = new System.Drawing.Size(63, 17);
            this.cpu22.TabIndex = 39;
            this.cpu22.Text = "CPU 22";
            this.cpu22.UseVisualStyleBackColor = true;
            // 
            // cpu21
            // 
            this.cpu21.AutoSize = true;
            this.cpu21.Enabled = false;
            this.cpu21.ForeColor = System.Drawing.Color.White;
            this.cpu21.Location = new System.Drawing.Point(195, 180);
            this.cpu21.Name = "cpu21";
            this.cpu21.Size = new System.Drawing.Size(63, 17);
            this.cpu21.TabIndex = 38;
            this.cpu21.Text = "CPU 21";
            this.cpu21.UseVisualStyleBackColor = true;
            // 
            // cpu20
            // 
            this.cpu20.AutoSize = true;
            this.cpu20.Enabled = false;
            this.cpu20.ForeColor = System.Drawing.Color.White;
            this.cpu20.Location = new System.Drawing.Point(132, 180);
            this.cpu20.Name = "cpu20";
            this.cpu20.Size = new System.Drawing.Size(63, 17);
            this.cpu20.TabIndex = 37;
            this.cpu20.Text = "CPU 20";
            this.cpu20.UseVisualStyleBackColor = true;
            // 
            // cpu19
            // 
            this.cpu19.AutoSize = true;
            this.cpu19.Enabled = false;
            this.cpu19.ForeColor = System.Drawing.Color.White;
            this.cpu19.Location = new System.Drawing.Point(69, 180);
            this.cpu19.Name = "cpu19";
            this.cpu19.Size = new System.Drawing.Size(63, 17);
            this.cpu19.TabIndex = 36;
            this.cpu19.Text = "CPU 19";
            this.cpu19.UseVisualStyleBackColor = true;
            // 
            // cpu18
            // 
            this.cpu18.AutoSize = true;
            this.cpu18.Enabled = false;
            this.cpu18.ForeColor = System.Drawing.Color.White;
            this.cpu18.Location = new System.Drawing.Point(6, 180);
            this.cpu18.Name = "cpu18";
            this.cpu18.Size = new System.Drawing.Size(63, 17);
            this.cpu18.TabIndex = 35;
            this.cpu18.Text = "CPU 18";
            this.cpu18.UseVisualStyleBackColor = true;
            // 
            // cpu29
            // 
            this.cpu29.AutoSize = true;
            this.cpu29.Enabled = false;
            this.cpu29.ForeColor = System.Drawing.Color.White;
            this.cpu29.Location = new System.Drawing.Point(321, 203);
            this.cpu29.Name = "cpu29";
            this.cpu29.Size = new System.Drawing.Size(63, 17);
            this.cpu29.TabIndex = 46;
            this.cpu29.Text = "CPU 29";
            this.cpu29.UseVisualStyleBackColor = true;
            // 
            // cpu28
            // 
            this.cpu28.AutoSize = true;
            this.cpu28.Enabled = false;
            this.cpu28.ForeColor = System.Drawing.Color.White;
            this.cpu28.Location = new System.Drawing.Point(258, 203);
            this.cpu28.Name = "cpu28";
            this.cpu28.Size = new System.Drawing.Size(63, 17);
            this.cpu28.TabIndex = 45;
            this.cpu28.Text = "CPU 28";
            this.cpu28.UseVisualStyleBackColor = true;
            // 
            // cpu27
            // 
            this.cpu27.AutoSize = true;
            this.cpu27.Enabled = false;
            this.cpu27.ForeColor = System.Drawing.Color.White;
            this.cpu27.Location = new System.Drawing.Point(195, 203);
            this.cpu27.Name = "cpu27";
            this.cpu27.Size = new System.Drawing.Size(63, 17);
            this.cpu27.TabIndex = 44;
            this.cpu27.Text = "CPU 27";
            this.cpu27.UseVisualStyleBackColor = true;
            // 
            // cpu26
            // 
            this.cpu26.AutoSize = true;
            this.cpu26.Enabled = false;
            this.cpu26.ForeColor = System.Drawing.Color.White;
            this.cpu26.Location = new System.Drawing.Point(132, 203);
            this.cpu26.Name = "cpu26";
            this.cpu26.Size = new System.Drawing.Size(63, 17);
            this.cpu26.TabIndex = 43;
            this.cpu26.Text = "CPU 26";
            this.cpu26.UseVisualStyleBackColor = true;
            // 
            // cpu25
            // 
            this.cpu25.AutoSize = true;
            this.cpu25.Enabled = false;
            this.cpu25.ForeColor = System.Drawing.Color.White;
            this.cpu25.Location = new System.Drawing.Point(69, 203);
            this.cpu25.Name = "cpu25";
            this.cpu25.Size = new System.Drawing.Size(63, 17);
            this.cpu25.TabIndex = 42;
            this.cpu25.Text = "CPU 25";
            this.cpu25.UseVisualStyleBackColor = true;
            // 
            // cpu24
            // 
            this.cpu24.AutoSize = true;
            this.cpu24.Enabled = false;
            this.cpu24.ForeColor = System.Drawing.Color.White;
            this.cpu24.Location = new System.Drawing.Point(6, 203);
            this.cpu24.Name = "cpu24";
            this.cpu24.Size = new System.Drawing.Size(63, 17);
            this.cpu24.TabIndex = 41;
            this.cpu24.Text = "CPU 24";
            this.cpu24.UseVisualStyleBackColor = true;
            // 
            // cpu35
            // 
            this.cpu35.AutoSize = true;
            this.cpu35.Enabled = false;
            this.cpu35.ForeColor = System.Drawing.Color.White;
            this.cpu35.Location = new System.Drawing.Point(321, 226);
            this.cpu35.Name = "cpu35";
            this.cpu35.Size = new System.Drawing.Size(63, 17);
            this.cpu35.TabIndex = 52;
            this.cpu35.Text = "CPU 35";
            this.cpu35.UseVisualStyleBackColor = true;
            // 
            // cpu34
            // 
            this.cpu34.AutoSize = true;
            this.cpu34.Enabled = false;
            this.cpu34.ForeColor = System.Drawing.Color.White;
            this.cpu34.Location = new System.Drawing.Point(258, 226);
            this.cpu34.Name = "cpu34";
            this.cpu34.Size = new System.Drawing.Size(63, 17);
            this.cpu34.TabIndex = 51;
            this.cpu34.Text = "CPU 34";
            this.cpu34.UseVisualStyleBackColor = true;
            // 
            // cpu33
            // 
            this.cpu33.AutoSize = true;
            this.cpu33.Enabled = false;
            this.cpu33.ForeColor = System.Drawing.Color.White;
            this.cpu33.Location = new System.Drawing.Point(195, 226);
            this.cpu33.Name = "cpu33";
            this.cpu33.Size = new System.Drawing.Size(63, 17);
            this.cpu33.TabIndex = 50;
            this.cpu33.Text = "CPU 33";
            this.cpu33.UseVisualStyleBackColor = true;
            // 
            // cpu32
            // 
            this.cpu32.AutoSize = true;
            this.cpu32.Enabled = false;
            this.cpu32.ForeColor = System.Drawing.Color.White;
            this.cpu32.Location = new System.Drawing.Point(132, 226);
            this.cpu32.Name = "cpu32";
            this.cpu32.Size = new System.Drawing.Size(63, 17);
            this.cpu32.TabIndex = 49;
            this.cpu32.Text = "CPU 32";
            this.cpu32.UseVisualStyleBackColor = true;
            // 
            // cpu31
            // 
            this.cpu31.AutoSize = true;
            this.cpu31.Enabled = false;
            this.cpu31.ForeColor = System.Drawing.Color.White;
            this.cpu31.Location = new System.Drawing.Point(69, 226);
            this.cpu31.Name = "cpu31";
            this.cpu31.Size = new System.Drawing.Size(63, 17);
            this.cpu31.TabIndex = 48;
            this.cpu31.Text = "CPU 31";
            this.cpu31.UseVisualStyleBackColor = true;
            // 
            // cpu30
            // 
            this.cpu30.AutoSize = true;
            this.cpu30.Enabled = false;
            this.cpu30.ForeColor = System.Drawing.Color.White;
            this.cpu30.Location = new System.Drawing.Point(6, 226);
            this.cpu30.Name = "cpu30";
            this.cpu30.Size = new System.Drawing.Size(63, 17);
            this.cpu30.TabIndex = 47;
            this.cpu30.Text = "CPU 30";
            this.cpu30.UseVisualStyleBackColor = true;
            // 
            // cpu41
            // 
            this.cpu41.AutoSize = true;
            this.cpu41.Enabled = false;
            this.cpu41.ForeColor = System.Drawing.Color.White;
            this.cpu41.Location = new System.Drawing.Point(321, 249);
            this.cpu41.Name = "cpu41";
            this.cpu41.Size = new System.Drawing.Size(63, 17);
            this.cpu41.TabIndex = 58;
            this.cpu41.Text = "CPU 41";
            this.cpu41.UseVisualStyleBackColor = true;
            // 
            // cpu40
            // 
            this.cpu40.AutoSize = true;
            this.cpu40.Enabled = false;
            this.cpu40.ForeColor = System.Drawing.Color.White;
            this.cpu40.Location = new System.Drawing.Point(258, 249);
            this.cpu40.Name = "cpu40";
            this.cpu40.Size = new System.Drawing.Size(63, 17);
            this.cpu40.TabIndex = 57;
            this.cpu40.Text = "CPU 40";
            this.cpu40.UseVisualStyleBackColor = true;
            // 
            // cpu39
            // 
            this.cpu39.AutoSize = true;
            this.cpu39.Enabled = false;
            this.cpu39.ForeColor = System.Drawing.Color.White;
            this.cpu39.Location = new System.Drawing.Point(195, 249);
            this.cpu39.Name = "cpu39";
            this.cpu39.Size = new System.Drawing.Size(63, 17);
            this.cpu39.TabIndex = 56;
            this.cpu39.Text = "CPU 39";
            this.cpu39.UseVisualStyleBackColor = true;
            // 
            // cpu38
            // 
            this.cpu38.AutoSize = true;
            this.cpu38.Enabled = false;
            this.cpu38.ForeColor = System.Drawing.Color.White;
            this.cpu38.Location = new System.Drawing.Point(132, 249);
            this.cpu38.Name = "cpu38";
            this.cpu38.Size = new System.Drawing.Size(63, 17);
            this.cpu38.TabIndex = 55;
            this.cpu38.Text = "CPU 38";
            this.cpu38.UseVisualStyleBackColor = true;
            // 
            // cpu37
            // 
            this.cpu37.AutoSize = true;
            this.cpu37.Enabled = false;
            this.cpu37.ForeColor = System.Drawing.Color.White;
            this.cpu37.Location = new System.Drawing.Point(69, 249);
            this.cpu37.Name = "cpu37";
            this.cpu37.Size = new System.Drawing.Size(63, 17);
            this.cpu37.TabIndex = 54;
            this.cpu37.Text = "CPU 37";
            this.cpu37.UseVisualStyleBackColor = true;
            // 
            // cpu36
            // 
            this.cpu36.AutoSize = true;
            this.cpu36.Enabled = false;
            this.cpu36.ForeColor = System.Drawing.Color.White;
            this.cpu36.Location = new System.Drawing.Point(6, 249);
            this.cpu36.Name = "cpu36";
            this.cpu36.Size = new System.Drawing.Size(63, 17);
            this.cpu36.TabIndex = 53;
            this.cpu36.Text = "CPU 36";
            this.cpu36.UseVisualStyleBackColor = true;
            // 
            // cpu47
            // 
            this.cpu47.AutoSize = true;
            this.cpu47.Enabled = false;
            this.cpu47.ForeColor = System.Drawing.Color.White;
            this.cpu47.Location = new System.Drawing.Point(321, 272);
            this.cpu47.Name = "cpu47";
            this.cpu47.Size = new System.Drawing.Size(63, 17);
            this.cpu47.TabIndex = 64;
            this.cpu47.Text = "CPU 47";
            this.cpu47.UseVisualStyleBackColor = true;
            // 
            // cpu46
            // 
            this.cpu46.AutoSize = true;
            this.cpu46.Enabled = false;
            this.cpu46.ForeColor = System.Drawing.Color.White;
            this.cpu46.Location = new System.Drawing.Point(258, 272);
            this.cpu46.Name = "cpu46";
            this.cpu46.Size = new System.Drawing.Size(63, 17);
            this.cpu46.TabIndex = 63;
            this.cpu46.Text = "CPU 46";
            this.cpu46.UseVisualStyleBackColor = true;
            // 
            // cpu45
            // 
            this.cpu45.AutoSize = true;
            this.cpu45.Enabled = false;
            this.cpu45.ForeColor = System.Drawing.Color.White;
            this.cpu45.Location = new System.Drawing.Point(195, 272);
            this.cpu45.Name = "cpu45";
            this.cpu45.Size = new System.Drawing.Size(63, 17);
            this.cpu45.TabIndex = 62;
            this.cpu45.Text = "CPU 45";
            this.cpu45.UseVisualStyleBackColor = true;
            // 
            // cpu44
            // 
            this.cpu44.AutoSize = true;
            this.cpu44.Enabled = false;
            this.cpu44.ForeColor = System.Drawing.Color.White;
            this.cpu44.Location = new System.Drawing.Point(132, 272);
            this.cpu44.Name = "cpu44";
            this.cpu44.Size = new System.Drawing.Size(63, 17);
            this.cpu44.TabIndex = 61;
            this.cpu44.Text = "CPU 44";
            this.cpu44.UseVisualStyleBackColor = true;
            // 
            // cpu43
            // 
            this.cpu43.AutoSize = true;
            this.cpu43.Enabled = false;
            this.cpu43.ForeColor = System.Drawing.Color.White;
            this.cpu43.Location = new System.Drawing.Point(69, 272);
            this.cpu43.Name = "cpu43";
            this.cpu43.Size = new System.Drawing.Size(63, 17);
            this.cpu43.TabIndex = 60;
            this.cpu43.Text = "CPU 43";
            this.cpu43.UseVisualStyleBackColor = true;
            // 
            // cpu42
            // 
            this.cpu42.AutoSize = true;
            this.cpu42.Enabled = false;
            this.cpu42.ForeColor = System.Drawing.Color.White;
            this.cpu42.Location = new System.Drawing.Point(6, 272);
            this.cpu42.Name = "cpu42";
            this.cpu42.Size = new System.Drawing.Size(63, 17);
            this.cpu42.TabIndex = 59;
            this.cpu42.Text = "CPU 42";
            this.cpu42.UseVisualStyleBackColor = true;
            // 
            // cpu53
            // 
            this.cpu53.AutoSize = true;
            this.cpu53.Enabled = false;
            this.cpu53.ForeColor = System.Drawing.Color.White;
            this.cpu53.Location = new System.Drawing.Point(321, 295);
            this.cpu53.Name = "cpu53";
            this.cpu53.Size = new System.Drawing.Size(63, 17);
            this.cpu53.TabIndex = 70;
            this.cpu53.Text = "CPU 53";
            this.cpu53.UseVisualStyleBackColor = true;
            // 
            // cpu52
            // 
            this.cpu52.AutoSize = true;
            this.cpu52.Enabled = false;
            this.cpu52.ForeColor = System.Drawing.Color.White;
            this.cpu52.Location = new System.Drawing.Point(258, 295);
            this.cpu52.Name = "cpu52";
            this.cpu52.Size = new System.Drawing.Size(63, 17);
            this.cpu52.TabIndex = 69;
            this.cpu52.Text = "CPU 52";
            this.cpu52.UseVisualStyleBackColor = true;
            // 
            // cpu51
            // 
            this.cpu51.AutoSize = true;
            this.cpu51.Enabled = false;
            this.cpu51.ForeColor = System.Drawing.Color.White;
            this.cpu51.Location = new System.Drawing.Point(195, 295);
            this.cpu51.Name = "cpu51";
            this.cpu51.Size = new System.Drawing.Size(63, 17);
            this.cpu51.TabIndex = 68;
            this.cpu51.Text = "CPU 51";
            this.cpu51.UseVisualStyleBackColor = true;
            // 
            // cpu50
            // 
            this.cpu50.AutoSize = true;
            this.cpu50.Enabled = false;
            this.cpu50.ForeColor = System.Drawing.Color.White;
            this.cpu50.Location = new System.Drawing.Point(132, 295);
            this.cpu50.Name = "cpu50";
            this.cpu50.Size = new System.Drawing.Size(63, 17);
            this.cpu50.TabIndex = 67;
            this.cpu50.Text = "CPU 50";
            this.cpu50.UseVisualStyleBackColor = true;
            // 
            // cpu49
            // 
            this.cpu49.AutoSize = true;
            this.cpu49.Enabled = false;
            this.cpu49.ForeColor = System.Drawing.Color.White;
            this.cpu49.Location = new System.Drawing.Point(69, 295);
            this.cpu49.Name = "cpu49";
            this.cpu49.Size = new System.Drawing.Size(63, 17);
            this.cpu49.TabIndex = 66;
            this.cpu49.Text = "CPU 49";
            this.cpu49.UseVisualStyleBackColor = true;
            // 
            // cpu48
            // 
            this.cpu48.AutoSize = true;
            this.cpu48.Enabled = false;
            this.cpu48.ForeColor = System.Drawing.Color.White;
            this.cpu48.Location = new System.Drawing.Point(6, 295);
            this.cpu48.Name = "cpu48";
            this.cpu48.Size = new System.Drawing.Size(63, 17);
            this.cpu48.TabIndex = 65;
            this.cpu48.Text = "CPU 48";
            this.cpu48.UseVisualStyleBackColor = true;
            // 
            // cpu59
            // 
            this.cpu59.AutoSize = true;
            this.cpu59.Enabled = false;
            this.cpu59.ForeColor = System.Drawing.Color.White;
            this.cpu59.Location = new System.Drawing.Point(321, 318);
            this.cpu59.Name = "cpu59";
            this.cpu59.Size = new System.Drawing.Size(63, 17);
            this.cpu59.TabIndex = 76;
            this.cpu59.Text = "CPU 59";
            this.cpu59.UseVisualStyleBackColor = true;
            // 
            // cpu58
            // 
            this.cpu58.AutoSize = true;
            this.cpu58.Enabled = false;
            this.cpu58.ForeColor = System.Drawing.Color.White;
            this.cpu58.Location = new System.Drawing.Point(258, 318);
            this.cpu58.Name = "cpu58";
            this.cpu58.Size = new System.Drawing.Size(63, 17);
            this.cpu58.TabIndex = 75;
            this.cpu58.Text = "CPU 58";
            this.cpu58.UseVisualStyleBackColor = true;
            // 
            // cpu57
            // 
            this.cpu57.AutoSize = true;
            this.cpu57.Enabled = false;
            this.cpu57.ForeColor = System.Drawing.Color.White;
            this.cpu57.Location = new System.Drawing.Point(195, 318);
            this.cpu57.Name = "cpu57";
            this.cpu57.Size = new System.Drawing.Size(63, 17);
            this.cpu57.TabIndex = 74;
            this.cpu57.Text = "CPU 57";
            this.cpu57.UseVisualStyleBackColor = true;
            // 
            // cpu56
            // 
            this.cpu56.AutoSize = true;
            this.cpu56.Enabled = false;
            this.cpu56.ForeColor = System.Drawing.Color.White;
            this.cpu56.Location = new System.Drawing.Point(132, 318);
            this.cpu56.Name = "cpu56";
            this.cpu56.Size = new System.Drawing.Size(63, 17);
            this.cpu56.TabIndex = 73;
            this.cpu56.Text = "CPU 56";
            this.cpu56.UseVisualStyleBackColor = true;
            // 
            // cpu55
            // 
            this.cpu55.AutoSize = true;
            this.cpu55.Enabled = false;
            this.cpu55.ForeColor = System.Drawing.Color.White;
            this.cpu55.Location = new System.Drawing.Point(69, 318);
            this.cpu55.Name = "cpu55";
            this.cpu55.Size = new System.Drawing.Size(63, 17);
            this.cpu55.TabIndex = 72;
            this.cpu55.Text = "CPU 55";
            this.cpu55.UseVisualStyleBackColor = true;
            // 
            // cpu54
            // 
            this.cpu54.AutoSize = true;
            this.cpu54.Enabled = false;
            this.cpu54.ForeColor = System.Drawing.Color.White;
            this.cpu54.Location = new System.Drawing.Point(6, 318);
            this.cpu54.Name = "cpu54";
            this.cpu54.Size = new System.Drawing.Size(63, 17);
            this.cpu54.TabIndex = 71;
            this.cpu54.Text = "CPU 54";
            this.cpu54.UseVisualStyleBackColor = true;
            // 
            // cpu63
            // 
            this.cpu63.AutoSize = true;
            this.cpu63.Enabled = false;
            this.cpu63.ForeColor = System.Drawing.Color.White;
            this.cpu63.Location = new System.Drawing.Point(195, 341);
            this.cpu63.Name = "cpu63";
            this.cpu63.Size = new System.Drawing.Size(63, 17);
            this.cpu63.TabIndex = 80;
            this.cpu63.Text = "CPU 63";
            this.cpu63.UseVisualStyleBackColor = true;
            // 
            // cpu62
            // 
            this.cpu62.AutoSize = true;
            this.cpu62.Enabled = false;
            this.cpu62.ForeColor = System.Drawing.Color.White;
            this.cpu62.Location = new System.Drawing.Point(132, 341);
            this.cpu62.Name = "cpu62";
            this.cpu62.Size = new System.Drawing.Size(63, 17);
            this.cpu62.TabIndex = 79;
            this.cpu62.Text = "CPU 62";
            this.cpu62.UseVisualStyleBackColor = true;
            // 
            // cpu61
            // 
            this.cpu61.AutoSize = true;
            this.cpu61.Enabled = false;
            this.cpu61.ForeColor = System.Drawing.Color.White;
            this.cpu61.Location = new System.Drawing.Point(69, 341);
            this.cpu61.Name = "cpu61";
            this.cpu61.Size = new System.Drawing.Size(63, 17);
            this.cpu61.TabIndex = 78;
            this.cpu61.Text = "CPU 61";
            this.cpu61.UseVisualStyleBackColor = true;
            // 
            // cpu60
            // 
            this.cpu60.AutoSize = true;
            this.cpu60.Enabled = false;
            this.cpu60.ForeColor = System.Drawing.Color.White;
            this.cpu60.Location = new System.Drawing.Point(6, 341);
            this.cpu60.Name = "cpu60";
            this.cpu60.Size = new System.Drawing.Size(63, 17);
            this.cpu60.TabIndex = 77;
            this.cpu60.Text = "CPU 60";
            this.cpu60.UseVisualStyleBackColor = true;
            // 
            // setMask
            // 
            this.setMask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.setMask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.setMask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.setMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setMask.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setMask.ForeColor = System.Drawing.Color.White;
            this.setMask.Location = new System.Drawing.Point(310, 403);
            this.setMask.Name = "setMask";
            this.setMask.Size = new System.Drawing.Size(78, 35);
            this.setMask.TabIndex = 81;
            this.setMask.TabStop = false;
            this.setMask.Text = "Set mask";
            this.setMask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.setMask.UseVisualStyleBackColor = true;
            this.setMask.Click += new System.EventHandler(this.setMask_Click);
            // 
            // deleteMask
            // 
            this.deleteMask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.deleteMask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.deleteMask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.deleteMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMask.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMask.ForeColor = System.Drawing.Color.White;
            this.deleteMask.Location = new System.Drawing.Point(195, 403);
            this.deleteMask.Name = "deleteMask";
            this.deleteMask.Size = new System.Drawing.Size(109, 35);
            this.deleteMask.TabIndex = 82;
            this.deleteMask.TabStop = false;
            this.deleteMask.Text = "Delete mask";
            this.deleteMask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteMask.UseVisualStyleBackColor = true;
            this.deleteMask.Click += new System.EventHandler(this.deleteMask_Click);
            // 
            // msiMode
            // 
            this.msiMode.AutoSize = true;
            this.msiMode.ForeColor = System.Drawing.Color.White;
            this.msiMode.Location = new System.Drawing.Point(114, 414);
            this.msiMode.Name = "msiMode";
            this.msiMode.Size = new System.Drawing.Size(75, 17);
            this.msiMode.TabIndex = 83;
            this.msiMode.Text = "MSI Mode";
            this.msiMode.UseVisualStyleBackColor = true;
            this.msiMode.CheckedChanged += new System.EventHandler(this.msiMode_CheckedChanged);
            // 
            // AffinitiesInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.msiMode);
            this.Controls.Add(this.deleteMask);
            this.Controls.Add(this.setMask);
            this.Controls.Add(this.cpu63);
            this.Controls.Add(this.cpu62);
            this.Controls.Add(this.cpu61);
            this.Controls.Add(this.cpu60);
            this.Controls.Add(this.cpu59);
            this.Controls.Add(this.cpu58);
            this.Controls.Add(this.cpu57);
            this.Controls.Add(this.cpu56);
            this.Controls.Add(this.cpu55);
            this.Controls.Add(this.cpu54);
            this.Controls.Add(this.cpu53);
            this.Controls.Add(this.cpu52);
            this.Controls.Add(this.cpu51);
            this.Controls.Add(this.cpu50);
            this.Controls.Add(this.cpu49);
            this.Controls.Add(this.cpu48);
            this.Controls.Add(this.cpu47);
            this.Controls.Add(this.cpu46);
            this.Controls.Add(this.cpu45);
            this.Controls.Add(this.cpu44);
            this.Controls.Add(this.cpu43);
            this.Controls.Add(this.cpu42);
            this.Controls.Add(this.cpu41);
            this.Controls.Add(this.cpu40);
            this.Controls.Add(this.cpu39);
            this.Controls.Add(this.cpu38);
            this.Controls.Add(this.cpu37);
            this.Controls.Add(this.cpu36);
            this.Controls.Add(this.cpu35);
            this.Controls.Add(this.cpu34);
            this.Controls.Add(this.cpu33);
            this.Controls.Add(this.cpu32);
            this.Controls.Add(this.cpu31);
            this.Controls.Add(this.cpu30);
            this.Controls.Add(this.cpu29);
            this.Controls.Add(this.cpu28);
            this.Controls.Add(this.cpu27);
            this.Controls.Add(this.cpu26);
            this.Controls.Add(this.cpu25);
            this.Controls.Add(this.cpu24);
            this.Controls.Add(this.cpu23);
            this.Controls.Add(this.cpu22);
            this.Controls.Add(this.cpu21);
            this.Controls.Add(this.cpu20);
            this.Controls.Add(this.cpu19);
            this.Controls.Add(this.cpu18);
            this.Controls.Add(this.cpu17);
            this.Controls.Add(this.cpu16);
            this.Controls.Add(this.cpu15);
            this.Controls.Add(this.cpu14);
            this.Controls.Add(this.cpu13);
            this.Controls.Add(this.cpu12);
            this.Controls.Add(this.cpu11);
            this.Controls.Add(this.cpu10);
            this.Controls.Add(this.cpu9);
            this.Controls.Add(this.cpu8);
            this.Controls.Add(this.cpu7);
            this.Controls.Add(this.cpu6);
            this.Controls.Add(this.cpu5);
            this.Controls.Add(this.cpu4);
            this.Controls.Add(this.cpu3);
            this.Controls.Add(this.cpu2);
            this.Controls.Add(this.cpu1);
            this.Controls.Add(this.cpu0);
            this.Controls.Add(this.affinityMask);
            this.Controls.Add(this.devicePathLabel);
            this.Controls.Add(this.devicePath);
            this.Controls.Add(this.deviceNameBox);
            this.Controls.Add(this.deviceName);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AffinitiesInterfaceForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AffinitiesInterfaceForm";
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label deviceName;
        private System.Windows.Forms.ComboBox deviceNameBox;
        private System.Windows.Forms.Label devicePath;
        private System.Windows.Forms.Label devicePathLabel;
        private System.Windows.Forms.Label affinityMask;
        private System.Windows.Forms.CheckBox cpu0;
        private System.Windows.Forms.CheckBox cpu1;
        private System.Windows.Forms.CheckBox cpu2;
        private System.Windows.Forms.CheckBox cpu3;
        private System.Windows.Forms.CheckBox cpu4;
        private System.Windows.Forms.CheckBox cpu5;
        private System.Windows.Forms.CheckBox cpu11;
        private System.Windows.Forms.CheckBox cpu10;
        private System.Windows.Forms.CheckBox cpu9;
        private System.Windows.Forms.CheckBox cpu8;
        private System.Windows.Forms.CheckBox cpu7;
        private System.Windows.Forms.CheckBox cpu6;
        private System.Windows.Forms.CheckBox cpu17;
        private System.Windows.Forms.CheckBox cpu16;
        private System.Windows.Forms.CheckBox cpu15;
        private System.Windows.Forms.CheckBox cpu14;
        private System.Windows.Forms.CheckBox cpu13;
        private System.Windows.Forms.CheckBox cpu12;
        private System.Windows.Forms.CheckBox cpu23;
        private System.Windows.Forms.CheckBox cpu22;
        private System.Windows.Forms.CheckBox cpu21;
        private System.Windows.Forms.CheckBox cpu20;
        private System.Windows.Forms.CheckBox cpu19;
        private System.Windows.Forms.CheckBox cpu18;
        private System.Windows.Forms.CheckBox cpu29;
        private System.Windows.Forms.CheckBox cpu28;
        private System.Windows.Forms.CheckBox cpu27;
        private System.Windows.Forms.CheckBox cpu26;
        private System.Windows.Forms.CheckBox cpu25;
        private System.Windows.Forms.CheckBox cpu24;
        private System.Windows.Forms.CheckBox cpu35;
        private System.Windows.Forms.CheckBox cpu34;
        private System.Windows.Forms.CheckBox cpu33;
        private System.Windows.Forms.CheckBox cpu32;
        private System.Windows.Forms.CheckBox cpu31;
        private System.Windows.Forms.CheckBox cpu30;
        private System.Windows.Forms.CheckBox cpu41;
        private System.Windows.Forms.CheckBox cpu40;
        private System.Windows.Forms.CheckBox cpu39;
        private System.Windows.Forms.CheckBox cpu38;
        private System.Windows.Forms.CheckBox cpu37;
        private System.Windows.Forms.CheckBox cpu36;
        private System.Windows.Forms.CheckBox cpu47;
        private System.Windows.Forms.CheckBox cpu46;
        private System.Windows.Forms.CheckBox cpu45;
        private System.Windows.Forms.CheckBox cpu44;
        private System.Windows.Forms.CheckBox cpu43;
        private System.Windows.Forms.CheckBox cpu42;
        private System.Windows.Forms.CheckBox cpu53;
        private System.Windows.Forms.CheckBox cpu52;
        private System.Windows.Forms.CheckBox cpu51;
        private System.Windows.Forms.CheckBox cpu50;
        private System.Windows.Forms.CheckBox cpu49;
        private System.Windows.Forms.CheckBox cpu48;
        private System.Windows.Forms.CheckBox cpu59;
        private System.Windows.Forms.CheckBox cpu58;
        private System.Windows.Forms.CheckBox cpu57;
        private System.Windows.Forms.CheckBox cpu56;
        private System.Windows.Forms.CheckBox cpu55;
        private System.Windows.Forms.CheckBox cpu54;
        private System.Windows.Forms.CheckBox cpu63;
        private System.Windows.Forms.CheckBox cpu62;
        private System.Windows.Forms.CheckBox cpu61;
        private System.Windows.Forms.CheckBox cpu60;
        private System.Windows.Forms.Button setMask;
        private System.Windows.Forms.Button deleteMask;
        private System.Windows.Forms.CheckBox msiMode;
    }
}