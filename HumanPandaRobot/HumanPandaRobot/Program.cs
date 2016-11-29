using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Bebe = new Friend();
            var panda = new Panda();
            Bebe.Name = "My name is Bebe...I am a panda";
            Console.WriteLine(Bebe.DisplayName());
            panda.Eat("Bamboo");
            panda.GoToSleep();
            Console.ReadLine();

            var Hello = new Friend();
            var human = new Human();
            Hello.Name = "My name is Pepe,";
            Hello.Greeting = "Hello everyone";
            Console.WriteLine(Hello.Name +" "+ "I would like to say:" + " " + Hello.DisplayGreeting());
            human.Eat("Beef");
            human.WakeUp();
            Console.ReadLine();

            
            var robot = new Robots();
            robot.Name = "My name is Tech...Yes,";
            Console.WriteLine(robot.DisplayName());
            robot.IsTerminator();
            robot.ShutDown();
            Console.ReadLine();
            
            






        }


    }
}
