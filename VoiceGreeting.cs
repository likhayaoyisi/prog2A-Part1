namespace CybersecurityChatbot.Helpers
{
    public static class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            if (!OperatingSystem.IsWindows())
            {
                DisplayHelper.Info("[Voice greeting available on Windows only. Skipping audio playback.]");
                return;
            }

            try
            {
                PlayTextToSpeechGreeting();
            }
            catch (Exception ex)
            {
                DisplayHelper.Info($"[Could not play voice greeting: {ex.Message}]");
            }
        }

        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        private static void PlayTextToSpeechGreeting()
        {
            using var synthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
            synthesizer.Rate = -1;
            synthesizer.Speak("Welcome to the Cybersecurity Awareness Bot. I'm CyberBot, your personal cybersecurity assistant. I'm here to help you stay safe in the digital world.");
        }
    }
}