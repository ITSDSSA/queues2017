using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Program
    {
        static Queue<int> choices = new Queue<int>();
        static void Main(string[] args)
        {
            int choice = 0;
            choices.Enqueue(4);
            choices.Enqueue(2);
            choices.Enqueue(1);
            char ans = '0';
            
            while(ans != 'q')
            {
                Console.WriteLine("Press 'q' to quit 't' to toggle");
                ans = Console.ReadKey().KeyChar;
                if(ans == 't')
                {
                    choice = choices.Dequeue();
                    choices.Enqueue(choice);
                    Console.WriteLine("Current choice {0}",choice);
                }

            }
        }
    }
}
