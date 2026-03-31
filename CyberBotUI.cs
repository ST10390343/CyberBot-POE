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

// Reference

// CodeBeauty, 2024. C# String – How to work with strings in C#? C# Programming tutorial for Beginners. [video online] Available at: <https://www.youtube.com/watch?v=nk2zDKK1pvA> [Accessed 31 March 2026].

// Proud, N., 2023. Create Your Own Chat App: SignalR Mastery in C# & ASP.NET. [video online] Available at: <https://www.youtube.com/watch?v=_gJ0NbNKKZg> [Accessed 31 March 2026].

// The Independent Institute of Education (IIE), 2026. Programming 2A [PROG6221/w Module Outline]. [online via internal VLE] The Independent Institute of Education. Available at: <Student Portal> [Accessed 31 March 2026].

// W3Schools, 2026. C# Tutorial. Available at: <https://www.w3schools.com/cs/index.php> [Accessed 31 March 2026].
