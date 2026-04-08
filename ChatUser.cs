namespace CybersecurityChatbot.Models
{
    public class ChatUser
    {
        public string Name { get; set; } = string.Empty;
        public DateTime SessionStart { get; set; }
        public int MessageCount { get; set; }

        public ChatUser(string name)
        {
            Name = name;
            SessionStart = DateTime.Now;
            MessageCount = 0;
        }

        public string GetGreeting()
        {
            return $"Hello, {Name}! Welcome to the Cybersecurity Awareness Bot.";
        }

        public void IncrementMessageCount()
        {
            MessageCount++;
        }
    }
}
