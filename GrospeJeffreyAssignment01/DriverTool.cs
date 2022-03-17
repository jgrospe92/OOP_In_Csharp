using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrospeJeffreyAssignment01
{
    class DriverTool
    {

        public DriverTool()
        {
           
        }

        private void print<T>(T data)
        {
            Console.Write(data);
        }

      
        public HearRates userInputHearRate()
        {
            
            print("Enter your first name: ");
            string fName = Console.ReadLine();
            print("Enter your last name: ");
            string lName = Console.ReadLine();
            print("Enter your birth year: ");
            int bYear = int.Parse(Console.ReadLine());
            print("Enter current year: ");
            int cYear = int.Parse(Console.ReadLine());
            HearRates data = new HearRates(fName, lName, bYear, cYear);

            return data;
        }

        public HealthProfile userInputHealthProfile()
        {
            print("Enter your first name: ");
            string fName = Console.ReadLine();
            print("Enter your last name: ");
            string lName = Console.ReadLine();
            print("Enter your birth year: ");
            int bYear = int.Parse(Console.ReadLine());
            print("Enter your height(inches): ");
            int height = int.Parse(Console.ReadLine());
            print("Enter your weight(pounds): ");
            int weight = int.Parse(Console.ReadLine());
            print("Enter current year: ");
            int cYear = int.Parse(Console.ReadLine());
            HealthProfile data = new HealthProfile(fName, lName, bYear, height, weight, cYear);

            return data;
        }

    }
}
