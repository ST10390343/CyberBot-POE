using System;
using System.Media;
using System.Threading;

namespace POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Chatbot welcome voice greeting
            try
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\lab_services_student\source\repos\POE\POE\Media\Welcome.wav");
                player.Play();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Audio failed to play: " + ex.Message);
                Console.ResetColor();
            }

            // ASCII Art logo display
            CyberBotUI.DisplayAsciiArt();

            // Typing effect for the loading message
            CyberBotUI.DisplayTypedMessage("Preparing your personalised experience...");

            Thread.Sleep(1000);

            // Ask for user's name
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please enter your name: ");
            Console.ResetColor();
        
            string userName;

            // Handle empty or invalid input
            while (true)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    userName = StringFormatter.CapitalizeName(input);
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Incorrect entry. Kindly type your name: ");
                Console.ResetColor();
            }

            // Pass userName along so the bot can personalize responses
            UserInput.RunChatbot(userName);
        }
    }
}