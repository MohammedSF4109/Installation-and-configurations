using System;
using System.Diagnostics;

namespace GetEnvironmentalVariables
{
    class Program{
        public static void Main(string[] args)
        {
             //calling method to create text file
            //calling process method
            string variableName = Console.ReadLine();
            StartProcess(variableName);
        }

         static void StartProcess(string variableName)
        {
            //creating a process
            //creating instance of process to execute the process
            Process cmdStart = new Process();
            cmdStart.StartInfo.FileName = "cmd.exe";
            cmdStart.StartInfo.Arguments = $"/c echo %{variableName}%";
            cmdStart.Start();
        }

    }
}
