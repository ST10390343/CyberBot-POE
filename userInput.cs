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

// Reference

// CodeBeauty, 2024. C# String – How to work with strings in C#? C# Programming tutorial for Beginners. [video online] Available at: <https://www.youtube.com/watch?v=nk2zDKK1pvA> [Accessed 31 March 2026].

// Proud, N., 2023. Create Your Own Chat App: SignalR Mastery in C# & ASP.NET. [video online] Available at: <https://www.youtube.com/watch?v=_gJ0NbNKKZg> [Accessed 31 March 2026].

// The Independent Institute of Education (IIE), 2026. Programming 2A [PROG6221/w Module Outline]. [online via internal VLE] The Independent Institute of Education. Available at: <Student Portal> [Accessed 31 March 2026].

// W3Schools, 2026. C# Tutorial. Available at: <https://www.w3schools.com/cs/index.php> [Accessed 31 March 2026].
