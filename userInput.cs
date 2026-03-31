using System;

namespace POE
{
    internal class UserInput
    {
        public static void RunChatbot(string userName)
        {
            // Just a friendly hello to the student/user with their name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHello {userName}, you may kindly ask me anything regarding cybersecurity or just chat with me!");
            Console.ResetColor();

            while (true)
            {
                // Prompting the user to type something
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string userInput = Console.ReadLine();

                // Input validation
                // If the user presses Enter without typing, we catch it here
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
                    Console.ResetColor();
                    continue; 
                }

                // Normalize input to lowercase so comparisons are easier
                userInput = userInput.ToLower();

                if (userInput == "exit")
                {
                    // Exit condition with a personalised goodbye
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Bot: Goodbye {userName}! Stay safe online.");
                    Console.ResetColor();
                    break; // break out of the loop
                }
                else if (userInput.Contains("how are you"))
                {
                    // Small talk response
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bot: I'm functioning perfectly, thanks for asking!");
                    Console.ResetColor();
                }
                else if (userInput.Contains("purpose"))
                {
                    // Explaining the bot’s purpose
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bot: My purpose is to teach you about cybersecurity awareness.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("what can i ask"))
                {
                    // Guiding the user on valid topics
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bot: You can ask me about password safety, phishing, or safe browsing tips.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("password"))
                {
                    // Cybersecurity tip: password safety
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Bot: Use long, complex passwords with numbers, symbols, and uppercase letters.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("phishing"))
                {
                    // Cybersecurity tip: phishing awareness
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Bot: Be cautious of emails with suspicious links or attachments.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("safe browsing"))
                {
                    // Cybersecurity tip: safe browsing
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Bot: Always keep your browser updated and avoid unsafe websites.");
                    Console.ResetColor();
                }
                else
                {
                    // Default response for unsupported queries
                    // If the bot doesn’t understand what its being asked then it will politely ask the user to rephrase
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Bot: I didn’t quite understand that, {userName}. Could you rephrase or ask about passwords, phishing, or safe browsing?");
                    Console.ResetColor();
                }
            }
        }
    }
}
