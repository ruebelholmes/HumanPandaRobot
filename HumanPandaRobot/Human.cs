using System;

namespace HumanPandaRobot
{
    public class Human
    {

        public string Name { get; set; }
        public string food { get; set; }

        public bool Asleep = false;

        public void DisplayName()
        {
            Console.WriteLine("My Name is Dave");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine("Hello from Dave");
        }

        public void Eat(string food)
        {

            Console.WriteLine($"Yum i ate {food}");
        }

        public void GoToSleep()
        {
            Asleep = true;
        }

        public void WakeUp()
        {
            Asleep = false;
        }

        public void IsASleep()
        {
            if (Asleep)
            {
                Console.WriteLine($"{Name} is asleep");
            }
        }

    }
}