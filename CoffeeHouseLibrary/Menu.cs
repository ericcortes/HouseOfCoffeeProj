using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouseLibrary
{
    public class Menu
    {
        public void Display()
        {

            try
            { 
                

            Coffee coffee = new Coffee();
            DailySales sales = new DailySales();
            EmployeeHours hours = new EmployeeHours();

            Console.WriteLine("Select an option");
            Console.WriteLine("(1) for coffee sales, (2) for Sandwich Sales, (3) Employee Hours ");
            
            string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        coffee.Coffeesales();
                        break;
                    case "2":
                        sales.SandwichSales();
                        break;
                    case "3":
                        hours.Hours();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fill in information correctly");
                Console.ReadLine();
                Display();
            }



        }
    }
}
