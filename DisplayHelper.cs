namespace CybersecurityChatbot.Helpers
{
    public static class DisplayHelper
    {
        public static void TypeWrite(string message, ConsoleColor color = ConsoleColor.White, int delayMs = 18)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void BotSay(string message)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  CyberBot: ");
            Console.ResetColor();
            TypeWrite(message, ConsoleColor.White, 12);
            Console.WriteLine();
        }

        public static void BotTip(string tip)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  TIP: ");
            Console.ResetColor();
            TypeWrite(tip, ConsoleColor.Green, 10);
            Console.WriteLine();
        }

        public static void BotWarn(string warning)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  WARNING: ");
            TypeWrite(warning, ConsoleColor.Red, 10);
            Console.ResetColor();
            Console.WriteLine();
        }

        public static string PromptUser(string userName)
        {
            AsciiArt.DisplayThinDivider();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"  {userName}: ");
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine() ?? string.Empty;
            Console.ResetColor();
            return input;
        }

        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"  {message}");
            Console.ResetColor();
        }
    }
}
