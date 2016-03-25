using System;

namespace HumanPandaRobot
{
    class Panda
    {
        public string Name { get; set; }

        public string food { get; set; }

        public bool Asleep = true;

        public void DisplayName()

        {
            Console.WriteLine("My name is Ling Ling");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine("Hello from Ling Ling");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Yum i ate {food}");
        }

        public void GoToSLeep()
        {
            Asleep = true;
        }

        public void WakeUp()
        {
            Asleep = false;
        }

        public void IsAsleep()
        {
            if (Asleep)
            {
                Console.WriteLine("Panda is asleep");
            }
        }
    }

}