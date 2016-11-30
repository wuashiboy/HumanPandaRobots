using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
   public class Friend
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public bool IsASleep { get; set; }

        public Friend()
        {
            this.Name = Name;
            this.Greeting = Greeting;
            this.IsASleep = true;
        }


        public string DisplayName()
        {
            return Name;
        }  

        public string DisplayGreeting()
        {
            return Greeting;
        }

       
    }
}
