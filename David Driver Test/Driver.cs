//tabs=4

// REMEMBER - Platform Target should be x64
// --------------------------------------------------------------------------------
// TODO fill in this information for your driver, then remove this line!
//
// ASCOM Telescope driver for Sepikascope001
//
// Description:	Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam 
//				nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam 
//				erat, sed diam voluptua. At vero eos et accusam et justo duo 
//				dolores et ea rebum. Stet clita kasd gubergren, no sea takimata 
//				sanctus est Lorem ipsum dolor sit amet.
//
// Implements:	ASCOM Telescope interface version: <To be completed by driver developer>
// Author:		David Harbottle <dharbott@gmail.com>
//
// Edit Log:
//
// Date			Who	Vers	Description
// -----------	---	-----	-------------------------------------------------------
// 14-May-2015	DH	1.0.0	Working SlewToAltAz Function
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
        private static string driverDescription = "ASCOM Telescope Driver for Sepikascope001.";

        internal static string comPortProfileName = "COM Port"; // Constants used for Profile persistence
        internal static string comPortDefault = "COM1";
        internal static string traceStateProfileName = "Trace Level";
        internal static string traceStateDefault = "false";

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

        // tested and it works
        private enum DCommandList
        {
            DAltitudeLimit,
            DMoveAxis,
            DSlewToAltAz,
            DSlewing,
            DAbortSlew,
            DAltitude,
            DAzimuth,
            DSyncToAltAz
            //DSupportedActions
        };

                // tested and it works
        // next step is to redo function to return byte[],
        // formatting op codes and parameters into command words
        // to transmit over objSerial.TransmitBinary(byte[])
        private String CommandFormatter (DCommandList DCommand)
        {
            switch (DCommand)
            {
                case DCommandList.DAltitudeLimit:
                    ;
                    return "DAltitudeLimit";
                case DCommandList.DMoveAxis:
                    ;
                    return "DMoveAxis";
                case DCommandList.DSlewToAltAz:
                    ;
                    return "DSlewToAltAz";
                case DCommandList.DSlewing:
                    ;
                    return "DSlewing";
                case DCommandList.DAbortSlew:
                    ;
                    return "AbortSlew";
                case DCommandList.DAltitude:
                    ;
                    return "DAltitude";
                case DCommandList.DAzimuth:
                    ;
                    return "DAzimuth";
                case DCommandList.DSyncToAltAz:
                    ;
                    return "DSyncToAltAz";
                default:
                    return "not found - error";                
            }
        }


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

        // TEST IT LATER
        public byte[] doubleToShortBytes (double param1, double param2)
        {

            //float singleFloat1 = Convert.ToSingle(param1);
            //float singleFloat2 = Convert.ToSingle(param2);
            //byte[] byteArray1 = BitConverter.GetBytes(singleFloat1);
            //byte[] byteArray2 = BitConverter.GetBytes(singleFloat2);

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
            // and output only becomes 4 bytes....
            byteArray1.CopyTo(output, 0);
            byteArray2.CopyTo(output, byteArray1.Length);

            return output;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Sepikascope001"/> class.
        /// Must be public for COM registration.
        /// 
        /// TODO :
        /// INITIALIZE ALL RELEVANT FIELDS HERE!!!
        /// 
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

            actionsArrayList.Add("CanMoveAxis"); // returns true for azimuth
            //actionsArrayList.Add("MoveAxis");
            actionsArrayList.Add("SlewToAltAz"); // slews azimuth, not altitude yet
            actionsArrayList.Add("Slewing"); // returns false until
                                             // I implement threads
            //actionsArrayList.Add("AbortSlew");
            actionsArrayList.Add("Altitude"); // not implemented yet
            actionsArrayList.Add("Azimuth");  // returns arcminutes
            //actionsArrayList.Add("SyncToAltAz");
            actionsArrayList.Add("SupportedActions");
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
            else objSerial.Transmit(command + ";");

            //throw new ASCOM.MethodNotImplementedException("CommandBlind");
        }


        //raw means ready to Xmit
        //No error checking or Exceptions code yet
        public bool CommandBool(string command, bool raw)
        {

            CheckConnected("CommandBool");

            if (raw == true) objSerial.Transmit(command);
            else objSerial.Transmit(command + ";");

            string retval = objSerial.ReceiveTerminated(";");
            retval = retval.Replace(";", "");

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


            //THIS MIGHT WORK: StringInput -> CharArray -> ByteArray ##> TransmitBytes(...)

            //number of characters to convert
            int comlen = command.Length;
            
            //convert command string into character array
            char[] commandChars = command.ToCharArray();

            //create byte array to fit bytes from character array
            byte[] byteArray = new byte[comlen * 2];

            //convert each character to 2-byte, and copy the 2-byte into byteArray
            for (int i = 0; i < comlen; i++)
            {
                (BitConverter.GetBytes(commandChars[i])).CopyTo(byteArray, i*2);
            }

            objSerial.TransmitBinary(byteArray);

            //if (raw == true) objSerial.Transmit(command);
            //else objSerial.Transmit(command + ";");

            string retval = objSerial.ReceiveTerminated(";");
            //string retval = "finished;";
            retval = retval.Replace(";", "");
            return retval;

            //throw new ASCOM.MethodNotImplementedException("CommandString");
        }


        

        // this wont work, so we'll need an explicit function
        // possibly unsafe, to convert between byte arrays to char arrays
        // to strings
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
                objSerial.Transmit(";");
            }
            

            //byte[] terminatorBytes = new byte[] {Convert.ToByte(';')};

            //return "working";
            //return BitConverter.ToString(objSerial.ReceiveTerminatedBinary(terminatorBytes));
            //return objSerial.ReceiveTerminated(";");
            retval = objSerial.ReceiveTerminated(";");
            retval = retval.Replace(";", "");
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
                    objSerial.Port = 14;
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

                // TESTER
                byte[] byteArray = new byte[5] { 1, 1, 1, 1, Convert.ToByte(';') };

                return MyCommandString(byteArray, true);
                //return CommandFormatter(DCommandList.DAzimuth);
                //return ParamFormatter(0.01);
                //return name;
            }
        }

        #endregion

        #region ITelescope Implementation
        public void AbortSlew()
        {
            //tl.LogMessage("AbortSlew", "Not implemented");
            //throw new ASCOM.MethodNotImplementedException("AbortSlew");
            tl.LogMessage("AbortSlew", "Implemented");
            byte[] output = { Convert.ToByte('9'), 1, 1, 1, 1, Convert.ToByte(';') };
            MyCommandString(output, true);
            return;
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

                //TODO DEFINE the command chars/bytes
                byte[] output = new byte[6] { Convert.ToByte('3'), 1, 1, 1, 1, Convert.ToByte(';') };
                
                string retval = MyCommandString(output, true);

                //TODO DEFINE TERMINATEDBYTES as ';' and etc
                //byte[] terminatorBytes = new byte[] { Convert.ToByte(';') };
                //objSerial.ReceiveTerminatedBinary(terminatorBytes);

                return (Convert.ToDouble(retval));
            }
        }

        public double ApertureArea
        {
            get
            {
                tl.LogMessage("ApertureArea Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("ApertureArea", false);
            }
        }

        public double ApertureDiameter
        {
            get
            {
                tl.LogMessage("ApertureDiameter Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("ApertureDiameter", false);
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

                byte[] output = new byte[6] { Convert.ToByte('2'), 1, 1, 1, 1, Convert.ToByte(';') };

                string retval = MyCommandString(output, true);

                //TODO DEFINE TERMINATEDBYTES as ';' and etc
                //byte[] terminatorBytes = new byte[] { Convert.ToByte(';') };
                //objSerial.ReceiveTerminatedBinary(terminatorBytes);

                //COME BACK LATER
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

        public bool CanSlew
        {
            get
            {
                //tl.LogMessage("CanSlew", "Get - " + false.ToString());
                //return false;
                tl.LogMessage("CanSlew", "Get - " + true.ToString());
                return true;
            }
        }

        public bool CanSlewAltAz
        {
            get
            {
                //tl.LogMessage("CanSlewAltAz", "Get - " + false.ToString());
                //return false;
                tl.LogMessage("CanSlewAltAz", "Get - " + true.ToString());
                return true;
            }
        }

        public bool CanSlewAltAzAsync
        {
            get
            {
                //tl.LogMessage("CanSlewAltAzAsync", "Get - " + false.ToString());
                //return false;
                tl.LogMessage("CanSlewAltAzAsync", "Get - " + true.ToString());
                return true;
            }
        }

        public bool CanSlewAsync
        {
            get
            {
                //tl.LogMessage("CanSlewAsync", "Get - " + false.ToString());
                //return false;
                tl.LogMessage("CanSlewAsync", "Get - " + true.ToString());
                return true;
            }
        }

        public bool CanSync
        {
            get
            {
                tl.LogMessage("CanSync", "Get - " + false.ToString());
                return true;
            }
        }

        public bool CanSyncAltAz
        {
            get
            {
                tl.LogMessage("CanSyncAltAz", "Get - " + false.ToString());
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
            if (CanMoveAxis(Axis))
            {

                //String commString = Axis.ToString() + ", " + Rate.ToString();
                tl.LogMessage("MoveAxis", "Not implemented");
                throw new ASCOM.MethodNotImplementedException("MoveAxis");
                //tl.LogMessage("MoveAxis", "Move - " + Axis.ToString() + ", " + Rate.ToString());
                //
                //CommandBlind(commString, false);
                //CommandBlind(CommandFormatter(DCommandList.DMoveAxis), false);
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
            get
            {
                tl.LogMessage("SiteLatitude Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SiteLatitude", false);
            }
            set
            {
                tl.LogMessage("SiteLatitude Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SiteLatitude", true);
            }
        }

        public double SiteLongitude
        {
            get
            {
                tl.LogMessage("SiteLongitude Get", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SiteLongitude", false);
            }
            set
            {
                tl.LogMessage("SiteLongitude Set", "Not implemented");
                throw new ASCOM.PropertyNotImplementedException("SiteLongitude", true);
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

            if (((Azimuth <= 0.0) || (Azimuth >= 360.0)) || ((Altitude <= 0.0) || (Altitude >= 360.0)))
                throw new ASCOM.InvalidValueException("SlewToAltAz: Value out of range;");

            //multiply angle in degrees to get angle in minutes!!!
            //char param1 = Convert.ToChar((Convert.ToUInt16(Azimuth * 60.0)));
            //char param2 = Convert.ToChar((Convert.ToUInt16(Altitude * 60.0)));
            byte[] paramBytes = doubleToShortBytes(Azimuth, Altitude);


            //converts from 2 bytes, into unicode 16bit, thus 2 byte
            //converts one character at a time
            for (int i = 0; i < paramBytes.Length; i = i + 2)
            {
                stringOutgoing += BitConverter.ToChar(paramBytes, i); 
            }
                
            stringOutgoing += ";";

            //slewing may take some time to achieve, maybe 3 minutes?
            //we're waiting for confirmation from the Arduino
            objSerial.ReceiveTimeout = 120;

            stringIncoming = CommandString(stringOutgoing, true);

            objSerial.ReceiveTimeout = 5;

            //designed so that the return string is stripped of terminating char ';'
            if (!stringIncoming.Equals("Slewing Finished"))
                throw new ASCOM.DriverException("SlewtoAltAz - Fail;");

        }

        //COME BACK LATER
        public void SlewToAltAzAsync(double Azimuth, double Altitude)
        {
            //tl.LogMessage("SlewToAltAzAsync", "Not implemented");
            //throw new ASCOM.MethodNotImplementedException("SlewToAltAzAsync");
            tl.LogMessage("SlewToAltAzAsync", "Implemented");

            //string stringInput = "8";
            //string stringOutput = "";

            if (((Azimuth <= 0.0) || (Azimuth >= 360.0)) || ((Altitude <= 0.0) || (Altitude >= 360.0)))
                throw new ASCOM.InvalidValueException("SlewToAltAzAsync: Value out of range;");

            byte[] paramBytes = doubleToShortBytes(Azimuth, Altitude);
            byte[] output = new byte[paramBytes.Length + 2];

            output[0] = Convert.ToByte('8');
            paramBytes.CopyTo(output, 1);
            output[output.Length - 1] = Convert.ToByte(';');

            objSerial.ReceiveTimeout = 120;

            //MyCommandString(output, true);

            objSerial.ReceiveTimeout = 5;
        }

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

            byte[] paramBytes = doubleToShortBytes(Azimuth, Altitude);
            byte[] output = new byte[paramBytes.Length + 2];

            output[0] = Convert.ToByte('7');
            paramBytes.CopyTo(output, 1);
            output[output.Length - 1] = Convert.ToByte(';');

            MyCommandString(output, true);
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

        public bool Tracking
        {
            get
            {
                bool tracking = true;
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
            }
        }

        #endregion

    }
}
