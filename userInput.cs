using System;
using System.Threading;

namespace POE
{
    internal class UserInput
    {
        public static void RunChatbot(string userName)
        {
            // Just a friendly hello to the student/user with their name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n==================================================================");
            Console.WriteLine($" Hello {userName}, welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("====================================================================");
            Console.ResetColor();

            while (true)
            {
                // Prompting the user to type something
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[You]: ");
                Console.ResetColor();

                string userInput = Console.ReadLine();

                // Input validation
                
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[Bot]: I didn’t quite understand that. Could you rephrase?");
                    Console.ResetColor();
                    continue; 
                }

                
                userInput = userInput.ToLower();

                if (userInput == "exit")
                {
                   
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n============================================");
                    Console.WriteLine($"[Bot]: Goodbye {userName}! Stay safe online.");
                    Console.WriteLine("==============================================");
                    Console.ResetColor();
                    break; 
                }
                else if (userInput.Contains("how are you"))
                {
                    // Small talk response
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n[Bot]: I'm functioning perfectly, thanks for asking!");
                    Console.ResetColor();
                }
                else if (userInput.Contains("purpose"))
                {
                    // The bots mission statement
                  
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n[Bot]: My purpose is to teach you about cybersecurity awareness.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("what can i ask"))
                {
                    // Guiding the user on valid topics to prompt the bot
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n[Bot]: You can ask me about password safety, phishing, or safe browsing tips.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("password"))
                {
                    // Cybersecurity tip: password safety
                    
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n[Bot]: Use long, complex passwords with numbers, symbols, and uppercase letters.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("phishing"))
                {
                    // Cybersecurity tip: phishing awareness
                    
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n[Bot]: Be cautious of emails with suspicious links or attachments.");
                    Console.ResetColor();
                }
                else if (userInput.Contains("safe browsing"))
                {
                    // Cybersecurity tip: safe browsing
                   
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n[Bot]: Always keep your browser updated and avoid unsafe websites.");
                    Console.ResetColor();
                }
                else
                {
                    
                    // Default response for unsupported queries If the bot doesn’t understand what it’s being asked then it will politely ask the user to rephrase

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\n[Bot]: I didn’t quite understand that, {userName}. Could you rephrase or ask about passwords, phishing, or safe browsing?");
                    Console.ResetColor();
                }

                
                // added  Typing effect simulation for realism and adds a slight pause before showing the next prompt for realism
                Thread.Sleep(400);
            }
        }
    }
}
