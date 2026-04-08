# prog2A-Part1
# Cybersecurity Awareness Chatbot — prog2A-Part 1

A C# console application that serves as a basic cybersecurity awareness chatbot for South African citizens.

## Features

- 🔊 **Voice Greeting** — Plays a WAV welcome message on startup (Windows only)
- 🎨 **ASCII Art Logo** — Displays a cybersecurity-themed banner at launch
- 💬 **Personalised Interaction** — Asks for the user's name and addresses them throughout
- 🛡️ **Cybersecurity Responses** — Covers password safety, phishing, safe browsing, malware, 2FA, VPNs, social engineering, and data privacy
- ✅ **Input Validation** — Handles empty inputs and unrecognised queries gracefully
- 🎨 **Enhanced Console UI** — Coloured text, typing effects, dividers, section headers, and emoji icons
- 📁 **Well-Structured Code** — Separated into classes and helpers; no monolithic Program.cs

## Project Structure

```
CybersecurityChatbot/
├── Program.cs                  # Entry point and main conversation loop
├── CybersecurityChatbot.csproj
├── Models/
│   └── ChatUser.cs             # User model with automatic properties
├── Helpers/
│   ├── AsciiArt.cs             # ASCII logo, shield, and dividers
│   ├── DisplayHelper.cs        # Typed output, coloured text, user prompts
│   ├── VoiceGreeting.cs        # WAV file playback (Windows)
│   └── ResponseEngine.cs       # Keyword-matching response engine
├── greeting.wav                # Voice greeting audio file (add your own)
└── .github/
    └── workflows/
        └── dotnet.yml          # GitHub Actions CI workflow
```

## How to Run

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Steps

1. Clone the repository:
   ```bash
   git clone <your-repo-url>
   cd CybersecurityChatbot
   ```

2. Add your voice greeting:
   - Record a short WAV file with the message: *"Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online."*
   - Name the file `greeting.wav` and place it in the project root.
   - The build is configured to copy it to the output directory automatically.

3. Build and run:
   ```bash
   dotnet build
   dotnet run
   ```

## Voice Greeting Setup

The voice greeting uses `System.Media.SoundPlayer` which is **Windows-only**.

- Record your greeting using Windows Voice Recorder or any audio software.
- Export/save as **WAV format**.
- Place `greeting.wav` in the project root folder.
- On non-Windows systems, the chatbot will display a message and skip audio playback.

## Topics the Bot Covers

| Topic | Keywords to Try |
|---|---|
| Password Safety | "password", "strong password", "passphrase" |
| Phishing | "phishing", "fake email", "scam email" |
| Safe Browsing | "safe browsing", "https", "website" |
| Malware | "malware", "virus", "ransomware" |
| Two-Factor Auth | "2FA", "two factor", "authenticator" |
| Social Engineering | "social engineering", "vishing", "pretexting" |
| VPN | "vpn", "virtual private network" |
| Data Privacy | "privacy", "popia", "personal data" |

## CI Workflow

GitHub Actions is configured to automatically build and verify the project on every push and pull request.

### CI Screenshot
<!-- Add screenshot of successful GitHub Actions run here -->
![CI Build Status](ci-screenshot.png)

## Commit History

Meaningful commits following the project requirements:
1. `Initial commit: Set up project structure and main files`
2. `Added ASCII art logo and shield display`
3. `Implemented voice greeting with WAV playback`
4. `Added personalised user interaction and name validation`
5. `Implemented cybersecurity response engine with keyword matching`
6. `Added enhanced console UI with colours, typing effect, and session summary`

## References

Pieterse, H. 2021. *The Cyber Threat Landscape in South Africa: A 10-Year Review*. The African Journal of Information and Communication, 28(28). doi: https://doi.org/10.23962/10539/32213
