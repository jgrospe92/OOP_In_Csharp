using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrospeJeffreyAssignment01
{
    class ProgramW
    {
        static void print<T>(T data)
        {
            Console.WriteLine(data);
        }
        static void Main(string[] args)
        {
            DriverTool d1 = new DriverTool();

            // For Problem 1
            //d1.userInputHearRate().DisplayPatientRecord();

            // For Problem 2
            //d1.userInputHealthProfile().DisplayHealthRecord();

            Console.ReadLine();

        }
    }
}
