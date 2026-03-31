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

// Reference

// CodeBeauty, 2024. C# String – How to work with strings in C#? C# Programming tutorial for Beginners. [video online] Available at: <https://www.youtube.com/watch?v=nk2zDKK1pvA> [Accessed 31 March 2026].

// Proud, N., 2023. Create Your Own Chat App: SignalR Mastery in C# & ASP.NET. [video online] Available at: <https://www.youtube.com/watch?v=_gJ0NbNKKZg> [Accessed 31 March 2026].

// The Independent Institute of Education (IIE), 2026. Programming 2A [PROG6221/w Module Outline]. [online via internal VLE] The Independent Institute of Education. Available at: <Student Portal> [Accessed 31 March 2026].

// W3Schools, 2026. C# Tutorial. Available at: <https://www.w3schools.com/cs/index.php> [Accessed 31 March 2026].
