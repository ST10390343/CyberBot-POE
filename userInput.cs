using System;

namespace POE
{
    internal class UserInput
    {
        public static void RunChatbot()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, let’s talk about staying safe online.");

            while (true)
            {
                Console.WriteLine("\nChoose a topic: (1) Passwords (2) Phishing (3) Exit");
                string choice = Console.ReadLine();

                if (choice == "1")
                    Console.WriteLine(StringManipulation.FormatTip("Use at least 12 characters, mix letters, numbers, and symbols."));
                else if (choice == "2")
                    Console.WriteLine(StringManipulation.FormatTip("Never click suspicious links or attachments in emails."));
                else if (choice == "3")
                {
                    Console.WriteLine("Goodbye! Stay safe online.");
                    break;
                }
                else
                    Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
