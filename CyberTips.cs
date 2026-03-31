using System;

namespace POE
{
    internal static class CyberTips
    {
        private static Random rand = new Random();

        public static bool ProvideCyberTip(string userInput, string userName)
        {
            // Method to provide cybersecurity tips based on user input
            if (userInput.Contains("password"))
            {
                string[] passwordTips = {
                        $"{userName}, remember to use long, complex passwords with numbers, symbols, and uppercase letters.",
                   $"{userName}, Never use the same password for more than one account.",
                        $"{userName},  In order to securely keep track of your login information, consider using a password manager."
                    
                
                };
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n[Bot]: {passwordTips[rand.Next(passwordTips.Length)]}");
                Console.ResetColor();
                return true;
          }
            else if (userInput.Contains("phishing"))
            {
                string[] phishingTips = {
                        $"{userName}, be cautious of emails with suspicious links or attachments.",
                    $"{userName}, always verify the sender before clicking on any links or attacgments.",
                    $"{userName}, Phishing attempts often instill a sense of urgency, so please be careful and never click right away!"
                };
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n[Bot]: {phishingTips[rand.Next(phishingTips.Length)]}");
                Console.ResetColor();
                return true;
            }
            
            else if (userInput.Contains("safe browsing"))
                        {
                 string[] browsingTips = {
                    $"{userName}, always keep your browser updated to patch security flaws.",
                    $"{userName}, avoid downloading files from untrusted websites at all costs.",
                    $"{userName}, use HTTPS websites whenever possible for safer browsing."
             };
                  Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n[Bot]: {browsingTips[rand.Next(browsingTips.Length)]}");
               
                Console.ResetColor();
                return true;
            }
            else if (userInput.Contains("update software"))
            {
                string[] updateTips = {
                    $"{userName}, keeping your software updated ensures you have the latest security patches.",
                    $"{userName}, outdated software can leave you vulnerable to attacks.",
                    $"{userName}, Turn on automatic updates to avoid missing important fixes."
                };
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n[Bot]: {updateTips[rand.Next(updateTips.Length)]}");
                Console.ResetColor();
                return true;
            }
            else if (userInput.Contains("two factor") || userInput.Contains("2fa"))
            {
                string[] twoFactorTips = {
                    $"{userName}, For further security, turn on two-factor authentication (2FA).",
                    $"{userName}, 2FA makes it much harder for attackers to access your accounts.",
                    $"{userName}, For  more reliable 2FA security, implement an authenticator app rather than SMS."
                };
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n[Bot]: {twoFactorTips[rand.Next(twoFactorTips.Length)]}");
                Console.ResetColor();
                return true;
            }

            return false;
        }
    }
}


