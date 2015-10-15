using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDemo
{
    class MobileDataController
    {
        bool isSwitchedOn = false;

        public bool IsSwitchedOn
        {
            get 
            { 
                return isSwitchedOn; 
            }
            set 
            { 
                isSwitchedOn = value;
                DisplayStatus();
            }
        }

        private void DisplayStatus()
        {
            string status = (isSwitchedOn == true) ? "ON" : "OFF";
            Console.WriteLine("Mobile Data Switched {0}", status);
        }
    }
}
