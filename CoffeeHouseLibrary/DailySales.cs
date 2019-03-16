using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouseLibrary
{
    class DailySales
    {
        public void SandwichSales()
        {

            try
            {


                Console.Clear();

                Console.WriteLine("How many egg sandwiches did we sell this week?");
                double amounteggsandwich = double.Parse(Console.ReadLine());

                double eggsandwichtotal = (sandwiches.eggsandwich * amounteggsandwich) - (amounteggsandwich * sandwiches.eggcost);


                Console.WriteLine("How many chicken biscuits did we sell this week?");
                double amountchicksandwich = double.Parse(Console.ReadLine());

                double chickentotal = (sandwiches.chickensandwich*amountchicksandwich) - (amountchicksandwich *sandwiches.chickencost);



                Console.WriteLine("you've made {0:c} dollars from egg sandwiches (Cost Subtracted)", eggsandwichtotal);
                Console.WriteLine("you've made {0:c} dollars from chicken biscuit sandwiches (Cost Subtracted)", chickentotal);

                double totalprofit = eggsandwichtotal + chickentotal;
                Console.WriteLine("In total you've made {0:c} this week from sandwiches", totalprofit);
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Fill in information correctly");
                Console.ReadLine();
                SandwichSales();
            }
            }
        
            
        

        public struct sandwiches
        {
            public const double eggsandwich = 5.50;
            public const double chickensandwich = 7.50;
            public const double eggcost = .95;
            public const double chickencost = 1.20;
        }
    }
}
