using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;

namespace CommandLineUtilsUsage
{
        public class CommandGroup : CommandLineApplication
        {
                public CommandGroup()
                {
                        Commands.Add(new DoSomthingClass());
                        HelpOption("-h | -? | --help");
                }
        }
}
