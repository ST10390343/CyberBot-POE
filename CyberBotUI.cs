using System;
using System.Threading;

namespace POE
{
    internal static class CyberBotUI
    {
        // ASCII Art logo display
        public static void DisplayAsciiArt()
        {
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
       /\__/\ \__O (__)
      (--/\--)    \__/
      _)(  )(_
     `---''---`
=================================================================
";
            Console.WriteLine(asciiArt);
            Console.ResetColor();
        }

        // Typing effect for messages
        public static void DisplayTypedMessage(string messageText, int delay = 100)
        {
            foreach (char character in messageText)
            {
                Console.Write(character);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        // Display a colored divider line
        public static void DisplayDivider(string color = "cyan")
        {
            Console.ForegroundColor = color.ToLower() switch
            {
                "cyan" => ConsoleColor.Cyan,
                "green" => ConsoleColor.Green,
                "yellow" => ConsoleColor.Yellow,
                "red" => ConsoleColor.Red,
                "blue" => ConsoleColor.Blue,
                _ => ConsoleColor.White,
            };
            Console.WriteLine("==================================================================");
            Console.ResetColor();
        }
    }
}