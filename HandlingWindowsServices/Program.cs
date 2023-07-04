using CommandLine;
using HandlingWindowsServices.Options;

namespace HandlingWindowsServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<CommandOptions>(args).WithParsed(RunOptions).WithNotParsed(HandleParseError);
        }

        static void RunOptions(CommandOptions opts)
        {
            //handle options
        }
        static void HandleParseError(IEnumerable<Error> errs)
        {
            //handle errors
        }
    }
}