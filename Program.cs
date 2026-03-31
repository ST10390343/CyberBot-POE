using System;
using System.Media;
using System.Threading;

namespace POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Chatbot Welcome voice greeting
            SoundPlayer player = new SoundPlayer(@"C:\Users\lab_services_student\source\repos\POE\POE\Media\Welcome.wav");
            player.Play();

            Console.WriteLine("Welcome to the Phodzo Cybersecurity Awareness Bot!");

            // ASCII Art logo design
            Console.ForegroundColor = ConsoleColor.Blue;
            string asciiArt = @"
=================================================================
 PHODZO SECURITY BOT v1.5
=================================================================

 > Initializing security awareness system...
 > Status: ACTIVE
        ____
    __  /  \  __
 _(\    |@@|
(__/\__ \--/ __
   \___|----|  |   __
       \ }{ /\ )_ / _\
       /\__/\ \__O (__
      (--/\--)    \__/
      _)(  )(_
     `---''---`
=================================================================
";
            Console.WriteLine(asciiArt);
            Console.ResetColor();

            // Typing effect for loading message
            string loadingMessage = "Preparing your personalised experience...";
            foreach (char c in loadingMessage)
            {
                Console.Write(c);
                Thread.Sleep(100); 
            }
            Console.WriteLine();

            // Pause for 1.5 seconds before name prompt
            Thread.Sleep(1000);

            // Ask for user's name
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please enter your name: ");
            Console.ResetColor();

            string userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hello {userName}, welcome to the Cybersecurity Awareness Bot!");
            Console.ResetColor();

            // Pass the name into the chatbot loop
            UserInput.RunChatbot(userName);
        }
    }
}
