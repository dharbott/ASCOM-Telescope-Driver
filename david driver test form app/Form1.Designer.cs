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
            this.AbortSlew = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SetAzm = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.CheckAzm = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SlewToAltAz = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CheckAlt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SetAzm);
            this.groupBox4.Controls.Add(this.CheckAlt);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.CheckAzm);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 112);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Altitude/Azimuth";
            // 
            // SetAzm
            // 
            this.SetAzm.Enabled = false;
            this.SetAzm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAzm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SetAzm.Location = new System.Drawing.Point(6, 17);
            this.SetAzm.Name = "SetAzm";
            this.SetAzm.Size = new System.Drawing.Size(104, 47);
            this.SetAzm.TabIndex = 22;
            this.SetAzm.Text = "SET Azm \"deg\"\r\nSET Alt \"deg\"";
            this.SetAzm.UseVisualStyleBackColor = true;
            this.SetAzm.Click += new System.EventHandler(this.SetAzm_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(116, 44);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(77, 20);
            this.textBox6.TabIndex = 21;
            // 
            // CheckAzm
            // 
            this.CheckAzm.Enabled = false;
            this.CheckAzm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckAzm.Location = new System.Drawing.Point(199, 18);
            this.CheckAzm.Name = "CheckAzm";
            this.CheckAzm.Size = new System.Drawing.Size(96, 20);
            this.CheckAzm.TabIndex = 19;
            this.CheckAzm.Text = "POLL Azm \"deg\"";
            this.CheckAzm.UseVisualStyleBackColor = true;
            this.CheckAzm.Click += new System.EventHandler(this.CheckAzm_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(77, 20);
            this.textBox5.TabIndex = 18;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.SlewToAltAz);
            this.groupBox5.Controls.Add(this.AbortSlew);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Location = new System.Drawing.Point(307, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 112);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SlewTo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 20);
            this.textBox4.TabIndex = 18;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 20);
            this.textBox3.TabIndex = 15;
            // 
            // CheckAlt
            // 
            this.CheckAlt.Enabled = false;
            this.CheckAlt.Location = new System.Drawing.Point(199, 44);
            this.CheckAlt.Name = "CheckAlt";
            this.CheckAlt.Size = new System.Drawing.Size(96, 20);
            this.CheckAlt.TabIndex = 20;
            this.CheckAlt.Text = "POLL Alt \"deg\"";
            this.CheckAlt.UseVisualStyleBackColor = true;
            this.CheckAlt.Click += new System.EventHandler(this.CheckAlt_Click);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button SlewToAltAz;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SetAzm;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button CheckAzm;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button CheckAlt;
    }
}

