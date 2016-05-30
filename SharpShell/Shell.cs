using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpShell.History;
using SharpShell.Parsing.Commands;

namespace SharpShell
{
    /// <summary>
    /// Encapsulates the entire SharpShell's functionality.
    /// </summary>
    public class Shell
    {
        public History<string> History;
        public CommandParser CommandParser;

        public Shell()
        {
            History = new History<string>();
            CommandParser = new CommandParser();
        }
    }
}
