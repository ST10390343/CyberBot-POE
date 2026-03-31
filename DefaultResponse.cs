using System;

namespace POE
{
    internal static class DefaultResponse
    {
        // Method used for unknown user inputs
        public static void ReplyUnknown(string userInput, string userName)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n[Bot]:I didn't fully comprehend that, {userName}. Could you clarify or request information about safe browsing, phishing, or passwords?");
            Console.ResetColor();
        }
    }
}
