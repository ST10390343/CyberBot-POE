using System;

namespace POE
{
    internal static class CyberTips
    {
        // Method to provide cybersecurity tips based on user input
        public static bool ProvideCyberTip(string userInput)
        {
            if (userInput.Contains("password"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n[Bot]: " + StringFormatter.FormatTip(
                    "Use long, complex passwords with numbers, symbols, and uppercase letters."));
                Console.ResetColor();
                return true;
            }
            else if (userInput.Contains("phishing"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n[Bot]: " + StringFormatter.FormatTip(
                    "Be cautious of emails with suspicious links or attachments."));
                Console.ResetColor();
                return true;
            }
            else if (userInput.Contains("safe browsing"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n[Bot]: " + StringFormatter.FormatTip(
                    "Always keep your browser updated and avoid unsafe websites."));
                Console.ResetColor();
                return true;
            }

            return false; 
        }
    }
}