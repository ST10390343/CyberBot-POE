using System;
using System.Threading;

namespace POE
{
    internal static class UserInput
    {
        public static void RunChatbot(string userName)
        {
            // Friendly welcome with divider lines
            CyberBotUI.DisplayDivider();
            Console.WriteLine($" Hello {userName}, welcome to the Cybersecurity Awareness Bot!");
            CyberBotUI.DisplayDivider();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[You]: ");
                Console.ResetColor();

                string userInput = Console.ReadLine();

                // Input validation
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    DefaultResponse.ReplyUnknown(userInput, userName); // fixed
                    continue;
                }

                // Normalize input using StringFormatter
                userInput = StringFormatter.NormalizeInput(userInput);

                // Check for exit command
                if (userInput == "exit")
                {
                    ExitChat(userName);
                    break;
                }
                // Handle small talk responses
                else if (ResponseHandler.Respond(userInput, userName)) { }
                // Handle cybersecurity tips
                else if (CyberTips.ProvideCyberTip(userInput)) { } // fixed
                // Handle unknown inputs
                else
                {
                    DefaultResponse.ReplyUnknown(userInput, userName); // fixed
                }

                Thread.Sleep(400); // slight pause for readability
            }
        }

        // Exit method
        private static void ExitChat(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n============================================");
            Console.WriteLine($"[Bot]: Goodbye {userName}! Stay safe online.");
            Console.WriteLine("============================================");
            Console.ResetColor();
        }
    }
}