using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hHuman = new Human();
            Panda pPanda = new Panda();
            Robot rRobot = new Robot();

            //names
            //greetings
            hHuman.DisplayName();

            rRobot.DisplayName();

            pPanda.DisplayName();

            hHuman.DisplayGreeting();

            pPanda.DisplayGreeting();

            rRobot.DisplayGreeting();


            //eat
            hHuman.Eat("Burger");

            pPanda.Eat("Bamboo");

            //Sleep
            hHuman.Asleep = true;

            pPanda.Asleep = true;

            //robot
            rRobot.Terminator = true;

            rRobot.StartUp();

            rRobot.ShutDown();

            Console.ReadLine();


        }

    }
}

