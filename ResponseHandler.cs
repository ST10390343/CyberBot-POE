using System;

namespace POE
{
    internal static class ResponseHandler
    {
        // Method used to process small talk with the user
        public static bool Respond(string userInput, string userName)
        {
            // Normalize input to lowercase
            userInput = StringFormatter.NormalizeInput(userInput);

            if (userInput.Contains("how are you"))
            {
                DisplayBotMessage($"All systems are active, {userName}! I'm honored to share with you some cybersecurity guidance. Would you like to learn more about safe browsing, phishing, or passwords?");
                return true;
            }
            else if (userInput.Contains("purpose"))
            {
                DisplayBotMessage($"{userName}, my purpose is to teach you about cybersecurity awareness and help you stay safe online.");
                return true;
            }
            else if (userInput.Contains("what can i ask"))
            {
                DisplayBotMessage($"{userName},I can help you with three important areas: establishing safe passwords, identifying phishing efforts, and engaging in safe browsing. Which one do you want to investigate first?");
                return true;
            }

            // Input not recognized
            return false;
        }

        // Helper method to display bot messages consistently
        private static void DisplayBotMessage(string displayMessage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n[Bot]: {displayMessage}");
            Console.ResetColor();
        }
    }
}
