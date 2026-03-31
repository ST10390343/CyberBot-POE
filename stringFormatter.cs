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

// Reference

// CodeBeauty, 2024. C# String – How to work with strings in C#? C# Programming tutorial for Beginners. [video online] Available at: <https://www.youtube.com/watch?v=nk2zDKK1pvA> [Accessed 31 March 2026].

// Proud, N., 2023. Create Your Own Chat App: SignalR Mastery in C# & ASP.NET. [video online] Available at: <https://www.youtube.com/watch?v=_gJ0NbNKKZg> [Accessed 31 March 2026].

// The Independent Institute of Education (IIE), 2026. Programming 2A [PROG6221/w Module Outline]. [online via internal VLE] The Independent Institute of Education. Available at: <Student Portal> [Accessed 31 March 2026].

// W3Schools, 2026. C# Tutorial. Available at: <https://www.w3schools.com/cs/index.php> [Accessed 31 March 2026].
