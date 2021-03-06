//tabs=4

// REMEMBER - Platform Target should be x64
// --------------------------------------------------------------------------------
// TODO fill in this information for your driver, then remove this line!
//
// ASCOM Telescope driver for Sepikascope001
//
// Description:	This is my telescope driver. The hardware it communicates with is
//              an Arduino, which relays motor actions to a pair of motor drivers,
//              and polls the 12-bit magnetic rotary encoders for angular position.
//              The system runs off of 12v sealed lead acid batteries, and is moved
//              by a pair of small 12v 2.5Watt motors. The worm and worm gears are
//              3D printed, and are enclosed/framed with lasercut plates.
//
// Implements:	ASCOM Telescope interface version: <1.0.1>
// Author:		David Harbottle <dharbott@gmail.com>
//
// Edit Log:
//
// Date			Who	Vers	Description
// -----------	---	-----	-------------------------------------------------------
// 14-May-2015	DH	1.0.0	Working SlewToAltAz Function
// 01-Dec-2015	DH	1.0.1	Working limit switches, encoder functions, 
// --------------------------------------------------------------------------------
//


// This is used to define code in the template that is specific to one class implementation
// unused code canbe deleted and this definition removed.
#define Telescope

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;

using ASCOM;
using ASCOM.Astrometry;
using ASCOM.Astrometry.AstroUtils;
using ASCOM.Utilities;
using ASCOM.DeviceInterface;
using System.Globalization;
using System.Collections;

namespace ASCOM.Sepikascope001
{
    //
    // Your driver's DeviceID is ASCOM.Sepikascope001.Telescope
    //
    // The Guid attribute sets the CLSID for ASCOM.Sepikascope001.Telescope
    // The ClassInterface/None addribute prevents an empty interface called
    // _Sepikascope001 from being created and used as the [default] interface
    //
    // TODO Replace the not implemented exceptions with code to implement the function or
    // throw the appropriate ASCOM exception.
    //

    /// <summary>
    /// ASCOM Telescope Driver for Sepikascope001.
    /// </summary>
    [Guid("7d50192c-1d95-4a33-8215-1a6920a342b9")]
    [ClassInterface(ClassInterfaceType.None)]
    public class Telescope : ITelescopeV3
    {
        /// <summary>
        /// ASCOM DeviceID (COM ProgID) for this driver.
        /// The DeviceID is used by ASCOM applications to load the driver at runtime.
        /// </summary>
        internal static string driverID = "ASCOM.Sepikascope001.Telescope";
        // TODO Change the descriptive string for your driver then remove this line
        /// <summary>
        /// Driver description that displays in the ASCOM Chooser.
        /// </summary>
        private static string driverDescription = "ASCOM Telescope Driver for Sepikascope001 V0.1";
        //changes ARE reflected in "Get Profile" inside the ASCOM Diagnostics tool, when connecting to this scope


        internal static string comPortProfileName = "COM Port"; // Constants used for Profile persistence
        internal static string comPortDefault = "COM14";
        internal static string traceStateProfileName = "Trace Level";
        internal static string traceStateDefault = "false";
        /**
        internal static string latutudeProfileName = "Latitude";
        internal static string latitudeDefault = "34.144005";

        internal static string longitudeProfileName = "Longitude";
        internal static string longitudeDefault = "-118.120434";
        **/

        internal static string comPort; // Variables to hold the currrent device configuration
        internal static bool traceState;

        /// <summary>
        /// Private variable to hold the Serial Object
        /// </summary>
        private ASCOM.Utilities.Serial objSerial;

        /// <summary>
        /// Private variable to hold the connected state
        /// </summary>
        private bool connectedState;

        /// <summary>
        /// Private variable to hold an ASCOM Utilities object
        /// </summary>
        private Util utilities;

        /// <summary>
        /// Private variable to hold an ASCOM AstroUtilities object to provide the Range method
        /// </summary>
        private AstroUtils astroUtilities;

        /// <summary>
        /// Private variable to hold the trace logger object (creates a diagnostic log file with information that you specify)
        /// </summary>
        private TraceLogger tl;

        public ArrayList actionsArrayList;


        //mutual exclusion - Only one command should occur at any one moment?
        private bool commandBusy = false;

        
        // explicit function that converts a double floating point
        // angular degree into arcminutes, and then rounded into
        // a 16-bit integer, a 'short' in c#, and then converted
        // into a string of 2 bytes, because 1 byte is 8 bits
        private byte[] doubleToShortBytes (double param1)
        {
            short shortParam = Convert.ToInt16(param1*60.0);
            byte[] byteArray = BitConverter.GetBytes(shortParam);
            return byteArray;
        }

        
        public byte[] doubleToShortBytes (double param1, double param2)
        {
            byte[] byteArray1 = doubleToShortBytes(param1);
            byte[] byteArray2 = doubleToShortBytes(param2);
            
            byte[] output = new byte[byteArray1.Length + byteArray2.Length];

            /** This stuff works too, and it is the fastest
            byte[] output = new byte[8];
            int outputIndex = 0;
            for (int i = 0; i < 4; i++)
            {
                output[outputIndex] = byteArray1[i];
                output[outputIndex + 4] = byteArray2[i];
                outputIndex++;
            }
            **/
            
            // the reality is that byteArray1 is only 2 bytes
            // and output only becomes 4 bytes
            // maybe we can make a function that will accept any number of 2-byte arguments
            // later
            byteArray1.CopyTo(output, 0);
            byteArray2.CopyTo(output, byteArray1.Length);

            return output;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ASCOM.Sepikascope001.Telescope"/> class.
        /// Must be public for COM registration.
        /// </summary>
        public Telescope()
        {
            ReadProfile(); // Read device configuration from the ASCOM Profile store

            tl = new TraceLogger("", "Sepikascope001");
            tl.Enabled = traceState;
            tl.LogMessage("Telescope", "Starting initialisation");

            connectedState = false; // Initialise connected to false
            utilities = new Util(); //Initialise util object
            astroUtilities = new AstroUtils(); // Initialise astro utilities object
            //TODO: Implement your additional construction here

            tl.LogMessage("Telescope", "Completed initialisation");

            actionsArrayList = new ArrayList();

//NOTE : DOUBLE CHECK - EACH ONE
//       UPDATE LIST!

            actionsArrayList.Add("CanMoveAxis"); //can move Alt, Azm
            //actionsArrayList.Add("MoveAxis"); //not sure how to implement
            actionsArrayList.Add("SlewToAltAz"); //functional
            actionsArrayList.Add("Slewing"); //untested, not written?
            actionsArrayList.Add("AbortSlew"); //functional
            actionsArrayList.Add("Altitude"); //functional
            actionsArrayList.Add("Azimuth");  //functional
            actionsArrayList.Add("SyncToAltAz"); //functional
            actionsArrayList.Add("SupportedActions"); //redundant
        }


        //
        // PUBLIC COM INTERFACE ITelescopeV3 IMPLEMENTATION
        //

        #region Common properties and methods.

        /// <summary>
        /// Displays the Setup Dialog form.
        /// If the user clicks the OK button to dismiss the form, then
        /// the new settings are saved, otherwise the old values are reloaded.
        /// THIS IS THE ONLY PLACE WHERE SHOWING USER INTERFACE IS ALLOWED!
        /// </summary>
        public void SetupDialog()
        {
            // consider only showing the setup dialog if not connected
            // or call a different dialog if connected
            if (IsConnected)
                System.Windows.Forms.MessageBox.Show("Already connected, just press OK");

            using (SetupDialogForm F = new SetupDialogForm())
            {
                var result = F.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    WriteProfile(); // Persist device configuration values to the ASCOM Profile store
                }
            }
        }

        public ArrayList SupportedActions
        {
            get
            {
                //tl.LogMessage("SupportedActions Get", "Returning empty arraylist");
                //return new ArrayList();
                tl.LogMessage("SupportedActions Get", "Returning Actions arrayList");            
                return actionsArrayList;
            }
        }

        public string Action(string actionName, string actionParameters)
        {
            throw new ASCOM.ActionNotImplementedException("Action " + actionName + " is not implemented by this driver");
        }


        //raw means ready to Xmit
        //No error checking or Exceptions code yet
        public void CommandBlind(string command, bool raw)
        {
            CheckConnected("CommandBlind");

            if (raw == true) objSerial.Transmit(command);
            else objSerial.Transmit(command + "~");

            //throw new ASCOM.MethodNotImplementedException("CommandBlind");
        }


        //raw means ready to Xmit
        //No error checking or Exceptions code yet
        public bool CommandBool(string command, bool raw)
        {
            CheckConnected("CommandBool");

            if (raw == false) command += "~";

            //number of characters to convert
            int comlen = command.Length;

            //convert command string into character array
            char[] commandChars = command.ToCharArray();

            //create byte array to fit bytes from character array
            byte[] byteArray = new byte[comlen * 2];

            //convert each character to 2-byte, and copy the 2-byte into byteArray
            for (int i = 0; i < comlen; i++)
            {
                (BitConverter.GetBytes(commandChars[i])).CopyTo(byteArray, i * 2);
            }

            objSerial.TransmitBinary(byteArray);

            string retval = objSerial.ReceiveTerminated("~");
            retval = retval.Replace("~", "");

            // TODO decode the return string and return true or false
            // or
            if (retval.Equals("true"))
                return true;
            else if (retval.Equals("false"))
                return false;
            else
                throw new ASCOM.DriverException("CommandBool non boolean return");
        }



        public string CommandString(string command, bool raw)
        {
            CheckConnected("CommandString");
            // it's a good idea to put all the low level communication with the device here,
            // then all communication calls this function
            // you need something to ensure that only one command is in progress at a time

            commandBusy = true;

            //THIS MIGHT WORK: StringInput -> CharArray -> ByteArray ##> TransmitBytes(...)
            //NOTE: IT WORKS, but we can't use terminating characters??

            //number of characters to convert
            int comlen = command.Length;
            
            //convert command string into character array
            char[] commandChars = command.ToCharArray();

            //create byte array to fit bytes from character array
            byte[] byteArray = new byte[1 + (comlen * 2)];

            //convert each character to 2-byte, and copy the 2-byte into byteArray
            for (int i = 0; i < comlen; i++)
            {
                (BitConverter.GetBytes(commandChars[i])).CopyTo(byteArray, 1 + (i*2));
            }
            byteArray[0] = Convert.ToByte(byteArray.Length);
            objSerial.TransmitBinary(byteArray);

            string retval = objSerial.ReceiveTerminated("~");
            retval = retval.Replace("~", "");
            return retval;

            //throw new ASCOM.MethodNotImplementedException("CommandString");
        }
        
        

        // WARNING: OBSOLETE!!!
        public String MyCommandString(byte[] byteArray, bool ready)
        {
            String retval;

            byte[] byteArray2 = new byte[byteArray.Length+1];

            // 'raw' as in ready to transmit, includes ';'
            if (ready)
            {
                objSerial.TransmitBinary (byteArray);
            }
            else
            {
                //byteArray.CopyTo(byteArray2, 0);
                objSerial.TransmitBinary(byteArray);
                objSerial.Transmit("~");
            }
            

            //byte[] terminatorBytes = new byte[] {Convert.ToByte(';')};

            //return "working";
            //return BitConverter.ToString(objSerial.ReceiveTerminatedBinary(terminatorBytes));
            //return objSerial.ReceiveTerminated("~");
            retval = objSerial.ReceiveTerminated("~");
            retval = retval.Replace("~", "");
            return retval;
            //return "work in progress: mycommandstring"; //Char.ConvertFromUtf32(0x003B);
        }        


        public void Dispose()
        {
            // Clean up the tracelogger and util objects
            tl.Enabled = false;
            tl.Dispose();
            tl = null;
            utilities.Dispose();
            utilities = null;
            astroUtilities.Dispose();
            astroUtilities = null;
        }

        public bool Connected
        {
            get
            {
                tl.LogMessage("Connected Get", IsConnected.ToString());
                return IsConnected;
            }
            set
            {
                tl.LogMessage("Connected Set", value.ToString());
                if (value == IsConnected)
                    return;

                if (value)
                {

                    tl.LogMessage("Connected Set", "Connecting to port " + comPort);
                    // TODO connect to the device
                    objSerial = new ASCOM.Utilities.Serial();
                    objSerial.PortName = comPort;
                    objSerial.Speed = SerialSpeed.ps19200;
                    connectedState = true;
                    objSerial.Connected = true;

                    System.Threading.Thread.Sleep(1000);

                }
                else
                {
                    connectedState = false;
                    tl.LogMessage("Connected Set", "Disconnecting from port " + comPort);
                    // TODO disconnect from the device
                    //objSerial.ClearBuffers();
                    objSerial.Connected = false;
                }
            }
        }

        public string Description
        {
            // TODO customise this device description
            get
            {
                tl.LogMessage("Description Get", driverDescription);
                return driverDescription;
            }
        }

        public string DriverInfo
        {
            get
            {
                Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                // TODO customise this driver description
                string driverInfo = "Information about the driver itself. Version: " + String.Format(CultureInfo.InvariantCulture, "{0}.{1}", version.Major, version.Minor);
                tl.LogMessage("DriverInfo Get", driverInfo);
                return driverInfo;
            }
        }

        public string DriverVersion
        {
            get
            {
                Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                string driverVersion = String.Format(CultureInfo.InvariantCulture, "{0}.{1}", version.Major, version.Minor);
                tl.LogMessage("DriverVersion Get", driverVersion);
                return driverVersion;
            }
        }

        public short InterfaceVersion
        {
            // set by the driver wizard
            get
            {
                tl.LogMessage("InterfaceVersion Get", "3");
                return Convert.ToInt16("3");
            }
        }

        public string Name
        {
            get
            {
                string name = "Sepikascope Telescope Driver 001";
                tl.LogMessage("Name Get", name);

                return name;
            }
        }

        #endregion

        #region ITelescope Implementation
        public void AbortSlew()
        {
            //tl.LogMessage("AbortSlew", "Not implemented");
            //throw new ASCOM.MethodNotImplementedException("AbortSlew");
            tl.LogMessage("AbortSlew", "Implemented");

            string outputString = "911~";

            //change to CommandBlind
            string retval = CommandString(outputString, true);
            if (!retval.Equals("Slewing Async Aborted"))
                throw new ASCOM.DriverException("Slew Async Abort - Fail;");
        }

        public AlignmentModes AlignmentMode
        {
            get
            {
                //tl.LogMessage("AlignmentMode Get", "Not implemented");
                //throw new ASCOM.PropertyNotImplementedException("AlignmentMode", false);
                tl.LogMessage("AlignmentMode Get", "Implemented");
                return AlignmentModes.algAltAz;
            }
        }

        public double Altitude
        {
            get
            {
                //tl.LogMessage("Altitude", "Not implemented");
                //throw new ASCOM.PropertyNotImplementedException("Altitude", false);
                tl.LogMessage("Altitude", "Implemented");

                string outputString = "311~";

                string retval = CommandString(outputString, true);

                return (Convert.ToDouble(retval));
            }
        }

        public double ApertureArea
        {
            get
            {
                tl.LogMessage("ApertureArea Get", "Implemented");
                //throw new ASCOM.PropertyNotImplementedException("ApertureArea", false);
                return (((ApertureDiameter * ApertureDiameter)/4.0) * Math.PI);
            }
        }

        public double ApertureDiameter
        {
            get
            {
                tl.LogMessage("ApertureDiameter Get", "Implemented");
                //throw new ASCOM.PropertyNotImplementedException("ApertureDiameter", false);
                //SkyQuest XT6 Dobsonian Reflector Telescope
                //Parabolic Primary Optics
                //Diameter 150mm, Focal Length 1200mm, focal ratio f/8
                return 0.150;
            }
        }

        public bool AtHome
        {
            get
            {
                tl.LogMessage("AtHome", "Get - " + false.ToString());
                return false;
            }
        }

        public bool AtPark
        {
            get
            {
                tl.LogMessage("AtPark", "Get - " + false.ToString());
                return false;
            }
        }

        public IAxisRates AxisRates(TelescopeAxes Axis)
        {
            tl.LogMessage("AxisRates", "Get - " + Axis.ToString());
            return new AxisRates(Axis);
        }

        public double Azimuth
        {
            get
            {
                //tl.LogMessage("Azimuth", "Not implemented");
                //throw new ASCOM.PropertyNotImplementedException("Azimuth", false);
                tl.LogMessage("Azimuth", "Implemented");

                string outputString = "211~";

                string retval = CommandString(outputString, true);

                return (Convert.ToDouble(retval));
            }
        }

        public bool CanFindHome
        {
            get
            {
                tl.LogMessage("CanFindHome", "Get - " + false.ToString());
                return false;
            }
        }

        public bool CanMoveAxis(TelescopeAxes Axis)
        {
            tl.LogMessage("CanMoveAxis", "Get - " + Axis.ToString());
            switch (Axis)
            {
                case TelescopeAxes.axisPrimary: return true;
                case TelescopeAxes.axisSecondary: return true;
                case TelescopeAxes.axisTertiary: return false;
                default: throw new InvalidValueException("CanMoveAxis", Axis.ToString(), "0 to 2");
            }
        }

        public bool CanPark
        {
            get
            {
                tl.LogMessage("CanPark", "Get - " + false.ToString());
                return false;
            }
        }

        public bool CanPulseGuide
        {
            get
            {
                tl.LogMessage("CanPulseGuide", "Get - " + false.ToString());
                return false;
            }
        }

        public bool CanSetDeclinationRate
        {
            get
            {
                tl.LogMessage("CanSetDeclinationRate", "Get - " + false.ToString());
                return false;
            }
        }

        public bool CanSetGuideRates
        {
            get
            {
                tl.LogMessage("CanSetGuideRates", "Get - " + false.ToString());
                return false;
            }
        }

        public bool CanSetPark
        {
            get
            {
                tl.LogMessage("CanSetPark", "Get - " + false.ToString());
                return false;
            }
        }

        public bool CanSetPierSide
        {
            get
            {
                tl.LogMessage("CanSetPierSide", "Get - " + false.ToString());
                return false;
            }
        }

        public bool CanSetRightAscensionRate
        {
            get
            {
                tl.LogMessage("CanSetRightAscensionRate", "Get - " + false.ToString());
                return false;
            }
        }

        public bool CanSetTracking
        {
            get
            {
                tl.LogMessage("CanSetTracking", "Get - " + false.ToString());
                return false;
            }
        }

        //TODO - To be reviewed later....
        //True if this telescope is capable of programmed slewing (synchronous or 
        //asynchronous) to equatorial coordinates 
        public bool CanSlew
        {
            get
            {
                tl.LogMessage("CanSlew", "Get - " + true.ToString());
                return true;
            }
        }

        //Works - verified
        //True if this telescope is capable of programmed slewing (synchronous or
        //asynchronous) to local horizontal coordinates 
        public bool CanSlewAltAz
        {
            get
            {
                tl.LogMessage("CanSlewAltAz", "Get - " + true.ToString());
                return true;
            }
        }

        //Works - verified
        //True if this telescope is capable of programmed asynchronous slewing to 
        //local horizontal coordinates 
        public bool CanSlewAltAzAsync
        {
            get
            {
                tl.LogMessage("CanSlewAltAzAsync", "Get - " + true.ToString());
                return true;
            }
        }

        //TODO - To be reviewed later....
        //True if this telescope is capable of programmed asynchronous slewing to 
        //equatorial coordinates. 
        public bool CanSlewAsync
        {
            get
            {
                tl.LogMessage("CanSlewAsync", "Get - " + true.ToString());
                return true;
            }
        }


        //True if this telescope is capable of programmed synching to equatorial
        //coordinates.
        public bool CanSync
        {
            get
            {
                tl.LogMessage("CanSync", "Get - " + true.ToString());
                return true;
            }
        }


        //True if this telescope is capable of programmed synching to local 
        //horizontal coordinates
        public bool CanSyncAltAz
        {
            get
            {
                tl.LogMessage("CanSyncAltAz", "Get - " + true.ToString());
                return true;
            }
        }

        public bool CanUnpark
        {
            get
            {
                tl.LogMessage("CanUnpark", "Get - " + false.ToString());
                return false;
            }
        }

        public double Declination
        {
            get
            {
                double declination = 0.0;
                tl.LogMessage("Declination", "Get - " + utilities.DegreesToDMS(declination, ":", ":"));
                return declination;
            }
        }

        public double DeclinationRate
        {
            get
            {
                double declination = 0.0;
                tl.LogMessage("DeclinationRate", "Get - " + declination.ToString());
                return declination;
            }
            set
            {
                tl.LogMessage("DeclinationRate Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("DeclinationRate", true);
            }
        }

        public PierSide DestinationSideOfPier(double RightAscension, double Declination)
        {
            tl.LogMessage("DestinationSideOfPier Get", "Not implemented");
            throw new ASCOM.PropertyNotImplementedException("DestinationSideOfPier", false);
        }

        public bool DoesRefraction
        {
            get
            {
                tl.LogMessage("DoesRefraction Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("DoesRefraction", false);
            }
            set
            {
                tl.LogMessage("DoesRefraction Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("DoesRefraction", true);
            }
        }

        public EquatorialCoordinateType EquatorialSystem
        {
            get
            {
                EquatorialCoordinateType equatorialSystem = EquatorialCoordinateType.equLocalTopocentric;
                tl.LogMessage("DeclinationRate", "Get - " + equatorialSystem.ToString());
                return equatorialSystem;
            }
        }

        public void FindHome()
        {
            tl.LogMessage("FindHome", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("FindHome");
        }

        public double FocalLength
        {
            get
            {
                tl.LogMessage("FocalLength Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("FocalLength", false);
            }
        }

        public double GuideRateDeclination
        {
            get
            {
                tl.LogMessage("GuideRateDeclination Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("GuideRateDeclination", false);
            }
            set
            {
                tl.LogMessage("GuideRateDeclination Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("GuideRateDeclination", true);
            }
        }

        public double GuideRateRightAscension
        {
            get
            {
                tl.LogMessage("GuideRateRightAscension Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("GuideRateRightAscension", false);
            }
            set
            {
                tl.LogMessage("GuideRateRightAscension Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("GuideRateRightAscension", true);
            }
        }

        public bool IsPulseGuiding
        {
            get
            {
                tl.LogMessage("IsPulseGuiding Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("IsPulseGuiding", false);
            }
        }

        public void MoveAxis(TelescopeAxes Axis, double Rate)
        {
            //convert Rate from degrees/second to arcminute/second
            byte[] myRate = doubleToShortBytes(Rate * 60.0);

            string stringOutgoing = "4";
            string stringIncoming = "";

            //Rate is a double, representing degrees/second rate of motion about that axis
            if (CanMoveAxis(Axis))
            {

                //tl.LogMessage("MoveAxis", "Not implemented");
                //throw new ASCOM.MethodNotImplementedException("MoveAxis");
                tl.LogMessage("MoveAxis", "Move - " + Axis.ToString() + ", " + Rate.ToString());

                switch (Axis)
                {
                    //The azimuth at the local horizon of the telescope's current
                    //position (degrees, North-referenced, positive East/clockwise). 
                    case TelescopeAxes.axisPrimary:

                        //check rate if it's not out of range??

                        //we're using "1" to indicate Azimuth Axis
                        stringOutgoing += "1";
                        
                        for (int i = 0; i < myRate.Length; i = i + 2)
                        {
                            stringOutgoing += BitConverter.ToChar(myRate, i);
                        }

                        stringOutgoing += "~";

                        stringIncoming = CommandString(stringOutgoing, true);

                        if (stringIncoming.Equals("Move Axis -Azimuth- Started"))
                        {

                        }
                        else
                        {
                            throw new ASCOM.DriverException("MoveAxis - Fail;");
                        }

                        break;


                    //The Altitude above the local horizon of the telescope's
                    //current position (degrees, positive up)
                    case TelescopeAxes.axisSecondary:

                        //check rate if it's not out of range??

                        //we're using "1" to indicate Altitude Axis
                        stringOutgoing += "2";

                        for (int i = 0; i < myRate.Length; i = i + 2)
                        {
                            stringOutgoing += BitConverter.ToChar(myRate, i);
                        }

                        stringOutgoing += "~";

                        stringIncoming = CommandString(stringOutgoing, true);

                        if (stringIncoming.Equals("Move Axis -Altitude- Started"))
                        {

                        }
                        else
                        {
                            throw new ASCOM.DriverException("MoveAxis - Fail;");
                        }



                        break;
                    
                    //does not exist??
                    case TelescopeAxes.axisTertiary:
                        break;

                    default: throw new InvalidValueException("CanMoveAxis", Axis.ToString(), "0 to 2");
                }
            }
            else
            {
                tl.LogMessage("CanMoveAxis", "Not implemented");
                throw new ASCOM.MethodNotImplementedException("CanMoveAxis");
            }
        }

        public void Park()
        {
            tl.LogMessage("Park", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("Park");
        }

        public void PulseGuide(GuideDirections Direction, int Duration)
        {
            tl.LogMessage("PulseGuide", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("PulseGuide");
        }

        public double RightAscension
        {
            get
            {
                double rightAscension = 0.0;
                tl.LogMessage("RightAscension", "Get - " + utilities.HoursToHMS(rightAscension));
                return rightAscension;
            }
        }

        public double RightAscensionRate
        {
            get
            {
                double rightAscensionRate = 0.0;
                tl.LogMessage("RightAscensionRate", "Get - " + rightAscensionRate.ToString());
                return rightAscensionRate;
            }
            set
            {
                tl.LogMessage("RightAscensionRate Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("RightAscensionRate", true);
            }
        }

        public void SetPark()
        {
            tl.LogMessage("SetPark", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("SetPark");
        }

        public PierSide SideOfPier
        {
            get
            {
                tl.LogMessage("SideOfPier Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SideOfPier", false);
            }
            set
            {
                tl.LogMessage("SideOfPier Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SideOfPier", true);
            }
        }

        public double SiderealTime
        {
            get
            {
                double siderealTime = (18.697374558 + 24.065709824419081 * (utilities.DateLocalToJulian(DateTime.Now) - 2451545.0)) % 24.0;
                tl.LogMessage("SiderealTime", "Get - " + siderealTime.ToString());
                return siderealTime;
            }
        }

        public double SiteElevation
        {
            get
            {
                tl.LogMessage("SiteElevation Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SiteElevation", false);
            }
            set
            {
                tl.LogMessage("SiteElevation Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SiteElevation", true);
            }
        }

        public double SiteLatitude
        {
            //In the future, the unit might use a GPS unit, and so the driver will have
            //to send a command to the Arduino to poll the GPS unit

            //our current GPS location is 34.144005, -118.120434
            get
            {
                //CODE to read GPS location
                //NO GPS, so for now it's hard-coded
                tl.LogMessage("SiteLatitude Get", "Implemented");
                return 34.144005;
            }
            set
            {
                //manually input position latitude
                tl.LogMessage("SiteLatitude Set", "Implemented");                
            }
        }

        public double SiteLongitude
        {
            //In the future, the unit might use a GPS unit, and so the driver will have
            //to send a command to the Arduino to poll the GPS unit

            //our current GPS location is 34.144005, -118.120434
            get
            {
                //CODE to read GPS location
                //NO GPS, so for now it's hard-coded
                tl.LogMessage("SiteLongitude Get", "Implemented");
                return -118.120434;
            }
            set
            {
                tl.LogMessage("SiteLongitude Set", "Implemented");
                //manually input position latitude
            }
        }

        public short SlewSettleTime
        {
            get
            {
                tl.LogMessage("SlewSettleTime Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SlewSettleTime", false);
            }
            set
            {
                tl.LogMessage("SlewSettleTime Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SlewSettleTime", true);
            }
        }


        // double -> byteArray -> charArray -> string??
        public void SlewToAltAz(double Azimuth, double Altitude)
        {
            //tl.LogMessage("SlewToAltAz", "Not implemented");
            //throw new ASCOM.MethodNotImplementedException("SlewToAltAz");

            tl.LogMessage("SlewToAltAz", "Implemented");

            string stringOutgoing = "1";
            string stringIncoming = "";

            if (((Azimuth < 0.0) || (Azimuth > 360.0)) || ((Altitude < 0.0) || (Altitude > 360.0)))
                throw new ASCOM.InvalidValueException("SlewToAltAz: Value out of range;");

            byte[] paramBytes = doubleToShortBytes(Azimuth, Altitude);
            
            //converts from 2 bytes, into unicode 16bit, thus 2 byte
            //converts one character at a time
            for (int i = 0; i < paramBytes.Length; i = i + 2)
            {
                stringOutgoing += BitConverter.ToChar(paramBytes, i); 
            }

            stringOutgoing += "~";

            //slewing may take some time to achieve, maybe 3 minutes?
            //we're waiting for confirmation from the Arduino
            objSerial.ReceiveTimeout = 120;

            stringIncoming = CommandString(stringOutgoing, true);

            objSerial.ReceiveTimeout = 5;

            //designed so that the return string is stripped of terminating char ';'
            if (stringIncoming.Equals("Slewing Operation Finished"))
            {

            }
            else if (stringIncoming.Contains("Altitude Limit Switch Triggered"))
            {
                throw new ASCOM.InvalidValueException("Altitude Limit Switch Triggered;");
            }
            else
            {
                throw new ASCOM.DriverException("SlewToAltAz - Fail;");
            }
        }

        //COME BACK LATER
        public void SlewToAltAzAsync(double Azimuth, double Altitude)
        {
            //tl.LogMessage("SlewToAltAzAsync", "Not implemented");
            //throw new ASCOM.MethodNotImplementedException("SlewToAltAzAsync");
            tl.LogMessage("SlewToAltAzAsync", "Implemented");

            string stringOutgoing = "8";
            string stringIncoming = "";

            if (((Azimuth < 0.0) || (Azimuth > 360.0)) || ((Altitude < 0.0) || (Altitude > 360.0)))
                throw new ASCOM.InvalidValueException("SlewToAltAzAsync: Value out of range;");

            byte[] paramBytes = doubleToShortBytes(Azimuth, Altitude);

            for (int i = 0; i < paramBytes.Length; i = i + 2)
            {
                stringOutgoing += BitConverter.ToChar(paramBytes, i);
            }

            stringOutgoing += "~";

            stringIncoming = CommandString(stringOutgoing, true);

            if (!stringIncoming.Equals("Slewing Async Started"))
                throw new ASCOM.DriverException("SlewToAltAzAsync - Fail;");
        }


        //May have to implement RA,DEC coordinate slewing
        //can be done, using the system's clock?
        public void SlewToCoordinates(double RightAscension, double Declination)
        {
            tl.LogMessage("SlewToCoordinates", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("SlewToCoordinates");
        }

        public void SlewToCoordinatesAsync(double RightAscension, double Declination)
        {
            tl.LogMessage("SlewToCoordinatesAsync", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("SlewToCoordinatesAsync");
        }

        public void SlewToTarget()
        {
            tl.LogMessage("SlewToTarget", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("SlewToTarget");
        }

        public void SlewToTargetAsync()
        {
            tl.LogMessage("SlewToTargetAsync", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("SlewToTargetAsync");
        }

        //TODO - return true if the telescope is currently moving something
        public bool Slewing
        {
            get
            {
                //tl.LogMessage("Slewing Get", "Not implemented");
                //throw new ASCOM.PropertyNotImplementedException("Slewing", false);
                
                tl.LogMessage("Slewing Get", "Implemented");

                byte[] output = { Convert.ToByte('0'), 1, 1, 1, 1, Convert.ToByte(';') };

                //WHY must I process the Arduino's output as Strings?
                bool retval = (MyCommandString(output,true) == "Ready");

                //not "Ready" means it's still slewing
                return !retval;

            }
        }

        public void SyncToAltAz(double Azimuth, double Altitude)
        {
            //tl.LogMessage("SyncToAltAz", "Not implemented");
            //throw new ASCOM.MethodNotImplementedException("SyncToAltAz");
            tl.LogMessage("SyncToAltAz", "Implemented");

            string stringOutgoing = "7";
            string stringIncoming = "";

            if (((Azimuth < 0.0) || (Azimuth > 360.0)) || ((Altitude < 0.0) || (Altitude > 360.0)))
                throw new ASCOM.InvalidValueException("SyncToAltAz: Value out of range;");

            byte[] paramBytes = doubleToShortBytes(Azimuth, Altitude);

            //converts from 2 bytes, into unicode 16bit, thus 2 byte
            //converts one character at a time
            for (int i = 0; i < paramBytes.Length; i = i + 2)
            {
                stringOutgoing += BitConverter.ToChar(paramBytes, i);
            }

            stringOutgoing += "~";
            
            stringIncoming = CommandString(stringOutgoing, true);

            if (!stringIncoming.Equals("SyncToAltAz Complete"))
                throw new ASCOM.DriverException("SyncToAltAz - Fail;");

        }

        public void SyncToCoordinates(double RightAscension, double Declination)
        {
            tl.LogMessage("SyncToCoordinates", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("SyncToCoordinates");
        }

        public void SyncToTarget()
        {
            tl.LogMessage("SyncToTarget", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("SyncToTarget");
        }

        public double TargetDeclination
        {
            get
            {
                tl.LogMessage("TargetDeclination Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("TargetDeclination", false);
            }
            set
            {
                tl.LogMessage("TargetDeclination Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("TargetDeclination", true);
            }
        }

        public double TargetRightAscension
        {
            get
            {
                tl.LogMessage("TargetRightAscension Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("TargetRightAscension", false);
            }
            set
            {
                tl.LogMessage("TargetRightAscension Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("TargetRightAscension", true);
            }
        }

        //The state of the telescope's sidereal tracking drive. 
        //Changing the value of this property will turn the sidereal drive on and off.
        //However, some telescopes may not support changing the value of this property
        //and thus may not support turning tracking on and off. 
        //Tracking : Following objects in the night sky, as the earth turns
        public bool Tracking
        {
            get
            {
                bool tracking = false;
                tl.LogMessage("Tracking", "Get - " + tracking.ToString());
                return tracking;
            }
            set
            {
                tl.LogMessage("Tracking Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("Tracking", true);
            }
        }

        public DriveRates TrackingRate
        {
            get
            {
                tl.LogMessage("TrackingRate Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("TrackingRate", false);
            }
            set
            {
                tl.LogMessage("TrackingRate Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("TrackingRate", true);
            }
        }

        public ITrackingRates TrackingRates
        {
            get
            {
                ITrackingRates trackingRates = new TrackingRates();
                tl.LogMessage("TrackingRates", "Get - ");
                foreach (DriveRates driveRate in trackingRates)
                {
                    tl.LogMessage("TrackingRates", "Get - " + driveRate.ToString());
                }
                return trackingRates;
            }
        }

        public DateTime UTCDate
        {
            get
            {
                DateTime utcDate = DateTime.UtcNow;
                tl.LogMessage("TrackingRates", "Get - " + String.Format("MM/dd/yy HH:mm:ss", utcDate));
                return utcDate;
            }
            set
            {
                tl.LogMessage("UTCDate Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("UTCDate", true);
            }
        }

        public void Unpark()
        {
            tl.LogMessage("Unpark", "Not implemented");
            throw new ASCOM.MethodNotImplementedException("Unpark");
        }

        #endregion

        #region Private properties and methods
        // here are some useful properties and methods that can be used as required
        // to help with driver development

        #region ASCOM Registration

        // Register or unregister driver for ASCOM. This is harmless if already
        // registered or unregistered. 
        //
        /// <summary>
        /// Register or unregister the driver with the ASCOM Platform.
        /// This is harmless if the driver is already registered/unregistered.
        /// </summary>
        /// <param name="bRegister">If <c>true</c>, registers the driver, otherwise unregisters it.</param>
        private static void RegUnregASCOM(bool bRegister)
        {
            using (var P = new ASCOM.Utilities.Profile())
            {
                P.DeviceType = "Telescope";
                if (bRegister)
                {
                    P.Register(driverID, driverDescription);
                }
                else
                {
                    P.Unregister(driverID);
                }
            }
        }

        /// <summary>
        /// This function registers the driver with the ASCOM Chooser and
        /// is called automatically whenever this class is registered for COM Interop.
        /// </summary>
        /// <param name="t">Type of the class being registered, not used.</param>
        /// <remarks>
        /// This method typically runs in two distinct situations:
        /// <list type="numbered">
        /// <item>
        /// In Visual Studio, when the project is successfully built.
        /// For this to work correctly, the option <c>Register for COM Interop</c>
        /// must be enabled in the project settings.
        /// </item>
        /// <item>During setup, when the installer registers the assembly for COM Interop.</item>
        /// </list>
        /// This technique should mean that it is never necessary to manually register a driver with ASCOM.
        /// </remarks>
        [ComRegisterFunction]
        public static void RegisterASCOM(Type t)
        {
            RegUnregASCOM(true);
        }

        /// <summary>
        /// This function unregisters the driver from the ASCOM Chooser and
        /// is called automatically whenever this class is unregistered from COM Interop.
        /// </summary>
        /// <param name="t">Type of the class being registered, not used.</param>
        /// <remarks>
        /// This method typically runs in two distinct situations:
        /// <list type="numbered">
        /// <item>
        /// In Visual Studio, when the project is cleaned or prior to rebuilding.
        /// For this to work correctly, the option <c>Register for COM Interop</c>
        /// must be enabled in the project settings.
        /// </item>
        /// <item>During uninstall, when the installer unregisters the assembly from COM Interop.</item>
        /// </list>
        /// This technique should mean that it is never necessary to manually unregister a driver from ASCOM.
        /// </remarks>
        [ComUnregisterFunction]
        public static void UnregisterASCOM(Type t)
        {
            RegUnregASCOM(false);
        }

        #endregion

        /// <summary>
        /// </summary>        /// Returns                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  if there is a valid connection to the driver hardware

        private bool IsConnected
        {
            get
            {
                // TODO check that the driver hardware connection exists and is connected to the hardware
                return connectedState;
            }
        }

        /// <summary>
        /// Use this function to throw an exception if we aren't connected to the hardware
        /// </summary>
        /// <param name="message"></param>
        private void CheckConnected(string message)
        {
            if (!IsConnected)
            {
                throw new ASCOM.NotConnectedException(message);
            }
        }

        /// <summary>
        /// Read the device configuration from the ASCOM Profile store
        /// </summary>
        internal void ReadProfile()
        {
            using (Profile driverProfile = new Profile())
            {
                driverProfile.DeviceType = "Telescope";
                traceState = Convert.ToBoolean(driverProfile.GetValue(driverID, traceStateProfileName, string.Empty, traceStateDefault));
                comPort = driverProfile.GetValue(driverID, comPortProfileName, string.Empty, comPortDefault);
                //driverProfile.GetValue(driverID, "abd", string.Empty, "bdds");
            }
        }

        /// <summary>
        /// Write the device configuration to the  ASCOM  Profile store
        /// </summary>
        internal void WriteProfile()
        {
            using (Profile driverProfile = new Profile())
            {
                driverProfile.DeviceType = "Telescope";
                driverProfile.WriteValue(driverID, traceStateProfileName, traceState.ToString());
                driverProfile.WriteValue(driverID, comPortProfileName, comPort.ToString());
                driverProfile.WriteValue(driverID, "abd", string.Empty, "bdds");
            }
        }

        #endregion

    }
}
