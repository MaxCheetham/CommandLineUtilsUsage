using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;

namespace CommandLineUtilsUsage
{
        class DoSomthingClass : CommandLineApplication
        {
                private readonly CommandOption _optionOne;
                private readonly CommandOption _optionTwo;

                public DoSomthingClass()
                {
                        Name = "DoSomthing";
                        Description = "This Task Does Somthing";
                        _optionOne = Option("-o | --optionOne", "Info about Option One", CommandOptionType.SingleValue);
                        _optionTwo = Option("-t | --optionTwo", "Info about Option Two", CommandOptionType.SingleValue);
                        HelpOption("-? | -h | --help");
                        OnExecute((Func<int>)RunTheTask);
                }

                public int RunTheTask()
                {
                        //Do Things
                        return 10;
                }
        }

}       

