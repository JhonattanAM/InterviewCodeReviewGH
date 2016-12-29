using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodeReview
{
    public static class Factory
    {
        public static JobLogger CreateLogger(bool message, bool warning, bool error)
        {
            if (message)
                return new JobLoggerMessage();
            else if (warning)
                return new JobLoggerWarning();
            else if (error)
                return new JobLoggerError();
            else
                throw new Exception("Error or Warning or Message must be specified");
        }
    }
}
