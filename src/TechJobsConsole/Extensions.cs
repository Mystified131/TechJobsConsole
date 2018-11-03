using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace TechJobsConsole
{
   public static class Extensions

    {
        public static bool CaseInsensitiveContains(this string text, string value, System.StringComparison stringComparison = System.StringComparison.CurrentCultureIgnoreCase)

        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

    }
}
