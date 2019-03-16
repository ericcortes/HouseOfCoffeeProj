using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouseLibrary
{
    class Coffee
    {

       
        
        int smallsold;
        int mediumsold;
        int largesold;

        public void Coffeesales()
        {
            try
            {


                Console.Clear();
                Console.WriteLine("How many small cups did we sell this week");
                smallsold = int.Parse(Console.ReadLine());
                Console.WriteLine("How many medium cups did we sell this week");
                mediumsold = int.Parse(Console.ReadLine());
                Console.WriteLine("How many large cups did we sell this week");
                largesold = int.Parse(Console.ReadLine());

                double smallprofits = (smallsold * Cups.smallcup) - (smallsold * Cups.smallcost);

                Console.WriteLine("you've made {0:c} dollars from small cups sold (Cost subtracted)", smallprofits);

                double mediumprofits = (mediumsold * Cups.mediumcup) - (mediumsold * Cups.mediumcost);

                Console.WriteLine("you've made {0:c} dollars from medium cups sold (Cost subtracted)", mediumprofits);

                double largeprofits = (largesold * Cups.largecup) - (largesold * Cups.largecost);

                Console.WriteLine("you've made {0:c} dollars from large cups sold (Cost subtracted)", largeprofits);

                double totalprofits = largeprofits + mediumprofits + smallprofits;

                Console.WriteLine("In total you have made {0:c} this week", totalprofits);

                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Fill out correctly");
                Console.ReadLine();
                Coffeesales();
            }
        }

        public struct Cups
        {
            public const double smallcup = 1.00;
            public const double mediumcup = 3.00;
            public const double largecup = 5.00;
            public const double smallcost = 0.10;
            public const double mediumcost = 0.15;
            public const double largecost = 0.20;
        } 
    
        
    }
}
