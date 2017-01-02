using System;
using System.Collections.Generic;
using System.IO;

namespace pixelarity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Parameters accepted by the user 
            List<string> parameters = new List<string>()
            {
                "template", // Name of the template
                "help"      // Displays usage information (i.e. ping /?)
            };   
        }

        public string RootDirectory
        {
            get
            {
                return Path.GetFullPath(Environment.ExpandEnvironmentVariables(@"%localappdata%\Pixelarity\CLI\"));
            }
        }
    }
}
