using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrospeJeffreyAssignment01
{
    class HealthProfile
    {
        string name;
        string lastName;
        int birthYear;
        int height;
        int weight;
        int currentYear;

        public HealthProfile(string name, string lastName, int birthYear, int height, int weight,
            int currentYear)
        {
            this.Name = name;
            this.LastName = lastName;
            this.BirthYear = birthYear;
            this.Height = height;
            this.Weight = weight;
            this.CurrentYear = currentYear;
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public int Height { get => height; set => height = value; } // In inches
        public int Weight { get => weight; set => weight = value; } // In pounds
        public int CurrentYear { get => currentYear; set => currentYear = value; }


        public int PersonAge
        {
            get { return CurrentYear - BirthYear; }
        }

        public int GetMaxRate
        {
            get { return 220 - PersonAge; }
        }

        public int GetMinTargetRate
        {
            get { return Convert.ToInt32(GetMaxRate * 0.5); }
        }

        public int GetMaxTargetRate
        {
            get { return Convert.ToInt32(GetMaxRate * 0.85); }
        }

        public double PersonBMI
        {
            get { return (Convert.ToDouble(Weight) * 703) / (Convert.ToDouble(Height) * height); }
        }

        private void print<T>(T data)
        {
            Console.WriteLine(data);
        }

        public string bmiValue()
        {
            string result = "";
            if (PersonBMI >= 30)
            {
                result = "Obese";
            }
            else if (PersonBMI >= 25 || PersonBMI <= 29.9)
            {
                result = "Overweight";
            }
            else if (PersonBMI >= 18.5 || PersonBMI >= 24.9)
            {
                result = "Normal";
            }
            else { result = "Underweight"; }

            return result;
        }

        public void DisplayHealthRecord()
        {
            print($"|--------------------------------------------------------|");
            print($"|                 PATIENT HEAlTH RECORD                  |");
            print($"|--------------------------------------------------------|");
            print($"|Patient Name             | {Name},{LastName,-25} |");
            print($"|Patient Birth Year       | {BirthYear,28} |");
            print($"|Patient Age              | {PersonAge,28} |");
            print($"|Patient Height           | {Height,28} |");
            print($"|Patient Weight           | {Weight,28} |");
            print($"|Maximum Heart Rate       | {GetMaxRate,28} |");
            print($"|Target Heart Rate Range  | {GetMinTargetRate + "--" + GetMaxTargetRate,28} |");
            print($"|BMI Numeric Value        | {PersonBMI,28:F} |");
            print($"|BMI Text Value           | {bmiValue(),-28} |");
            print($"|--------------------------------------------------------|");
            print("");

        }

    }
}
