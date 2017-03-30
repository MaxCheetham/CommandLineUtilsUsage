using System;

namespace CommandLineUtilsUsage
{
        class Program
        {
                static void Main(string[] args)
                {
                        new CommandGroup().Execute(args);
                }
        }
}