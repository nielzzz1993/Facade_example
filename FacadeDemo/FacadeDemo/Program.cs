using FacadeDemo.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // First Lets see How this is done without using the Facade
            Console.WriteLine("*** Jog without Facade ***");
            JoggWithoutUsingFacade();

            Console.WriteLine();
            // First Lets see How this is done using the FACADE
            Console.WriteLine("*** Jog Using Facade ***");
            JoggWithFacade();
            Console.ReadKey();
        }

        private static void JoggWithoutUsingFacade()
        {
            // The phone has been booted up and all the controllers are running
            GPSController gps = new GPSController();
            MobileDataController data = new MobileDataController();
            MusicController zune = new MusicController();
            WifiController wifi = new WifiController();

            ///////////// Going for Jogging /////////////////////

            // 1. Turn off the wifi
            wifi.IsSwitchedOn = false;

            // 2. Switch on the Mobile Data
            data.IsSwitchedOn = true;

            // 3. Turn on the GPS
            gps.IsSwitchedOn = true;

            // 4. Turn on the Music
            zune.IsSwitchedOn = true;

            // 5. Start the Sports-Tracker
            SportsTrackerApp app = new SportsTrackerApp();
            app.Start();

            ///////////// Back from Jogging /////////////////////
            Console.WriteLine();

            // 0. Share Sports tracker stats on twitter and facebook
            app.Share();

            // 1. Stop the Sports Tracker
            app.Stop();

            // 2. Turn off the Music
            zune.IsSwitchedOn = false;

            // 3. Turn off the GPS
            gps.IsSwitchedOn = false;

            // 4. Turn off the Mobile Data
            data.IsSwitchedOn = false;

            // 5. Turn on the wifi
            wifi.IsSwitchedOn = true;
        }

        private static void JoggWithFacade()
        {
            MyJoggingFacade facade = new MyJoggingFacade();

            facade.StartJogging();
            Console.WriteLine();
            facade.StopJogging();
        }
    }
}