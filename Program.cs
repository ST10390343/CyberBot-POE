using System;
using System.Media;

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

            // Calling the UserInput loop
            UserInput.RunChatbot();
        }
    }
}
