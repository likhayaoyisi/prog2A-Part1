namespace CybersecurityChatbot.Helpers
{
    public static class AsciiArt
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ██████╗██╗   ██╗██████╗ ███████╗██████╗  ██████╗ ████████╗
 ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔═══██╗╚══██╔══╝
 ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██║   ██║   ██║   
 ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██║   ██║   ██║   
 ╚██████╗   ██║   ██████╔╝███████╗██║  ██║╚██████╔╝   ██║   
  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝   ╚═╝   
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
      ██████╗  ██████╗ ████████╗
      ██╔══██╗██╔═══██╗╚══██╔══╝
      ██████╔╝██║   ██║   ██║   
      ██╔══██╗██║   ██║   ██║   
      ██████╔╝╚██████╔╝   ██║   
      ╚═════╝  ╚═════╝    ╚═╝   
");
            Console.ResetColor();
        }

        public static void DisplayShield()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
          /\
         /  \
        / /\ \
       / /  \ \
      /_/ __ \_\
      |  /  \  |
      | / /\ \ |
      |/ /  \ \|
      |_/    \_|
        \    /
         \  /
          \/
");
            Console.ResetColor();
        }

        public static void DisplayDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  " + new string('═', 60));
            Console.ResetColor();
        }

        public static void DisplayThinDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  " + new string('─', 60));
            Console.ResetColor();
        }

        public static void DisplaySectionHeader(string title)
        {
            Console.WriteLine();
            DisplayDivider();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  ▶  {title.ToUpper()}");
            Console.ResetColor();
            DisplayDivider();
        }
    }
}
