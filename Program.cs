using CybersecurityChatbot.Helpers;
using CybersecurityChatbot.Models;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            VoiceGreeting.PlayGreeting();

            Console.Clear();
            AsciiArt.DisplayLogo();
            AsciiArt.DisplayShield();

            AsciiArt.DisplayDivider();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   CYBERSECURITY AWARENESS BOT  |  Powered by IIE CyberGuard 2026");
            Console.ResetColor();
            AsciiArt.DisplayDivider();

            Thread.Sleep(500);

            DisplayHelper.TypeWrite(
                "  Welcome! I'm CyberBot, your personal cybersecurity awareness assistant.",
                ConsoleColor.White,
                15
            );
            DisplayHelper.TypeWrite(
                "  I'm here to help you stay safe in the digital world.",
                ConsoleColor.White,
                15
            );

            Console.WriteLine();
            Thread.Sleep(400);

            AsciiArt.DisplaySectionHeader("Let's get started");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  What is your name? ");
            Console.ForegroundColor = ConsoleColor.White;
            string? rawName = Console.ReadLine();
            Console.ResetColor();

            while (string.IsNullOrWhiteSpace(rawName))
            {
                DisplayHelper.BotSay("I didn't catch your name. Please enter your name to continue:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  Your name: ");
                rawName = Console.ReadLine();
                Console.ResetColor();
            }

            string userName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(rawName.Trim().ToLower());

            var user = new ChatUser(userName);

            AsciiArt.DisplaySectionHeader($"Welcome, {userName}!");
            DisplayHelper.BotSay(user.GetGreeting());
            DisplayHelper.BotSay(
                "I can help you learn about cybersecurity topics like phishing, passwords, " +
                "safe browsing, malware, and much more."
            );
            DisplayHelper.BotTip("Type 'help' at any time to see all topics I can assist you with.");
            DisplayHelper.BotSay("Type 'bye' or 'exit' when you're ready to leave.");

            AsciiArt.DisplaySectionHeader("Chat Session");

            bool isRunning = true;

            while (isRunning)
            {
                string userInput = DisplayHelper.PromptUser(userName);
                user.IncrementMessageCount();

                var (response, tip, shouldExit) = ResponseEngine.GetResponse(userInput);

                DisplayHelper.BotSay(response);

                if (tip != null)
                {
                    DisplayHelper.BotTip(tip);
                }

                if (shouldExit)
                {
                    isRunning = false;
                }
            }

            AsciiArt.DisplayDivider();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"  Session ended for {user.Name}.");
            Console.WriteLine($"  Messages exchanged: {user.MessageCount}");
            Console.WriteLine($"  Session duration: {(DateTime.Now - user.SessionStart).Minutes} minute(s).");
            Console.ResetColor();
            AsciiArt.DisplayDivider();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n  Remember: Stay vigilant. Stay secure.\n");
            Console.ResetColor();

            Console.WriteLine("  Press any key to close...");
            Console.ReadKey();
        }
    }
}
