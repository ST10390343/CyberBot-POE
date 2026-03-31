using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace POE
{
    internal static class ResponseHandler
    {
        // Method used to process small talk with the user
        public static bool Respond(string userInput, string userName)
        {
            // Normalize input to lowercase
            userInput = StringFormatter.NormalizeInput(userInput);

            if (userInput.Contains("how are you"))
            {
                DisplayBotMessage($"All systems are active, {userName}! I'm honored to share with you some cybersecurity guidance. Would you like to learn more about safe browsing, phishing, or passwords?");
                return true;
            }
            else if (userInput.Contains("purpose"))
            {
                DisplayBotMessage($"{userName}, my purpose is to teach you about cybersecurity awareness and help you stay safe online.");
                return true;
            }
            else if (userInput.Contains("what can i ask"))
            {
                DisplayBotMessage($"{userName},I can help you with three important areas: establishing safe passwords, identifying phishing efforts, and engaging in safe browsing. Which one do you want to investigate first?");
                return true;
            }

            // Input not recognized
            return false;
        }

        // Helper method to display bot messages consistently
        private static void DisplayBotMessage(string displayMessage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n[Bot]: {displayMessage}");
            Console.ResetColor();
        }
    }
}

// Reference

// CodeBeauty, 2024. C# String – How to work with strings in C#? C# Programming tutorial for Beginners. [video online] Available at: <https://www.youtube.com/watch?v=nk2zDKK1pvA> [Accessed 31 March 2026].

// Proud, N., 2023. Create Your Own Chat App: SignalR Mastery in C# & ASP.NET. [video online] Available at: <https://www.youtube.com/watch?v=_gJ0NbNKKZg> [Accessed 31 March 2026].

// The Independent Institute of Education (IIE), 2026. Programming 2A [PROG6221/w Module Outline]. [online via internal VLE] The Independent Institute of Education. Available at: <Student Portal> [Accessed 31 March 2026].

// W3Schools, 2026. C# Tutorial. Available at: <https://www.w3schools.com/cs/index.php> [Accessed 31 March 2026].
