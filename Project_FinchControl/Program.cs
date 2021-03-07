using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Mission 3 Vorpagel
    // Description: CIT 110 - Mission 3
    // Application Type: Console
    // Author: Vorpagel, Ryan
    // Dated Created: 2/20/2021
    // Last Modified: 2/20/2021
    //
    // **************************************************

    class Program
    {
        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayMenuScreen(finchRobot);
                        break;

                    case "c":
                        DataRecorderDisplayMenuScreen(finchRobot);
                        break;

                    case "d":
                        AlarmSystemDisplayMenuScreen(finchRobot);
                        break;

                    case "e":
                        UserProgrammingDisplayMenuScreen(finchRobot);
                        break;

                    case "f":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        #region TALENT SHOW

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        static void TalentShowDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Dance Party");
                Console.WriteLine("\tc) Mix it up!");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayDance(finchRobot);
                        break;

                    case "c":
                        TalentShowDisplayMixingItUp(finchRobot);
                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayLightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("\t\t\t\t    Light and Sound");

            Console.WriteLine("\t\t\t\t\t\t   Lets Go Red Wings!");
            DisplayContinuePrompt();

            for (int count = 0; count < 3; count++)
            {
                //lets go red wings
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(784);
                finchRobot.wait(300);
                finchRobot.setLED(255, 255, 255);
                finchRobot.wait(300);
                finchRobot.noteOn(659);
                finchRobot.wait(300);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(784);
                finchRobot.wait(300);
                finchRobot.setLED(255, 255, 255);
                finchRobot.wait(300);
                finchRobot.noteOn(659);
                finchRobot.wait(300);
                finchRobot.noteOff();
                finchRobot.wait(150);

                // clap, clap
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(250);
                finchRobot.noteOn(523);
                finchRobot.wait(250);
                finchRobot.noteOff();
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(250);
                finchRobot.noteOn(523);
                finchRobot.wait(250);
                finchRobot.noteOff();
                finchRobot.wait(250);

                //clap, clap, clap
                finchRobot.noteOn(523);
                finchRobot.wait(150);
                finchRobot.noteOff();
                finchRobot.wait(50);
                finchRobot.noteOn(523);
                finchRobot.wait(150);
                finchRobot.noteOff();
                finchRobot.wait(50);
                finchRobot.noteOn(523);
                finchRobot.wait(150);
                finchRobot.noteOff();
                finchRobot.setLED(0, 0, 0);

            }

            
            DisplayMenuPrompt("Talent Show Menu");
        }


        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Dance                  *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayDance(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("\t\t\t\t\tDance Party");

            Console.WriteLine("\t\t\t\t  The Finch robot will not show off its dancing skills!");
            DisplayContinuePrompt();

            finchRobot.setLED(255, 0, 0);
            finchRobot.setMotors(200, 75);
            finchRobot.wait(3000);
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(255, 255, 255);
            finchRobot.setMotors(-200, -75);
            finchRobot.wait(3000);
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(255, 0, 0);
            finchRobot.setMotors(75, 75);
            finchRobot.wait(1500);
            finchRobot.setLED(255, 255, 255);
            finchRobot.setMotors(-75, -75);
            finchRobot.wait(1500);
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(0, 0, 0);

            DisplayMenuPrompt("Talent Show Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Mix It Up!                  *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayMixingItUp(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("\t\t\t\t\tMix it up!");

            Console.WriteLine("\t\t\t\t    The Finch robot will not show off all of its skills!");
            Console.WriteLine("\t\t\t\t   Finch is singing happy birthday to you while dancing!");
            DisplayContinuePrompt();


            
            //finchRobot.setMotors(200, 75);
            


            finchRobot.setLED(0, 255, 0);
            finchRobot.noteOn(784);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(0, 255, 255);
            finchRobot.noteOn(784);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(255, 0, 0);
            finchRobot.noteOn(880);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(0, 255, 0);
            finchRobot.noteOn(784);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(255, 0, 255);
            finchRobot.noteOn(1047);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(255, 255, 0);
            finchRobot.noteOn(988);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(0, 0, 0);
            finchRobot.wait(45);

            finchRobot.setLED(0, 255, 0);
            finchRobot.noteOn(784);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(150, 255, 86);
            finchRobot.noteOn(784);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(115, 45, 0);
            finchRobot.noteOn(880);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(255, 255, 255);
            finchRobot.noteOn(784);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(24, 45, 200);
            finchRobot.noteOn(1174);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(255, 12, 0);
            finchRobot.noteOn(1047);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.wait(50);

            finchRobot.setLED(0, 0, 153);
            finchRobot.noteOn(784);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(85, 0, 45);
            finchRobot.noteOn(784);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(255, 0, 255);
            finchRobot.noteOn(1567);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(0, 255, 84);
            finchRobot.noteOn(1318);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(255, 46, 200);
            finchRobot.noteOn(1047);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(15, 78, 103);
            finchRobot.noteOn(988);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(65, 142, 153);
            finchRobot.noteOn(880);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);

            finchRobot.setLED(255, 0, 0);
            finchRobot.noteOn(1396);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(0, 26, 255);
            finchRobot.noteOn(1396);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(46, 200, 78);
            finchRobot.noteOn(1318);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(125, 100, 200);
            finchRobot.noteOn(1047);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(78, 95, 108);
            finchRobot.noteOn(1174);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(255, 255, 255);
            finchRobot.noteOn(1047);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.wait(50);
            finchRobot.setLED(0, 0, 0);
            finchRobot.setMotors(0, 0);




            DisplayMenuPrompt("Talent Show Menu");
        }

        #endregion

        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("\t\t\t\tDisconnect Finch Robot");

            Console.WriteLine("\t\t\t\t\tAbout to disconnect from the Finch robot.");
            DisplayContinuePrompt();

            finchRobot.setLED(255, 0, 0);
            finchRobot.noteOn(880);
            finchRobot.wait(300);
            finchRobot.setLED(0, 255, 0);
            finchRobot.noteOn(698);
            finchRobot.wait(300);
            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(587);
            finchRobot.wait(300);
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            finchRobot.disConnect();

           
            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("\t\t\t\tConnect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            finchRobot.setLED(255, 0, 0);
            finchRobot.noteOn(587);
            finchRobot.wait(300);
            finchRobot.setLED(0, 255, 0);
            finchRobot.noteOn(698);
            finchRobot.wait(300);
            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(880);
            finchRobot.wait(300);
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();
            

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t     Finch Control");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t\t\t\tThis program is under construction! Please bare with us!");

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t      Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\t\t\t\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion

        #region Data Recorder
        static void DataRecorderDisplayMenuScreen(Finch finchRobot)
        {
            int numberOfDataPoints = 0;
            double dataPointFrequency = 0;
            double[] temperatures = null;
            
            
            Console.CursorVisible = true;

            bool quitDataRecorderMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Number of Data Points");
                Console.WriteLine("\tb) Frequency of Data Points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        numberOfDataPoints = DataRecorderDisplayGetNumberOfDataPoints();
                        break;

                    case "b":
                        dataPointFrequency = DataRecorderDisplayGetDataPointFrequency();
                        break;

                    case "c":
                        temperatures = DataRecorderDisplayGetData(numberOfDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "d":
                        DataRecorderDisplayData(temperatures);
                        break;

                    case "q":
                        quitDataRecorderMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitDataRecorderMenu);
        }
        static double DataRecorderDisplayGetDataPointFrequency()
        {
            
            string getFrequency;
            

            DisplayScreenHeader("\t\t\t\t\tGet Data Points");

            //Get input from user
            Console.WriteLine("How frequently would you like to record data? (in seconds)");
            getFrequency = Console.ReadLine();

            //validate user input
            if (string.IsNullOrEmpty(getFrequency))
            {
                Console.WriteLine("Frequency can not be empty! Please try again");
                getFrequency = Console.ReadLine();
            }
            double dataPointFrequency;
            while(!double.TryParse(getFrequency, out dataPointFrequency))
            {
                Console.WriteLine("That was not a number! Please try again");
                getFrequency = Console.ReadLine();
            }

            //read back input to the user
            Console.WriteLine("Data Frequency: " + dataPointFrequency);

            DisplayMenuPrompt("Data Recorder Menu");

            //return the variable created by user
            return dataPointFrequency;
        }

        static int DataRecorderDisplayGetNumberOfDataPoints()
        {
            
            string getNumberOfDataPoints;

            DisplayScreenHeader("\t\t\t\t\tGet Number of Data Points");

            //Get input from user
            Console.WriteLine("How many data points would you like to record?");
            getNumberOfDataPoints = Console.ReadLine();

            //validate user input
            if (string.IsNullOrEmpty(getNumberOfDataPoints))
            {
                Console.WriteLine("Number of data points can not be empty! Please try again");
                getNumberOfDataPoints = Console.ReadLine();
            }
            int numberOfDataPoints;
            while (!int.TryParse(getNumberOfDataPoints, out numberOfDataPoints))
            {
                Console.WriteLine("That was not a number! Please try again");
                getNumberOfDataPoints = Console.ReadLine();
            }

            //read back input to the user
            Console.WriteLine("Number of Data Points: " + numberOfDataPoints);

            DisplayMenuPrompt("Data Recorder Menu");

            //return the variable created by user
            return numberOfDataPoints;
        }

        static double[] DataRecorderDisplayGetData(int numberOFDataPoints, double datapointFrequency, Finch finchRobot)
        {
            double[] temperatures = new double[numberOFDataPoints];
            
            

            DisplayScreenHeader("\t\t\t\t\tGet Data:");

            Console.WriteLine($"Number of data points requested: {numberOFDataPoints}");
            Console.WriteLine($"Frequency of data points: {datapointFrequency}");
            Console.WriteLine();
            Console.WriteLine("The Finch is ready to begin recording temperature data");
            DisplayContinuePrompt();

            Console.WriteLine("Temperature readings in Celsius: ");
            Console.WriteLine();
            for (int i = 0; i < numberOFDataPoints; i++)
            {
                temperatures[i] = finchRobot.getTemperature();
                Console.WriteLine($"Temperature reading {i + 1} : {temperatures[i].ToString("n2")}");
                int waitInSeconds = (int)(datapointFrequency * 1000);
                finchRobot.wait(waitInSeconds);
            }
            ConvertCelsiusToFahrenheit(temperatures);

            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine("Temperature Readings in Fahrenheit: ");
            Console.WriteLine();
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Temperature reading {i + 1} : {temperatures[i].ToString("n2")}");

            }




            DisplayMenuPrompt("Data Recorder Menu");
            return temperatures;
        }

        static void DataRecorderDisplayData(double[] temperatures)
        {
            double[] tempsInCelsius = new double[temperatures.Length];

            DisplayScreenHeader("\t\t\t\t\tShow Data");

            Console.WriteLine("Temperatures in Fahrenheit: ");
            DataRecorderDisplayTable(temperatures);
            Console.WriteLine();

            for (int i = 0; i < temperatures.Length; i++)
            {
                tempsInCelsius[i] = ((temperatures[i] - 32) * .5556);
            }

            Console.WriteLine("Temperatures in Celsius: ");
            DataRecorderDisplayTable(tempsInCelsius);
            Console.WriteLine();


            DisplayMenuPrompt("Data Recorder Menu");
        }

        static void DataRecorderDisplayTable(double[] temperatures)
        {

            //
            //display table headers
            //
            Console.WriteLine(
                "Recording #".PadLeft(15) +
                "Temperature".PadLeft(15)
                );
            Console.WriteLine(
                "************".PadLeft(15) +
                "************".PadLeft(15)
                );

            //
            // Display Table Data
            //
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine(
                (i + 1).ToString().PadLeft(15) +
                temperatures[i].ToString("n2").PadLeft(15)
                );

            }
           
        }

        static double[] ConvertCelsiusToFahrenheit(double[] temperatures)
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = ((temperatures[i] * 9) / 5 + 32);
            }
            return temperatures;
        }
        #endregion

        #region Alarm System
        static void AlarmSystemDisplayMenuScreen(Finch finchRobot)
        {
            {
                Console.CursorVisible = true;
                DisplayScreenHeader("\t\t\t\tAlarm System Menu");

                //
                // get user menu choice
                //

                Console.WriteLine("\t\t\t     This menu is currently under construction! Check back later!");
                Console.WriteLine();
                Console.WriteLine();
                DisplayContinuePrompt();

                ///
                /// Saving this code for filling out the menu at a later date
                ///

                //bool quitTalentShowMenu = false;
                //string menuChoice;

                //do
                //{
                //    DisplayScreenHeader("Data Recorder Menu");

                //    //
                //    // get user menu choice
                //    //

                //    Console.WriteLine("This menu is currently under construction! Check back later!");
                //    Console.WriteLine();
                //    Console.WriteLine();
                //    DisplayContinuePrompt();
                //    break;

                //        //Console.WriteLine("\ta) Light and Sound");
                //        //Console.WriteLine("\tb) Dance Party");
                //        //Console.WriteLine("\tc) Mix it up!");
                //    //Console.WriteLine("\tq) Main Menu");
                //    //Console.Write("\t\tEnter Choice:");
                //    //menuChoice = Console.ReadLine().ToLower();

                //    //
                //    // process user menu choice
                //    //
                //    switch (menuChoice)
                //    {
                //        case "a":

                //            break;

                //        case "b":

                //            break;

                //        case "c":

                //            break;

                //        case "d":

                //            break;

                //        case "q":
                //            quitTalentShowMenu = true;
                //            break;

                //        default:
                //            Console.WriteLine();
                //            Console.WriteLine("\tPlease enter a letter for the menu choice.");
                //            DisplayContinuePrompt();
                //            break;
                //    }

                //} while (!quitTalentShowMenu);
            }


        }


        #endregion

        #region User Programming
        static void UserProgrammingDisplayMenuScreen(Finch finchRobot)
        {
            {
                Console.CursorVisible = true;
                DisplayScreenHeader("\t\t\t\tUser Programming Menu");

                //
                // get user menu choice
                //

                Console.WriteLine("\t\t\t     This menu is currently under construction! Check back later!");
                Console.WriteLine();
                Console.WriteLine();
                DisplayContinuePrompt();



                ///
                /// Saving this code for filling out the menu at a later date
                ///

                //bool quitTalentShowMenu = false;
                //string menuChoice;

                //do
                //{
                //    DisplayScreenHeader("Data Recorder Menu");

                //    //
                //    // get user menu choice
                //    //

                //    Console.WriteLine("This menu is currently under construction! Check back later!");
                //    Console.WriteLine();
                //    Console.WriteLine();
                //    DisplayContinuePrompt();
                //    break;

                //        //Console.WriteLine("\ta) Light and Sound");
                //        //Console.WriteLine("\tb) Dance Party");
                //        //Console.WriteLine("\tc) Mix it up!");
                //    //Console.WriteLine("\tq) Main Menu");
                //    //Console.Write("\t\tEnter Choice:");
                //    //menuChoice = Console.ReadLine().ToLower();

                //    //
                //    // process user menu choice
                //    //
                //    switch (menuChoice)
                //    {
                //        case "a":

                //            break;

                //        case "b":

                //            break;

                //        case "c":

                //            break;

                //        case "d":

                //            break;

                //        case "q":
                //            quitTalentShowMenu = true;
                //            break;

                //        default:
                //            Console.WriteLine();
                //            Console.WriteLine("\tPlease enter a letter for the menu choice.");
                //            DisplayContinuePrompt();
                //            break;
                //    }

                //} while (!quitTalentShowMenu);
            }


        }
        #endregion

    }
}
