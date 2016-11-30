using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
    public class Being : Friend
    {
        

        public void Eat(string food)
        {
            Console.WriteLine($"Yum, I ate {food}");
        }


        public void GoToSleep()
        {
            if (true)
            {
                Console.WriteLine("I am sleeping");
            }

        }

        public void WakeUp()
        {
            if (true)
            {
                Console.WriteLine("I am awake");
            }
        }
    }
}
