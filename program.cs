using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace familyVacation

{


    class Program
    {
        static void Main(string[] args)
        
        {
            
            string[] events = new string[6];

            events[0] = "Beach";
            events[1] = "Sky Diving";
            events[2] = "Wine and Food Festival";
            events[3] = "Concerts";
            events[4] = "Amussement Park";
            events[5] = "Spa";

            Console.WriteLine("Family Vacation Activities:");

            foreach ( string s in events)
            {
                Console.WriteLine(s);
                //Console.WriteLine("/n");

                
            }

                Console.Read();
        }

              
    } 
}
