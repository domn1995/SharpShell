using System;

namespace SharpShell.Helpers
{
    /// <summary>
    /// Contains useful extensions to the project.
    /// </summary>
    internal static class Extensions
    {
        internal static bool Equals(this string text, string compare)
        {
            return String.Equals(text, compare);
        }
    }
}
