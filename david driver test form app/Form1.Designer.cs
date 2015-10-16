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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.MVXS_DownRight = new System.Windows.Forms.Button();
            this.MVXS_Down = new System.Windows.Forms.Button();
            this.MVXS_Right = new System.Windows.Forms.Button();
            this.MVXS_Halt = new System.Windows.Forms.Button();
            this.MVXS_DownLeft = new System.Windows.Forms.Button();
            this.MVXS_UpRight = new System.Windows.Forms.Button();
            this.MVXS_Left = new System.Windows.Forms.Button();
            this.MVXS_Up = new System.Windows.Forms.Button();
            this.MVXS_UpLeft = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.keyControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.trackBar2);
            this.groupBox6.Controls.Add(this.MVXS_DownRight);
            this.groupBox6.Controls.Add(this.MVXS_Down);
            this.groupBox6.Controls.Add(this.MVXS_Right);
            this.groupBox6.Controls.Add(this.MVXS_Halt);
            this.groupBox6.Controls.Add(this.MVXS_DownLeft);
            this.groupBox6.Controls.Add(this.MVXS_UpRight);
            this.groupBox6.Controls.Add(this.MVXS_Left);
            this.groupBox6.Controls.Add(this.MVXS_Up);
            this.groupBox6.Controls.Add(this.MVXS_UpLeft);
            this.groupBox6.Location = new System.Drawing.Point(306, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(301, 180);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Move Axis Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Deg/Sec";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 8;
            this.trackBar2.Location = new System.Drawing.Point(150, 50);
            this.trackBar2.Maximum = 32;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(42, 124);
            this.trackBar2.SmallChange = 2;
            this.trackBar2.TabIndex = 21;
            this.trackBar2.TickFrequency = 2;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // MVXS_DownRight
            // 
            this.MVXS_DownRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVXS_DownRight.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MVXS_DownRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MVXS_DownRight.Location = new System.Drawing.Point(99, 97);
            this.MVXS_DownRight.Name = "MVXS_DownRight";
            this.MVXS_DownRight.Size = new System.Drawing.Size(24, 24);
            this.MVXS_DownRight.TabIndex = 0;
            this.MVXS_DownRight.Text = "y";
            this.MVXS_DownRight.UseVisualStyleBackColor = true;
            // 
            // MVXS_Down
            // 
            this.MVXS_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVXS_Down.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MVXS_Down.ForeColor = System.Drawing.Color.Teal;
            this.MVXS_Down.Location = new System.Drawing.Point(69, 97);
            this.MVXS_Down.Name = "MVXS_Down";
            this.MVXS_Down.Size = new System.Drawing.Size(24, 24);
            this.MVXS_Down.TabIndex = 0;
            this.MVXS_Down.Text = "q";
            this.MVXS_Down.UseVisualStyleBackColor = true;
            // 
            // MVXS_Right
            // 
            this.MVXS_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVXS_Right.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MVXS_Right.ForeColor = System.Drawing.Color.Teal;
            this.MVXS_Right.Location = new System.Drawing.Point(99, 67);
            this.MVXS_Right.Name = "MVXS_Right";
            this.MVXS_Right.Size = new System.Drawing.Size(24, 24);
            this.MVXS_Right.TabIndex = 0;
            this.MVXS_Right.Text = "u";
            this.MVXS_Right.UseVisualStyleBackColor = true;
            this.MVXS_Right.Click += new System.EventHandler(this.MVXS_Right_Click);
            // 
            // MVXS_Halt
            // 
            this.MVXS_Halt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVXS_Halt.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MVXS_Halt.ForeColor = System.Drawing.Color.Green;
            this.MVXS_Halt.Location = new System.Drawing.Point(69, 67);
            this.MVXS_Halt.Name = "MVXS_Halt";
            this.MVXS_Halt.Size = new System.Drawing.Size(24, 24);
            this.MVXS_Halt.TabIndex = 0;
            this.MVXS_Halt.Text = "R";
            this.MVXS_Halt.UseVisualStyleBackColor = true;
            this.MVXS_Halt.Click += new System.EventHandler(this.MVXS_Halt_Click);
            // 
            // MVXS_DownLeft
            // 
            this.MVXS_DownLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVXS_DownLeft.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MVXS_DownLeft.ForeColor = System.Drawing.Color.Green;
            this.MVXS_DownLeft.Location = new System.Drawing.Point(39, 97);
            this.MVXS_DownLeft.Name = "MVXS_DownLeft";
            this.MVXS_DownLeft.Size = new System.Drawing.Size(24, 24);
            this.MVXS_DownLeft.TabIndex = 0;
            this.MVXS_DownLeft.Text = "x";
            this.MVXS_DownLeft.UseVisualStyleBackColor = true;
            // 
            // MVXS_UpRight
            // 
            this.MVXS_UpRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVXS_UpRight.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MVXS_UpRight.ForeColor = System.Drawing.Color.Green;
            this.MVXS_UpRight.Location = new System.Drawing.Point(99, 37);
            this.MVXS_UpRight.Name = "MVXS_UpRight";
            this.MVXS_UpRight.Size = new System.Drawing.Size(24, 24);
            this.MVXS_UpRight.TabIndex = 0;
            this.MVXS_UpRight.Text = "{";
            this.MVXS_UpRight.UseVisualStyleBackColor = true;
            // 
            // MVXS_Left
            // 
            this.MVXS_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVXS_Left.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MVXS_Left.ForeColor = System.Drawing.Color.Olive;
            this.MVXS_Left.Location = new System.Drawing.Point(39, 67);
            this.MVXS_Left.Name = "MVXS_Left";
            this.MVXS_Left.Size = new System.Drawing.Size(24, 24);
            this.MVXS_Left.TabIndex = 0;
            this.MVXS_Left.Text = "t";
            this.MVXS_Left.UseVisualStyleBackColor = true;
            this.MVXS_Left.Click += new System.EventHandler(this.MVXS_Left_Click);
            // 
            // MVXS_Up
            // 
            this.MVXS_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVXS_Up.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MVXS_Up.ForeColor = System.Drawing.Color.Olive;
            this.MVXS_Up.Location = new System.Drawing.Point(69, 37);
            this.MVXS_Up.Name = "MVXS_Up";
            this.MVXS_Up.Size = new System.Drawing.Size(24, 24);
            this.MVXS_Up.TabIndex = 0;
            this.MVXS_Up.Text = "p";
            this.MVXS_Up.UseVisualStyleBackColor = true;
            // 
            // MVXS_UpLeft
            // 
            this.MVXS_UpLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVXS_UpLeft.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MVXS_UpLeft.ForeColor = System.Drawing.Color.Maroon;
            this.MVXS_UpLeft.Location = new System.Drawing.Point(39, 37);
            this.MVXS_UpLeft.Name = "MVXS_UpLeft";
            this.MVXS_UpLeft.Size = new System.Drawing.Size(24, 24);
            this.MVXS_UpLeft.TabIndex = 0;
            this.MVXS_UpLeft.Text = "z";
            this.MVXS_UpLeft.UseVisualStyleBackColor = true;
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
            this.keyControl.Text = "Move Axis Degrees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Degrees";
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
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
        private System.Windows.Forms.Button MVXS_DownRight;
        private System.Windows.Forms.Button MVXS_Down;
        private System.Windows.Forms.Button MVXS_Right;
        private System.Windows.Forms.Button MVXS_Halt;
        private System.Windows.Forms.Button MVXS_DownLeft;
        private System.Windows.Forms.Button MVXS_UpRight;
        private System.Windows.Forms.Button MVXS_Left;
        private System.Windows.Forms.Button MVXS_Up;
        private System.Windows.Forms.Button MVXS_UpLeft;
    }
}

