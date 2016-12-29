using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var jobLogger = Factory.CreateLogger(true, false, false);
            jobLogger.LogMessage("my message");

            Console.ReadLine();
        }
    }
}
