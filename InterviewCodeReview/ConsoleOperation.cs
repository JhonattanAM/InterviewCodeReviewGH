using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodeReview
{
   public class ConsoleOperation
    {
       static ConsoleOperation consoleOperation = null;

      private ConsoleOperation()
      {       
      }

       public static ConsoleOperation getConsoleOperationInstance()
      {
          if (consoleOperation == null)
          {
              return new ConsoleOperation();
          }

          return consoleOperation;
      }


       public void WriteConsole(string message, ConsoleColor consoleColor)
       {
           Console.ForegroundColor = consoleColor;
           Console.WriteLine(DateTime.Now.ToShortDateString() + message);
       }
    }
}
