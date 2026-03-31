using System;

namespace POE
{
    internal static class StringFormatter
    {
        // Method used for trimming spaces and lowercase
        public static string NormalizeInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            return input.Trim().ToLower();
        }

        // Stores the capitalization of the first letter of a name
        public static string CapitalizeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "User";

            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

        // Format tips for more readability 
        public static string FormatTip(string tip)
        {
            // improves readability
            return $"• {tip.Trim()}";
        }

        // This method is used to check if input contains any keyword
        public static bool ContainsKeyword(string input, string[] keywords)
        {
            input = NormalizeInput(input); // normalize once

            foreach (var keyword in keywords)
            {
                if (input.Contains(NormalizeInput(keyword)))
                    return true;
            }
            return false;
        }
    }
}