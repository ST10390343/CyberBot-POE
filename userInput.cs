using System;

namespace POE
{
    internal class UserInput
    {
        public static void RunChatbot(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHello {userName}, you may kindly ask me anything regarding cybersecurity or just chat with me!");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string userInput = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: Please type something.");
                    Console.ResetColor();
                    continue;
                }

                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Bot: Goodbye {userName}! Stay safe online.");
                    Console.ResetColor();
                    break;
                }
                else if (userInput.Contains("how are you"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bot: I'm functioning perfectly, thanks for asking!");
                    Console.ResetColor();
                }
                else if (userInput.Contains("purpose"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bot: My purpose is to teach you about cybersecurity awareness.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("what can i ask"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bot: You can ask me about password safety, phishing, or safe browsing tips.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("password"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Bot: Use long, complex passwords with numbers, symbols, and uppercase letters.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("phishing"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Bot: Be cautious of emails with suspicious links or attachments.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("safe browsing"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Bot: Always keep your browser updated and avoid unsafe websites.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Bot: Sorry {userName}, I don’t understand that. Try asking about passwords, phishing, or safe browsing.");
                    Console.ResetColor();
                }
            }
        }
    }
}


