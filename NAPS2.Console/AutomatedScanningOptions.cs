﻿/*
    NAPS2 (Not Another PDF Scanner 2)
    http://sourceforge.net/projects/naps2/
    
    Copyright (C) 2009       Pavel Sorejs
    Copyright (C) 2012       Michael Adams
    Copyright (C) 2013       Peter De Leeuw
    Copyright (C) 2012-2013  Ben Olden-Cooligan

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;

namespace NAPS2.Console
{
    public class AutomatedScanningOptions : CommandLineOptions
    {
        [Option('o', "output", HelpText = "The name and path of the file to save." +
                                          "The extension determines the output type (e.g. .pdf for a PDF file, .jpg for a JPEG)." +
                                          "You can use \"<date>\" and/or \"<time>\" to insert the date/time of the scan.")]
        public string OutputPath { get; set; }

        [Option('p', "profile", HelpText = "The name of the profile to use for scanning." +
                                           "If not specified, the most-recently-used profile from the GUI is selected.")]
        public string ProfileName { get; set; }

        [Option('v', "verbose", HelpText = "Display progress information." +
                                           "If not specified, no output is displayed if the scan is successful.")]
        public bool Verbose { get; set; }

        [Option('n', "number", DefaultValue = 1, HelpText = "The number of scans to perform.")]
        public int Number { get; set; }

        [Option('d', "delay", DefaultValue = 0, HelpText = "The delay (in milliseconds) between each scan.")]
        public int Delay { get; set; }

        [Option('f', "force", HelpText = "Overwrite existing files." +
                                         "If not specified, any files that already exist will not be changed.")]
        public bool ForceOverwrite { get; set; }

        [Option('w', "wait", HelpText = "After finishing, wait for user input (enter/return) before exiting.")]
        public bool WaitForEnter { get; set; }

        [Option('e', "email", HelpText = "The name of the file to attach to an email." +
                                         "The extension determines the output type (e.g. .pdf for a PDF file, .jpg for a JPEG)." +
                                         "You can use \"<date>\" and/or \"<time>\" to insert the date/time of the scan.")]
        public string EmailFileName { get; set; }

        [Option("subject", HelpText = "The email message's subject." +
                                      "You can use \"<date>\" and/or \"<time>\" to insert the date/time of the scan." +
                                      "Requires -e/--email.")]
        public string EmailSubject { get; set; }

        [Option("body", HelpText = "The email message's body text." +
                                   "You can use \"<date>\" and/or \"<time>\" to insert the date/time of the scan." +
                                   "Requires -e/--email.")]
        public string EmailBody { get; set; }

        [Option("to", HelpText = "A comma-separated list of email addresses of the recipients." +
                                 "Requires -e/--email.")]
        public string EmailTo { get; set; }

        [Option("cc", HelpText = "A comma-separated list of email addresses of the recipients." +
                                 "Requires -e/--email.")]
        public string EmailCc { get; set; }

        [Option("bcc", HelpText = "A comma-separated list of email addresses of the recipients." +
                                  "Requires -e/--email.")]
        public string EmailBcc { get; set; }
    }
}
