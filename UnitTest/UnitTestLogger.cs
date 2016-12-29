using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCodeReview;

namespace UnitTest
{
    [TestClass]
    public class UnitTestLogger
    {
        [TestMethod]
        public void TestCreateLogger()
        {
            var jobLogger = Factory.CreateLogger(true, false, false);
            jobLogger.LogMessage("my message");
        }

        [TestMethod]
        public void TestDataBaseOperation()
        {
                 DatabaseOperation dataBaseOperation = DatabaseOperation.getDatabaseInstance();
                 dataBaseOperation.ExecuteSQLConection("my message 2", 2);
        }

        [TestMethod]
        public void TestConsoleOperation()
        {
            ConsoleOperation consoleOperation = ConsoleOperation.getConsoleOperationInstance();
            consoleOperation.WriteConsole("my message", ConsoleColor.Red);
        }

        [TestMethod]
        public void TestFileOperation()
        {
            FileOperation fileOperation = FileOperation.getConsoleOperationInstance();
            fileOperation.WriteTextFile("my message 2");
        }
    }
}
