using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
          string answer = Console.ReadLine();

            if (answer=="Yes")
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\w3\PU_IntroCSharp_InClass_1801681034\W3InClass\MusicFactory\music\Dynoro feat. Gigi DAgostino - In My Mind.mp3"))
                { 
                    
                    player.PlaySync();
                    while(true)
                    {
                        Console.WriteLine(".");
                    }
                }
            }      
            else if (answer== "No")
            {
                Console.WriteLine("GoodBye");
            }
               else
            {
                Console.WriteLine("Wrong input");
            }
        
           

        }
    }
}
