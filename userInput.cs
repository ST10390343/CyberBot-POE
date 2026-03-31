using System;
using System.Threading;

namespace POE
{
    internal static class UserInput
    {
        public static void RunChatbot(string userName)
        {
            // A Friendly warm welcome with divider lines for better readability
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
                    DefaultResponse.ReplyUnknown(userInput, userName); 
                    continue;
                }

                
                userInput = StringFormatter.NormalizeInput(userInput);

                
                if (userInput == "exit")
                {
                    ExitChat(userName);
                    break;
                }
                
                else if (ResponseHandler.Respond(userInput, userName)) { }
                
                else if (CyberTips.ProvideCyberTip(userInput, userName)) { }


                else
                {
                    DefaultResponse.ReplyUnknown(userInput, userName); 
                }

                // helps with pausing for better ui experience
                Thread.Sleep(400); 
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

              // Help method
        private static void DisplayHelp(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n[Bot]: {userName}, here are some things you can ask me about:");
            Console.WriteLine(" • Password safety");
            Console.WriteLine(" • Phishing awareness");
            Console.WriteLine(" • Safe browsing practices");
            Console.WriteLine(" • Updating software regularly");
            Console.WriteLine(" • Using two-factor authentication (2FA)");
            Console.WriteLine("You can also type 'exit' anytime to leave the chat.");
            Console.ResetColor();
        }
    }
}