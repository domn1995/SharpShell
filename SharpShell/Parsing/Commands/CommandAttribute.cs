using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShell.Parsing.Commands
{
    /// <summary>
    /// Used by the parser to map commands and arguments to methods.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class CommandAttribute : Attribute
    {
        public readonly string[] ValidCommands;

        public CommandAttribute(params string[] validCommands)
        {
            ValidCommands = validCommands;
        }
    }
}