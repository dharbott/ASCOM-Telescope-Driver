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
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SlewAzButton = new System.Windows.Forms.Button();
            this.SlewAltButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Abort = new System.Windows.Forms.Button();
            this.SlewAzAsync = new System.Windows.Forms.Button();
            this.CheckAzm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckAlt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(309, 10);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(72, 23);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(309, 39);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(72, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelDriverId
            // 
            this.labelDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.Sepikascope001.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(12, 40);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(291, 21);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.Sepikascope001.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(248, 19);
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
            this.textBox1.Size = new System.Drawing.Size(369, 86);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 20);
            this.textBox3.TabIndex = 7;
            // 
            // SlewAzButton
            // 
            this.SlewAzButton.Enabled = false;
            this.SlewAzButton.Location = new System.Drawing.Point(271, 28);
            this.SlewAzButton.Name = "SlewAzButton";
            this.SlewAzButton.Size = new System.Drawing.Size(101, 20);
            this.SlewAzButton.TabIndex = 10;
            this.SlewAzButton.Text = "SlewAz (degrees)";
            this.SlewAzButton.UseVisualStyleBackColor = true;
            this.SlewAzButton.Click += new System.EventHandler(this.SlewAzButton_Click);
            // 
            // SlewAltButton
            // 
            this.SlewAltButton.Enabled = false;
            this.SlewAltButton.Location = new System.Drawing.Point(271, 32);
            this.SlewAltButton.Name = "SlewAltButton";
            this.SlewAltButton.Size = new System.Drawing.Size(101, 20);
            this.SlewAltButton.TabIndex = 14;
            this.SlewAltButton.Text = "SlewAlt (degrees)";
            this.SlewAltButton.UseVisualStyleBackColor = true;
            this.SlewAltButton.Click += new System.EventHandler(this.SlewAltButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(188, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(77, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 32);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(77, 20);
            this.textBox6.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Abort);
            this.groupBox1.Controls.Add(this.SlewAzAsync);
            this.groupBox1.Controls.Add(this.CheckAzm);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.SlewAzButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 121);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Azimuth Manual Control";
            // 
            // Abort
            // 
            this.Abort.Enabled = false;
            this.Abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abort.ForeColor = System.Drawing.Color.Red;
            this.Abort.Location = new System.Drawing.Point(271, 80);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(101, 20);
            this.Abort.TabIndex = 13;
            this.Abort.Text = "ABORT SLEW";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // SlewAzAsync
            // 
            this.SlewAzAsync.Enabled = false;
            this.SlewAzAsync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SlewAzAsync.Location = new System.Drawing.Point(271, 54);
            this.SlewAzAsync.Name = "SlewAzAsync";
            this.SlewAzAsync.Size = new System.Drawing.Size(101, 20);
            this.SlewAzAsync.TabIndex = 12;
            this.SlewAzAsync.Text = "SlewAz ASYNC";
            this.SlewAzAsync.UseVisualStyleBackColor = true;
            this.SlewAzAsync.Click += new System.EventHandler(this.SlewAzAsync_Click);
            // 
            // CheckAzm
            // 
            this.CheckAzm.Enabled = false;
            this.CheckAzm.ForeColor = System.Drawing.Color.Green;
            this.CheckAzm.Location = new System.Drawing.Point(86, 28);
            this.CheckAzm.Name = "CheckAzm";
            this.CheckAzm.Size = new System.Drawing.Size(96, 20);
            this.CheckAzm.TabIndex = 11;
            this.CheckAzm.Text = "Poll Azm \"deg\"";
            this.CheckAzm.UseVisualStyleBackColor = true;
            this.CheckAzm.Click += new System.EventHandler(this.CheckAzm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckAlt);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.SlewAltButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 121);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Altitude Manual Control";
            // 
            // CheckAlt
            // 
            this.CheckAlt.Enabled = false;
            this.CheckAlt.Location = new System.Drawing.Point(86, 32);
            this.CheckAlt.Name = "CheckAlt";
            this.CheckAlt.Size = new System.Drawing.Size(96, 20);
            this.CheckAlt.TabIndex = 12;
            this.CheckAlt.Text = "Poll Alt \"deg\"";
            this.CheckAlt.UseVisualStyleBackColor = true;
            this.CheckAlt.Click += new System.EventHandler(this.CheckAlt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 137);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text Commands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Name = "Form1";
            this.Text = "TEMPLATEDEVICETYPE Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SlewAzButton;
        private System.Windows.Forms.Button SlewAltButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CheckAzm;
        private System.Windows.Forms.Button CheckAlt;
        private System.Windows.Forms.Button SlewAzAsync;
        private System.Windows.Forms.Button Abort;
    }
}

