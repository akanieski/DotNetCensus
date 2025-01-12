﻿using CommandLine;

namespace DotNetCensus
{
    public class Options
    {
        [Option('d', "directory", Required = false, HelpText = "Root directory to search for projects")]
        public string? Directory { get; set; }
        
        [Option('t', "Total", Required = false, Default = false, HelpText = "Include totals in results")]
        public bool IncludeTotals { get; set; }
        //[Option('o', "output", Required = false, HelpText = "output file to create csv file")]
        //public string OutputFile { get; set; }
    }
}
