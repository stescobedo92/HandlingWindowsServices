using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HandlingWindowsServices.Options
{
    public class CommandOptions
    {
        [Option('c', "create", Required = false, HelpText = "Create a new service")]
        public bool CreateService { get; set; }

        [Option('r', "read", Required = false, HelpText = "Read data from a service.")]
        public string ReadDataFromService { get; }

        [Option('r', "remove", Required = false, HelpText = "Remove service")]
        public bool RemoveService { get; set; }
    }
}
