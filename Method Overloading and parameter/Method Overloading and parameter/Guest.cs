using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_and_parameter
{
    public  class Guest
    {
        public  void  guestMessage()
        {
            Console.WriteLine("How Can I Help you");
        }
        public  void guestMessage(string guestName)
        {
            Console.WriteLine($"Good Day {guestName} , How Can I Help you");
        }

        public void DisplayPlayer(int id , string name="" , int goal=0, int age=0)
        {
            Console.WriteLine($"id is : {id} and name of player {name}");
        }

        public void namedparamter(int id, string name, int goal)
        {
            Console.WriteLine($"id is : {id} and name of player {name} and goal {goal}");
        }
    }
}
