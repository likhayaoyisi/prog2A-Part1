namespace CybersecurityChatbot.Helpers
{
    public static class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            string wavPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

            if (!OperatingSystem.IsWindows())
            {
                DisplayHelper.Info("[Voice greeting available on Windows only. Skipping audio playback.]");
                return;
            }

            if (!File.Exists(wavPath))
            {
                DisplayHelper.Info("[Voice greeting file not found. Place 'greeting.wav' in the output directory.]");
                return;
            }

            try
            {
                PlayWavOnWindows(wavPath);
            }
            catch (Exception ex)
            {
                DisplayHelper.Info($"[Could not play voice greeting: {ex.Message}]");
            }
        }

        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        private static void PlayWavOnWindows(string wavPath)
        {
            using var player = new System.Media.SoundPlayer(wavPath);
            player.PlaySync(); // Play and wait for completion before continuing
        }
    }
}
