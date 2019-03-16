using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouseLibrary
{
    class EmployeeHours
    {
        public void Hours()
        {
            try
            {
                Console.WriteLine($"How many hours did {employees.Eric} work?");
                double erichours = double.Parse(Console.ReadLine());


                Console.WriteLine($"How many hours did {employees.Elaine} work?");
                double elainehours = double.Parse(Console.ReadLine());


                Console.WriteLine($"How many hours did {employees.Jon} work?");
                double jonhours = double.Parse(Console.ReadLine());


                Console.WriteLine($"How many hours did {employees.Israel} work?");
                double israelhours = double.Parse(Console.ReadLine());


                Console.WriteLine($"How many hours did {employees.Lawrence} work?");
                double lawrencehours = double.Parse(Console.ReadLine());


                double erictotal = erichours * 12.50;
                double elainetotal = elainehours * 12.50;
                double jontotal = jonhours * 12.50;
                double israeltotal = israelhours * 12.50;
                double lawrencetotal = lawrencehours * 12.50;

                if (erichours > 40)
                {

                    double othours = erichours - 40;
                    double overtimehours = 18.75 * othours;

                    Console.WriteLine("Eric earned $500");
                    Console.WriteLine($"eric earned {overtimehours:c} in overtime");
                }
                else
                {
                    Console.WriteLine($"{employees.Eric} earned {erictotal:c}");
                }

                if (elainehours >= 40)
                {

                    double othours = elainehours - 40;
                    double overtimehours = 18.75 * othours;

                    Console.WriteLine($"elaine earned $500");
                    Console.WriteLine($"elaine earned {overtimehours:c} in overtime");
                }
                else
                {
                    Console.WriteLine($"{employees.Elaine} earned {elainetotal:c}");
                }


                if (jonhours > 40)
                {

                    double othours = jonhours - 40;
                    double overtimehours = 18.75 * othours;

                    Console.WriteLine("Jon earned $500");
                    Console.WriteLine($"jon earned {overtimehours:c} in overtime");
                }
                else
                {
                    Console.WriteLine($"{employees.Jon} earned {jontotal:c}");
                }


                if (israelhours > 40)
                {

                    double othours = israelhours - 40;
                    double overtimehours = 18.75 * othours;

                    Console.WriteLine("Israel earned $500");
                    Console.WriteLine($"israel earned {overtimehours} in overtime");
                }
                else
                {
                    Console.WriteLine($"{employees.Israel} earned {israeltotal:c}");
                }


                if (lawrencehours > 40)
                {

                    double othours = lawrencehours - 40;
                    double overtimehours = 18.75 * othours;

                    Console.WriteLine("Lawrence earned $500");
                    Console.WriteLine($"lawrence earned {overtimehours} in overtime");
                }
                else
                {
                    Console.WriteLine($"{employees.Lawrence} earned {lawrencetotal:c}");
                }

                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Fill in information correctly");
                Hours();
            }
        }
            
        enum employees
        {
            Eric, Elaine, Jon, Israel, Lawrence
        }
    }
}
