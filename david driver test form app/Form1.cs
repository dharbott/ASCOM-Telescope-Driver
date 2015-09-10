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
            }
            SetUIState();

            textBox5.Text = driver.Azimuth.ToString();
            textBox6.Text = driver.Altitude.ToString();
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
            button1.Enabled = IsConnected;
            //SlewAltButton.Enabled = IsConnected;
            //SlewAzButton.Enabled = IsConnected;
            CheckAzm.Enabled = IsConnected;
            CheckAlt.Enabled = IsConnected;
            SlewToAltAz.Enabled = IsConnected;
            AbortSlew.Enabled = IsConnected;

            //this.button2.Click += new System.EventHandler(this.button2_Click);
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

        /**
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] testBytes = new byte[] {100, 100, 100, 100};
            String retval = BitConverter.ToString(testBytes).Replace("-", "");
            //System.Text.Encoding.Default.GetString()
            //argggg MoveAxis doesn't return anything, so there's no feedback to check the code!!!
            //driver.MoveAxis(DeviceInterface.TelescopeAxes.axisPrimary, float.Parse(textBox3.Text));
            textBox3.Text = driver.Name;
            //


            //textBox3.Text = driver.CommandString(testBytes, true);
        }
        **/
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            //byte[] testing = StringToByteArray("ABCD");
            //byte[] testing = StringToByteArray("EFGH");
            
            //foreach (byte element in testing)
            //{
                //must transform each byte into char
                //textBox4.Text = textBox4.Text + " " + (char)element;
            //}
            

            //textBox4.Text = textBox4.Text + " : " + BitConverter.ToString(testing).Replace("-", "");
            textBox4.Text = ParamFormatter(0.002);
        }
    **/  
        /**
        private String ParamFormatter(double param1)
        {
            float singleFloat = Convert.ToSingle(param1);
            byte[] byteArray = BitConverter.GetBytes(singleFloat);            
            //return BitConverter.ToString(byteArray).Replace("-", "");


            //the char16 for PI is 0x 03 C0, which is 0000 0011 1100 0000
            //that means encoding is backwards...?
            byteArray[2] = 0x03;    //0000 0011
            byteArray[3] = 0xC0;    //1100 0000

           

            // Summary (edited):
            //     Indicates the byte order ("endianness") in which data is stored in this computer
            //     architecture. BYTE ORDER IS IMPORTANT, especially when going across 
            //     different microcontroller systems
            char testchar, testchar2;

            if (BitConverter.IsLittleEndian)
            {
                //Little-Endian Byte Encoding - so in actuality, it's stored as 0x C4 03
                //because bytes grow from right-to-left byte-by-byte
                //but within each byte it is stored from left-to-right bit-by-bit
                //the char16 for TAU is 0x 03 C4, which is 0000 0011 1100 0100

                //LittleEndian Proper
                byteArray[2] = 0xC4;    //1100 0100
                byteArray[3] = 0x03;    //0000 0011
            }
            else
            {
                //Big-Endian Byte Encoding - so in actuality, it's stored as 0x 03 C4
                //as it is read by human eyes
                //the char16 for TAU is 0x 03 C4, which is 0000 0011 1100 0100
                byteArray[2] = 0x03;    //0000 0011
                byteArray[3] = 0xC4;    //1100 0100
            }

            testchar = BitConverter.ToChar(byteArray, 0);
            testchar2 = BitConverter.ToChar(byteArray, 2);

            //String testString = new String();

            return "ParamFormatter1 : TAU = " + testchar2;
            //String temp =
            //byte[] byteArray = Convert.ToByte(singleFloat)///new byte[4] {1,1,1,1};

            //return byteArray[0].ToString(); //returns "System.Byte[]"  ... why?           
        }
        **/

        //this function takes a literal string of chars
        //and converts it to hexadecimal which is comprised of 2 c

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
        
        /**
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        **/

        private void SlewAzButton_Click(object sender, EventArgs e)
        {
            double param1 = Convert.ToDouble(textBox3.Text);
            double param2 = Convert.ToDouble(textBox4.Text);

            /***

            textBox1.Text += param1;
            textBox1.Text += "_|_";
            textBox1.Text += Convert.ToUInt16(param1 * 60.0);
            textBox1.Text += "_|_";

            ushort param11 = Convert.ToUInt16(param1 * 60.0);
            ushort param12 = Convert.ToUInt16(param2 * 60.0);

            ushort[] myusarray = new ushort[4];
            myusarray[0] = param11;
            myusarray[1] = param12;

            

            string output = "1" + param11;
            output += param12 + ";";

            textBox1.Text += param11;
            textBox1.Text += "_|_"; 
            textBox1.Text += param12;
            textBox1.Text += "_|_";
            textBox1.Text += output;
            textBox1.Text += "_|_";

            byte[] param11b = BitConverter.GetBytes(param11);
            char param11bch = BitConverter.ToChar(param11b,0);

            textBox1.Text += param11bch;
            textBox1.Text += "_|_";

            ***/

            int i = 0;
            short shortParam1 = Convert.ToInt16(param1 * 60.0);
            short shortParam2 = Convert.ToInt16(param2 * 60.0);
            byte[] byteArray1 = BitConverter.GetBytes(shortParam1);
            byte[] byteArray2 = BitConverter.GetBytes(shortParam2);
            byte[] outputbytes = new byte[byteArray1.Length + byteArray2.Length];

            byteArray1.CopyTo(outputbytes, 0);
            byteArray2.CopyTo(outputbytes, byteArray1.Length);

            string stringOutgoing = "";
            stringOutgoing += "1";

            if (((0.0 <= param1) && (param1 <= 360.0)) &&
                ((0.0 <= param2) && (param2 <= 360.0)))
            {               //converts from 2 bytes, into unicode 16bit, thus 2 byte
                //converts one character at a time
                for (i = 0; i < outputbytes.Length; i = i + 2)
                {
                    stringOutgoing += BitConverter.ToChar(outputbytes, i);
                }

                stringOutgoing += ";";

                textBox1.Text += " || ";
                textBox1.Text += driver.CommandString(stringOutgoing, true);

                //driver.SlewToAltAz(param1, param2);
            } 

        }


        private void SlewAltButton_Click(object sender, EventArgs e)
        {
            //driver.SlewToAltAz(param1, param2);

            //textBox4.Text = (Convert.ToInt16(param1)).ToString();
            
        }

        private void CheckAzm_Click(object sender, EventArgs e)
        {
            
            textBox5.Text = driver.Azimuth.ToString();
            
        }

        private void CheckAlt_Click(object sender, EventArgs e)
        {
            textBox6.Text = driver.Altitude.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void SlewToAltAz_Click(object sender, EventArgs e)
        {
            double param1 = Convert.ToDouble(textBox3.Text);
            double param2 = Convert.ToDouble(textBox4.Text);

            if (((0.0 <= param1) && (param1 <= 360.0)) &&
                ((0.0 <= param2) && (param2 <= 360.0)))
            {
                driver.SlewToAltAz(param1, param2);
            }

            textBox5.Text = driver.Azimuth.ToString();
            textBox6.Text = driver.Altitude.ToString();
        }

        private void AbortSlew_Click(object sender, EventArgs e)
        {
            driver.AbortSlew();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetAzm_Click(object sender, EventArgs e)
        {
            //driver.SyncToAltAz
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SlewAzButton_Click_1(object sender, EventArgs e)
        {

        }

        private void SlewAltButton_Click_1(object sender, EventArgs e)
        {

        }


        /*
        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
            }
        }
         * */
    }
}
