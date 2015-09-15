using System;
using System.Windows.Forms;

namespace ASCOM.Sepikascope001
{
    public partial class Form1 : Form
    {

        private ASCOM.DriverAccess.Telescope driver;

        public Form1()
        {
            InitializeComponent();
            SetUIState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConnected)
                driver.Connected = false;

            Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DriverId = ASCOM.DriverAccess.Telescope.Choose(Properties.Settings.Default.DriverId);
            SetUIState();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                driver.Connected = false;
            }
            else
            {
                driver = new ASCOM.DriverAccess.Telescope(Properties.Settings.Default.DriverId);
                driver.Connected = true;
                textBox1.Text = "";

                //AzimuthBox.Text = driver.Azimuth.ToString();
                //AltitudeBox.Text = driver.Altitude.ToString();
            }
            SetUIState();
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
            button1.Enabled = IsConnected;
            CheckAzm.Enabled = IsConnected;
            CheckAlt.Enabled = IsConnected;
            SlewToAltAz.Enabled = IsConnected;
            AbortSlew.Enabled = IsConnected;
            SetAltAzm.Enabled = IsConnected;

        }

        private bool IsConnected
        {
            get
            {
                return ((this.driver != null) && (driver.Connected == true));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ';' };
            string[] words = textBox2.Text.Split(delimiterChars);

            foreach (string s in words)
            {
                if (s.Length > 0)
                    textBox1.Text += driver.CommandString(s, false);                
            }
        }


        //this function takes a literal string of chars
        //and converts it to hexadecimal which is comprised of 2 byte

        /**
         * ASCII TABLE
         * numbers 0-9 are hex values : 30 - 39
         * upper case letters are : 41 - 5A
         * lower case letters are : 61 - 7A
         * 
         * Chars are 16-bit Unicode, also encoded as 2 HEX digits
         * char[] chars = new char[4];            
         * chars[0] = 'X';        // Character literal
         * chars[1] = '\x0058';   // Hexadecimal
         * chars[2] = (char)88;   // Cast from integral type
         * chars[3] = '\u0058';   // Unicode 
         * foreach (char c in chars)
         * {    
         *      Console.Write(c + " ");
         * }
         * // Output: X X X X
         * 
         * */
        

        private void CheckAzm_Click(object sender, EventArgs e)
        {            
            AzimuthBox.Text = driver.Azimuth.ToString();            
        }

        private void CheckAlt_Click(object sender, EventArgs e)
        {
            AltitudeBox.Text = driver.Altitude.ToString();
        }


        private void SlewToAltAz_Click(object sender, EventArgs e)
        {
            double AltitudeIn = Convert.ToDouble(AltitudeInput.Text);
            double AzimuthIn = Convert.ToDouble(AzimuthInput.Text);

            if (((0.0 <= AltitudeIn) && (AltitudeIn <= 360.0)) &&
                ((0.0 <= AzimuthIn) && (AzimuthIn <= 360.0)))
            {
                driver.SlewToAltAz(AzimuthIn, AltitudeIn);
            }

            AzimuthBox.Text = driver.Azimuth.ToString();
            AltitudeBox.Text = driver.Altitude.ToString();
        }

        private void AbortSlew_Click(object sender, EventArgs e)
        {
            string stringOutgoing = "3";
            string stringIncoming = "";

            double param1 = Convert.ToDouble(AltitudeInput.Text);
            double param2 = Convert.ToDouble(AzimuthInput.Text);

            ushort shortParam1 = Convert.ToUInt16(param1 * 60.0);
            byte[] byteArray1 = BitConverter.GetBytes(shortParam1);
            ushort shortParam2 = Convert.ToUInt16(param2 * 60.0);
            byte[] byteArray2 = BitConverter.GetBytes(shortParam2);

            byte[] output = new byte[byteArray1.Length + byteArray2.Length];

            byteArray1.CopyTo(output, 0);
            byteArray2.CopyTo(output, byteArray1.Length);


            //converts from 2 bytes, into unicode 16bit, thus 2 byte
            //converts one character at a time
            for (int i = 0; i < output.Length; i = i + 2)
            {
                stringOutgoing += BitConverter.ToChar(output, i);
            }

            stringOutgoing += "~";

            stringIncoming = driver.CommandString(stringOutgoing, true);

            textBox1.Text += stringIncoming;

            //driver.AbortSlew();
        }

        private void SetAzm_Click(object sender, EventArgs e)
        {
            double param1 = Convert.ToDouble(AltitudeBox.Text);
            double param2 = Convert.ToDouble(AzimuthBox.Text);

            if (((0.0 <= param1) && (param1 <= 360.0)) &&
                ((0.0 <= param2) && (param2 <= 360.0)))
            {
                driver.SyncToAltAz(param1, param2);
            }

            AzimuthBox.Text = driver.Azimuth.ToString();
            AltitudeBox.Text = driver.Altitude.ToString();
        }
    }
}
