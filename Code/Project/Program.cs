using McMaster.Extensions.CommandLineUtils;
using System;

namespace SystemMonitor
{
    public class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                using CommandLineApplication commandLineApplication = new CommandLineApplication()
                {
                    Name = "project",
                };

                commandLineApplication.HelpOption();

                DefineCommand(commandLineApplication);

                return commandLineApplication.Execute(args);
            }
            catch
            {
                Console.Error.WriteLine("An unexpected error was produced.");

                return -1;
            }
        }

        private static void DefineCommand(CommandLineApplication commandLineApplication)
        {
            commandLineApplication.OnExecute(() =>
            {
                Console.WriteLine("This is a project template.");
            });
        }
    }
}