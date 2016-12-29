using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodeReview
{
    public class FileOperation
    {
          static FileOperation fileOperation = null;

          private FileOperation()
          {       
          }

          public static FileOperation getConsoleOperationInstance()
          {
              if (fileOperation == null)
              {
                  return new FileOperation();
              }

              return fileOperation;
          }

        public void WriteTextFile(string message)
        {
            string textLog = null;
            string fileName = string.Format("{0}LogFile{1}.txt", ConfigurationManager.AppSettings[Constant.LogFileDirectory], DateTime.Now.ToShortDateString());
            if (!System.IO.File.Exists(fileName))
            {
                FileInfo file = new FileInfo(fileName);
                file.Directory.Create();
                textLog = fileName;
            }
            textLog = string.Format("{0}{1}{2}", textLog , DateTime.Now.ToShortDateString() ,message);
            System.IO.File.WriteAllText(fileName, textLog);
        }
    }
}
