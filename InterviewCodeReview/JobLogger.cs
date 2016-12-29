using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodeReview
{
    public abstract class JobLogger
    {
        protected int _idTypeLog;
        protected ConsoleColor _consoleColor;
        protected ConsoleOperation consoleOperation = null;
        protected FileOperation fileOperation = null;
        public DatabaseOperation dataBaseOperation = null;

        public JobLogger()
        {
            consoleOperation = ConsoleOperation.getConsoleOperationInstance();
            fileOperation = FileOperation.getConsoleOperationInstance();
            dataBaseOperation = DatabaseOperation.getDatabaseInstance();
        }

        public virtual void LogMessage(string message)
        {
            throw new Exception("Invalid configuration");
        }       
    }

    public class JobLoggerError : JobLogger
    {
        public JobLoggerError()
        {
            this._idTypeLog = 2;
            this._consoleColor = ConsoleColor.Red;
        }
        public override void LogMessage(string message)
        {            
            dataBaseOperation.ExecuteSQLConection(message, _idTypeLog);
            fileOperation.WriteTextFile(message);
            consoleOperation.WriteConsole(message, _consoleColor);            
        }
    }

    public class JobLoggerWarning : JobLogger
    {
        public JobLoggerWarning()
        {
            this._idTypeLog = 3;
            this._consoleColor = ConsoleColor.Yellow;
        }
        public override void LogMessage(string message)
        {
            dataBaseOperation.ExecuteSQLConection(message, _idTypeLog);
            fileOperation.WriteTextFile(message);
            consoleOperation.WriteConsole(message, _consoleColor);       
        }
    }

    public class JobLoggerMessage : JobLogger
    {
        public JobLoggerMessage()
        {
            this._idTypeLog = 1;
            this._consoleColor = ConsoleColor.White;
        }
        public override void LogMessage(string message)
        {
            dataBaseOperation.ExecuteSQLConection(message, _idTypeLog);
            fileOperation.WriteTextFile(message);
            consoleOperation.WriteConsole(message, _consoleColor);        
        }
    }
}