namespace CybersecurityChatbot.Helpers
{
    public static class ResponseEngine
    {
        private static readonly Dictionary<string[], (string Response, string? Tip)> _responses = new()
        {
            {
                new[] { "how are you", "how do you do", "are you okay", "you good" },
                (
                    "I'm fully operational and ready to help you stay safe online! " +
                    "Cybersecurity threats never sleep, so neither does my vigilance.",
                    null
                )
            },
            {
                new[] { "purpose", "what do you do", "what can you do", "why are you here", "your role" },
                (
                    "I'm your Cybersecurity Awareness Assistant! I'm here to educate you about online safety. " +
                    "I can help you understand phishing, passwords, safe browsing, malware, and more.",
                    null
                )
            },
            {
                new[] { "what can i ask", "topics", "help", "menu", "what should i ask" },
                (
                    "You can ask me about:\n" +
                    "  Password Safety\n" +
                    "  Phishing Scams\n" +
                    "  Safe Browsing\n" +
                    "  Malware & Viruses\n" +
                    "  Two-Factor Authentication\n" +
                    "  Suspicious Emails\n" +
                    "  Social Engineering\n" +
                    "  Data Privacy\n\n" +
                    "  Just type your question naturally!",
                    null
                )
            },
            {
                new[] { "password", "passwords", "passphrase", "strong password", "weak password" },
                (
                    "Password safety is your first line of defence online.\n" +
                    "  • Use at least 12 characters — longer is always stronger.\n" +
                    "  • Mix uppercase, lowercase, numbers, and symbols.\n" +
                    "  • Never reuse the same password across multiple sites.\n" +
                    "  • Consider a passphrase like 'BlueSky!Runs42Fast' — easy to remember, hard to crack.\n" +
                    "  • Use a reputable password manager to store them securely.",
                    "Enable two-factor authentication (2FA) alongside strong passwords for maximum account security!"
                )
            },
            {
                new[] { "phishing", "phish", "fake email", "scam email", "email scam", "suspicious email" },
                (
                    "Phishing is one of the most common cyberattacks in South Africa.\n" +
                    "  • Attackers send emails pretending to be banks, SARS, or trusted companies.\n" +
                    "  • They create urgency: 'Your account will be closed!' or 'Claim your prize now!'\n" +
                    "  • They lure you to fake websites to steal your credentials.\n" +
                    "  • Always verify the sender's email address carefully.\n" +
                    "  • Never click links in unexpected emails — go directly to the website.",
                    "Hover over links before clicking to preview the real URL. If it looks suspicious, it probably is!"
                )
            },
            {
                new[] { "browsing", "safe browsing", "internet safety", "website", "https", "http" },
                (
                    "Safe browsing habits protect you from many threats:\n" +
                    "  • Always check for HTTPS (the padlock icon) before entering personal info.\n" +
                    "  • Keep your browser updated to patch security vulnerabilities.\n" +
                    "  • Avoid public Wi-Fi for banking or sensitive activities.\n" +
                    "  • Use a VPN on public networks to encrypt your traffic.\n" +
                    "  • Be cautious of pop-ups claiming your device is infected.",
                    "Install a reputable ad-blocker and anti-tracking extension to reduce your attack surface."
                )
            },
            {
                new[] { "malware", "virus", "ransomware", "trojan", "spyware", "adware", "worm" },
                (
                    "Malware is malicious software designed to damage or gain unauthorised access to your system:\n" +
                    "  • Viruses attach to legitimate files and spread when they're opened.\n" +
                    "  • Ransomware encrypts your files and demands payment.\n" +
                    "  • Spyware secretly monitors your activity and steals data.\n" +
                    "  • Trojans disguise themselves as legitimate software.\n" +
                    "  • Keep your OS and software updated to close security gaps.",
                    "Install reputable antivirus software and perform regular scans. Back up your data frequently!"
                )
            },
            {
                new[] { "two factor", "2fa", "mfa", "multi factor", "authentication", "authenticator" },
                (
                    "Two-Factor Authentication (2FA) adds a critical second layer of security:\n" +
                    "  • Even if someone has your password, they cannot access your account without the second factor.\n" +
                    "  • Options include: SMS codes, authenticator apps (Google/Microsoft Authenticator), or hardware keys.\n" +
                    "  • Authenticator apps are more secure than SMS, as SIM swapping is a real threat in South Africa.\n" +
                    "  • Enable 2FA on all important accounts: email, banking, and social media.",
                    "Google Authenticator and Microsoft Authenticator are free and easy to set up — enable 2FA today!"
                )
            },
            {
                new[] { "social engineering", "manipulation", "pretexting", "baiting", "vishing" },
                (
                    "Social engineering attacks manipulate people rather than systems:\n" +
                    "  • Attackers impersonate IT support, colleagues, or authority figures.\n" +
                    "  • They use pretexting — fabricating a scenario to extract information.\n" +
                    "  • Baiting involves leaving infected USB drives in public places.\n" +
                    "  • Vishing uses phone calls to trick you into revealing sensitive data.\n" +
                    "  • Always verify the identity of anyone requesting sensitive information.",
                    "When in doubt, hang up and call back using an official number from the company's website."
                )
            },
            {
                new[] { "privacy", "data privacy", "personal data", "gdpr", "popia", "personal information" },
                (
                    "Protecting your personal data is your right and responsibility:\n" +
                    "  • South Africa's POPIA (Protection of Personal Information Act) protects your data rights.\n" +
                    "  • Limit what personal information you share on social media.\n" +
                    "  • Review app permissions — does a flashlight app really need your contacts?\n" +
                    "  • Use private/incognito browsing for sensitive searches.\n" +
                    "  • Request data deletion from services you no longer use.",
                    "Regularly audit which apps and services have access to your personal information."
                )
            },
            {
                new[] { "vpn", "virtual private network" },
                (
                    "A VPN (Virtual Private Network) encrypts your internet connection:\n" +
                    "  • It hides your real IP address and location from websites.\n" +
                    "  • Essential when using public Wi-Fi at cafés, airports, or malls.\n" +
                    "  • Choose a reputable paid VPN — free VPNs often sell your data.\n" +
                    "  • A VPN does not make you completely anonymous; it's one layer of protection.",
                    "Look for VPNs with a strict no-logs policy and independent security audits."
                )
            },
            {
                new[] { "bye", "exit", "quit", "goodbye", "see you", "farewell" },
                (
                    "Stay safe online! Remember — cybersecurity is a habit, not a one-time action. Goodbye!",
                    null
                )
            }
        };

        public static (string Response, string? Tip, bool ShouldExit) GetResponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return (
                    "I didn't quite catch that. Could you rephrase? You can type 'help' to see what topics I cover.",
                    null,
                    false
                );
            }

            string lowerInput = input.ToLower().Trim();

            foreach (var entry in _responses)
            {
                foreach (string keyword in entry.Key)
                {
                    if (lowerInput.Contains(keyword))
                    {
                        bool isExit = new[] { "bye", "exit", "quit", "goodbye", "see you", "farewell" }.Contains(keyword);
                        return (entry.Value.Response, entry.Value.Tip, isExit);
                    }
                }
            }

            return (
                "I didn't quite understand that. Could you rephrase your question?\n" +
                "  Try asking about: passwords, phishing, safe browsing, malware, 2FA, or privacy.\n" +
                "  Type 'help' to see all available topics.",
                null,
                false
            );
        }
    }
}
