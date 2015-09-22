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
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 175);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alt/Azm Manual Control";
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
            this.groupBox5.Size = new System.Drawing.Size(359, 112);
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
            this.AbortSlew.Location = new System.Drawing.Point(93, 68);
            this.AbortSlew.Name = "AbortSlew";
            this.AbortSlew.Size = new System.Drawing.Size(143, 20);
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
            this.groupBox4.Size = new System.Drawing.Size(305, 112);
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
            this.ClientSize = new System.Drawing.Size(696, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TEMPLATEDEVICETYPE Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
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
    }
}

