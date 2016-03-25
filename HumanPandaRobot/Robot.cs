using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
    public class Robot
    {

        public void DisplayName()
        {
            Console.WriteLine("My Name is HAL-1000");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine("Hello from HAL");
        }

        public string StartUp()
        {
            return "Started";
        }

        public string ShutDown()
        {
            return "Shutdown";
        }

        public void IsTerminator()
        {
            if (Terminator)
            {
                Console.WriteLine("I'm a terminator");
            }
            else
            {
                Console.WriteLine("I'm not a Terminator");
            }
        }

        public void isAsleep()
        {
            if (IsShutdown)
            {
                Console.WriteLine("ShutDown");
            }
        }

        public bool Terminator = false;

        public bool IsShutdown = true;








    }
}