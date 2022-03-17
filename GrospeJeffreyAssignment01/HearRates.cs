using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrospeJeffreyAssignment01
{
    class HearRates
    {
        private string fName;
        private string lName;
        private int birthYear;
        private int currentYear;

        private int BPM = 220;


        public HearRates(string fname, string lname, int bYear, int cYear)
        {
            fName = fname;
            lName = lname;
            BirthYear = bYear;
            CurrentYear = cYear;

        }

        public string Fname
        {
            get { return fName; }
            set { fName = value; }
        }

        public string Lname
        {
            get { return lName; }
            set { lName = value; }
        }

        public int BirthYear { get => birthYear; set => birthYear = value; }
        public int CurrentYear { get => currentYear; set => currentYear = value; }

      

        public int GetAge
        {
            get { return currentYear - birthYear; }
        }

        public int GetMaxRate
        {
            get { return BPM - GetAge; }
        }

        public int GetMinTargetRate
        {
            get { return Convert.ToInt32(GetMaxRate * 0.5); }
        }

        public int GetMaxTargetRate
        {
            get { return Convert.ToInt32(GetMaxRate * 0.85); }
        }

        private void print<T>(T data)
        {
            Console.WriteLine(data);
        }

        public void DisplayPatientRecord()
        {
            print($"|-------------------------------------------------------------|");
            print($"|           PATIENT HEART RATE RECORD                         |");
            print($"|-------------------------------------------------------------|");
            print($"|Patient Name            | {Lname},{Fname,-30} |");
            print($"|Patient Birth Year      | {BirthYear,34} |");
            print($"|Patient Age             | {GetAge,34} |");
            print($"|Maximum Heart Rate      | {GetMaxRate,34} |");
            print($"|Target Heart Rate Range | {GetMinTargetRate+ "--" + GetMaxTargetRate,34} |");
            print($"|-------------------------------------------------------------|");
            print("");

        }
    }
}
