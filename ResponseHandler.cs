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
                DisplayBotMessage("I'm functioning perfectly, thanks for asking!");
                return true;
            }
            else if (userInput.Contains("purpose"))
            {
                DisplayBotMessage("My purpose is to teach you about cybersecurity awareness.");
                return true;
            }
            else if (userInput.Contains("what can i ask"))
            {
                DisplayBotMessage("You can ask me about password safety, phishing, or safe browsing tips.");
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