using System;

namespace POE
{
    internal static class DefaultResponse
    {
        // Method used for unknown user inputs
        public static void ReplyUnknown(string userInput, string userName)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n[Bot]: {userName}, I'm here to provide you with the best advice I can. Would you like advice on safe passwords, phishing, or secure browsing, or could you elaborate more on your question?");
            Console.ResetColor();
        }
    }
}

// Reference

// CodeBeauty, 2024. C# String – How to work with strings in C#? C# Programming tutorial for Beginners. [video online] Available at: <https://www.youtube.com/watch?v=nk2zDKK1pvA> [Accessed 31 March 2026].

// Proud, N., 2023. Create Your Own Chat App: SignalR Mastery in C# & ASP.NET. [video online] Available at: <https://www.youtube.com/watch?v=_gJ0NbNKKZg> [Accessed 31 March 2026].

// The Independent Institute of Education (IIE), 2026. Programming 2A [PROG6221/w Module Outline]. [online via internal VLE] The Independent Institute of Education. Available at: <Student Portal> [Accessed 31 March 2026].

// W3Schools, 2026. C# Tutorial. Available at: <https://www.w3schools.com/cs/index.php> [Accessed 31 March 2026].


