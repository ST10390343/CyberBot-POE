using System;

namespace POE
{
    internal static class DefaultResponse
    {
        // Method used for unknown user inputs
        public static void ReplyUnknown(string userInput, string userName)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n[Bot]: {userName}, I'm here to provide you with the best advice I can. Would you like advice on safe passwords, phishing, or secure browsing, or could you elaborate more on your question?");
            Console.ResetColor();
        }
    }
}

