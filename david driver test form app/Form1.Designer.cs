namespace ASCOM.Sepikascope001
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyControl = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SlewAsync = new System.Windows.Forms.Button();
            this.AzimuthInput = new System.Windows.Forms.TextBox();
            this.SlewToAltAz = new System.Windows.Forms.Button();
            this.AbortSlew = new System.Windows.Forms.Button();
            this.AltitudeInput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SetAltAzm = new System.Windows.Forms.Button();
            this.CheckAlt = new System.Windows.Forms.Button();
            this.AltitudeBox = new System.Windows.Forms.TextBox();
            this.CheckAzm = new System.Windows.Forms.Button();
            this.AzimuthBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.keyControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(400, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "SEND RAW;";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(518, 86);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(391, 20);
            this.textBox2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.keyControl);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 288);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alt/Azm Manual Control";
            // 
            // keyControl
            // 
            this.keyControl.Controls.Add(this.label1);
            this.keyControl.Controls.Add(this.trackBar1);
            this.keyControl.Controls.Add(this.button10);
            this.keyControl.Controls.Add(this.button9);
            this.keyControl.Controls.Add(this.button7);
            this.keyControl.Controls.Add(this.button6);
            this.keyControl.Controls.Add(this.button8);
            this.keyControl.Controls.Add(this.button4);
            this.keyControl.Controls.Add(this.button5);
            this.keyControl.Controls.Add(this.button3);
            this.keyControl.Controls.Add(this.button2);
            this.keyControl.Location = new System.Drawing.Point(7, 102);
            this.keyControl.Name = "keyControl";
            this.keyControl.Size = new System.Drawing.Size(301, 180);
            this.keyControl.TabIndex = 20;
            this.keyControl.TabStop = false;
            this.keyControl.Text = "Keyboard Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(150, 50);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(42, 124);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button10.Location = new System.Drawing.Point(99, 97);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(24, 24);
            this.button10.TabIndex = 0;
            this.button10.Text = "y";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button9.ForeColor = System.Drawing.Color.Teal;
            this.button9.Location = new System.Drawing.Point(69, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(24, 24);
            this.button9.TabIndex = 0;
            this.button9.Text = "q";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button7.ForeColor = System.Drawing.Color.Teal;
            this.button7.Location = new System.Drawing.Point(99, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(24, 24);
            this.button7.TabIndex = 0;
            this.button7.Text = "u";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button6.ForeColor = System.Drawing.Color.Green;
            this.button6.Location = new System.Drawing.Point(69, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 24);
            this.button6.TabIndex = 0;
            this.button6.Text = "R";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button8.ForeColor = System.Drawing.Color.Green;
            this.button8.Location = new System.Drawing.Point(39, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(24, 24);
            this.button8.TabIndex = 0;
            this.button8.Text = "x";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button4.ForeColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(99, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 0;
            this.button4.Text = "{";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button5.ForeColor = System.Drawing.Color.Olive;
            this.button5.Location = new System.Drawing.Point(39, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 24);
            this.button5.TabIndex = 0;
            this.button5.Text = "t";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button3.ForeColor = System.Drawing.Color.Olive;
            this.button3.Location = new System.Drawing.Point(69, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 0;
            this.button3.Text = "p";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(39, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 0;
            this.button2.Text = "z";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SlewAsync);
            this.groupBox5.Controls.Add(this.AzimuthInput);
            this.groupBox5.Controls.Add(this.SlewToAltAz);
            this.groupBox5.Controls.Add(this.AbortSlew);
            this.groupBox5.Controls.Add(this.AltitudeInput);
            this.groupBox5.Location = new System.Drawing.Point(307, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 76);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SlewTo";
            // 
            // SlewAsync
            // 
            this.SlewAsync.Enabled = false;
            this.SlewAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlewAsync.ForeColor = System.Drawing.Color.Fuchsia;
            this.SlewAsync.Location = new System.Drawing.Point(93, 42);
            this.SlewAsync.Name = "SlewAsync";
            this.SlewAsync.Size = new System.Drawing.Size(143, 20);
            this.SlewAsync.TabIndex = 19;
            this.SlewAsync.Text = "SLEW ALT AZ ASYNC";
            this.SlewAsync.UseVisualStyleBackColor = true;
            this.SlewAsync.Click += new System.EventHandler(this.SlewAsync_Click);
            // 
            // AzimuthInput
            // 
            this.AzimuthInput.ForeColor = System.Drawing.Color.Red;
            this.AzimuthInput.Location = new System.Drawing.Point(10, 43);
            this.AzimuthInput.Name = "AzimuthInput";
            this.AzimuthInput.Size = new System.Drawing.Size(77, 20);
            this.AzimuthInput.TabIndex = 18;
            // 
            // SlewToAltAz
            // 
            this.SlewToAltAz.Enabled = false;
            this.SlewToAltAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlewToAltAz.ForeColor = System.Drawing.Color.Blue;
            this.SlewToAltAz.Location = new System.Drawing.Point(93, 16);
            this.SlewToAltAz.Name = "SlewToAltAz";
            this.SlewToAltAz.Size = new System.Drawing.Size(143, 20);
            this.SlewToAltAz.TabIndex = 17;
            this.SlewToAltAz.Text = "SLEW ALT AZ SYNC";
            this.SlewToAltAz.UseVisualStyleBackColor = true;
            this.SlewToAltAz.Click += new System.EventHandler(this.SlewToAltAz_Click);
            // 
            // AbortSlew
            // 
            this.AbortSlew.Enabled = false;
            this.AbortSlew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbortSlew.ForeColor = System.Drawing.Color.Red;
            this.AbortSlew.Location = new System.Drawing.Point(242, 43);
            this.AbortSlew.Name = "AbortSlew";
            this.AbortSlew.Size = new System.Drawing.Size(101, 20);
            this.AbortSlew.TabIndex = 13;
            this.AbortSlew.Text = "ABORT SLEW";
            this.AbortSlew.UseVisualStyleBackColor = true;
            this.AbortSlew.Click += new System.EventHandler(this.AbortSlew_Click);
            // 
            // AltitudeInput
            // 
            this.AltitudeInput.ForeColor = System.Drawing.Color.Red;
            this.AltitudeInput.Location = new System.Drawing.Point(10, 17);
            this.AltitudeInput.Name = "AltitudeInput";
            this.AltitudeInput.Size = new System.Drawing.Size(77, 20);
            this.AltitudeInput.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SetAltAzm);
            this.groupBox4.Controls.Add(this.CheckAlt);
            this.groupBox4.Controls.Add(this.AltitudeBox);
            this.groupBox4.Controls.Add(this.CheckAzm);
            this.groupBox4.Controls.Add(this.AzimuthBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 76);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Altitude/Azimuth";
            // 
            // SetAltAzm
            // 
            this.SetAltAzm.Enabled = false;
            this.SetAltAzm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAltAzm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SetAltAzm.Location = new System.Drawing.Point(6, 17);
            this.SetAltAzm.Name = "SetAltAzm";
            this.SetAltAzm.Size = new System.Drawing.Size(104, 47);
            this.SetAltAzm.TabIndex = 22;
            this.SetAltAzm.Text = "SET ALT\r\nSET AZM \"deg\"";
            this.SetAltAzm.UseVisualStyleBackColor = true;
            this.SetAltAzm.Click += new System.EventHandler(this.SetAzm_Click);
            // 
            // CheckAlt
            // 
            this.CheckAlt.Enabled = false;
            this.CheckAlt.Location = new System.Drawing.Point(199, 17);
            this.CheckAlt.Name = "CheckAlt";
            this.CheckAlt.Size = new System.Drawing.Size(96, 20);
            this.CheckAlt.TabIndex = 20;
            this.CheckAlt.Text = "POLL Alt \"deg\"";
            this.CheckAlt.UseVisualStyleBackColor = true;
            this.CheckAlt.Click += new System.EventHandler(this.CheckAlt_Click);
            // 
            // AltitudeBox
            // 
            this.AltitudeBox.ForeColor = System.Drawing.Color.Green;
            this.AltitudeBox.Location = new System.Drawing.Point(116, 17);
            this.AltitudeBox.Name = "AltitudeBox";
            this.AltitudeBox.Size = new System.Drawing.Size(77, 20);
            this.AltitudeBox.TabIndex = 21;
            this.AltitudeBox.Text = "Altitude";
            // 
            // CheckAzm
            // 
            this.CheckAzm.Enabled = false;
            this.CheckAzm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckAzm.Location = new System.Drawing.Point(199, 43);
            this.CheckAzm.Name = "CheckAzm";
            this.CheckAzm.Size = new System.Drawing.Size(96, 20);
            this.CheckAzm.TabIndex = 19;
            this.CheckAzm.Text = "POLL Azm \"deg\"";
            this.CheckAzm.UseVisualStyleBackColor = true;
            this.CheckAzm.Click += new System.EventHandler(this.CheckAzm_Click);
            // 
            // AzimuthBox
            // 
            this.AzimuthBox.ForeColor = System.Drawing.Color.Green;
            this.AzimuthBox.Location = new System.Drawing.Point(116, 43);
            this.AzimuthBox.Name = "AzimuthBox";
            this.AzimuthBox.Size = new System.Drawing.Size(77, 20);
            this.AzimuthBox.TabIndex = 18;
            this.AzimuthBox.Text = "Azimuth";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 137);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual Text Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Controls.Add(this.labelDriverId);
            this.groupBox2.Controls.Add(this.buttonChoose);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 43);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telescope Driver";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Blue;
            this.buttonConnect.Location = new System.Drawing.Point(423, 16);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(98, 20);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelDriverId
            // 
            this.labelDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.Sepikascope001.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(3, 16);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(332, 20);
            this.labelDriverId.TabIndex = 3;
            this.labelDriverId.Text = global::ASCOM.Sepikascope001.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoose.Location = new System.Drawing.Point(344, 16);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(73, 20);
            this.buttonChoose.TabIndex = 4;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.trackBar2);
            this.groupBox6.Controls.Add(this.button11);
            this.groupBox6.Controls.Add(this.button12);
            this.groupBox6.Controls.Add(this.button13);
            this.groupBox6.Controls.Add(this.button14);
            this.groupBox6.Controls.Add(this.button15);
            this.groupBox6.Controls.Add(this.button16);
            this.groupBox6.Controls.Add(this.button17);
            this.groupBox6.Controls.Add(this.button18);
            this.groupBox6.Controls.Add(this.button19);
            this.groupBox6.Location = new System.Drawing.Point(306, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(301, 180);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Keyboard Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(150, 50);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(42, 124);
            this.trackBar2.TabIndex = 21;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button11.Location = new System.Drawing.Point(99, 97);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(24, 24);
            this.button11.TabIndex = 0;
            this.button11.Text = "y";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button12.ForeColor = System.Drawing.Color.Teal;
            this.button12.Location = new System.Drawing.Point(69, 97);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(24, 24);
            this.button12.TabIndex = 0;
            this.button12.Text = "q";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button13.ForeColor = System.Drawing.Color.Teal;
            this.button13.Location = new System.Drawing.Point(99, 67);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(24, 24);
            this.button13.TabIndex = 0;
            this.button13.Text = "u";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button14.ForeColor = System.Drawing.Color.Green;
            this.button14.Location = new System.Drawing.Point(69, 67);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(24, 24);
            this.button14.TabIndex = 0;
            this.button14.Text = "R";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button15.ForeColor = System.Drawing.Color.Green;
            this.button15.Location = new System.Drawing.Point(39, 97);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(24, 24);
            this.button15.TabIndex = 0;
            this.button15.Text = "x";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button16.ForeColor = System.Drawing.Color.Green;
            this.button16.Location = new System.Drawing.Point(99, 37);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(24, 24);
            this.button16.TabIndex = 0;
            this.button16.Text = "{";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button17.ForeColor = System.Drawing.Color.Olive;
            this.button17.Location = new System.Drawing.Point(39, 67);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(24, 24);
            this.button17.TabIndex = 0;
            this.button17.Text = "t";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button18.ForeColor = System.Drawing.Color.Olive;
            this.button18.Location = new System.Drawing.Point(69, 37);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(24, 24);
            this.button18.TabIndex = 0;
            this.button18.Text = "p";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button19.ForeColor = System.Drawing.Color.Maroon;
            this.button19.Location = new System.Drawing.Point(39, 37);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(24, 24);
            this.button19.TabIndex = 0;
            this.button19.Text = "z";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TEMPLATEDEVICETYPE Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.keyControl.ResumeLayout(false);
            this.keyControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AbortSlew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox AzimuthInput;
        private System.Windows.Forms.Button SlewToAltAz;
        private System.Windows.Forms.TextBox AltitudeInput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SetAltAzm;
        private System.Windows.Forms.TextBox AltitudeBox;
        private System.Windows.Forms.Button CheckAzm;
        private System.Windows.Forms.TextBox AzimuthBox;
        private System.Windows.Forms.Button CheckAlt;
        private System.Windows.Forms.Button SlewAsync;
        private System.Windows.Forms.GroupBox keyControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}

