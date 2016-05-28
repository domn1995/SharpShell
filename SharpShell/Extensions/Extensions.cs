using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShell.Extensions
{
    internal static class Extensions
    {
        internal static bool Equals(this string text, string compare)
        {
            return String.Equals(text, compare);
        }
    }
}
