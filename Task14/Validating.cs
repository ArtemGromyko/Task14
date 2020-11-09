using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task14
{
    static class Validating
    {
        public static bool Validate(string s)
        {
            Match match = Regex.Match(s, 
                @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (match.Success)
                return true;
            match = Regex.Match(s, @"((mailto\:|(news|(ht|f)tp(s?))\://){1}\S+)");
            if (match.Success)
                return true;
            match = Regex.Match(s, @"([a-zA-Z]:(\\w+)*\\[a-zA-Z0_9]+)");
            if (match.Success)
                return true;
            return false;
        }

    }
}
