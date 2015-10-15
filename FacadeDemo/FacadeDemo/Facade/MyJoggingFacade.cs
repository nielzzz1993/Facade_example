using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDemo.Facade
{
    class MyJoggingFacade
    {
        // These handles will be passed to this facade in a real application
        // also on actual device these controllers will be singleton too.
        GPSController gps = new GPSController();
        MobileDataController data = new MobileDataController();
        MusicController zune = new MusicController();
        WifiController wifi = new WifiController();
        
        SportsTrackerApp app = null;
            
        public void StartJogging()
        {
            // 1. Turn off the wifi
            wifi.IsSwitchedOn = false;

            // 2. Switch on the Mobile Data
            data.IsSwitchedOn = true;

            // 3. Turn on the GPS
            gps.IsSwitchedOn = true;

            // 4. Turn on the Music
            zune.IsSwitchedOn = true;

            // 5. Start the Sports-Tracker
            app = new SportsTrackerApp();
            app.Start();
        }

        public void StopJogging()
        {
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
    }
}
