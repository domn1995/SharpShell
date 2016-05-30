using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShell.Parsing.Commands
{
    /// <summary>
    /// Used to indicate the valid arguments to a command.
    /// Used by the parser to map arguments to commands.
    /// Can only be used on methods.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class ArgumentsAttribute : Attribute
    {
        public readonly string[] validArgs;

        /// <summary>
        /// The strings passed 
        /// </summary>
        /// <param name="args">An array of valid string arguments.</param>
        public ArgumentsAttribute(params string[] args)
        {
            validArgs = args;
        }
    }
}