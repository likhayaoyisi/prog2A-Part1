using System;
using System.Speech.Synthesis;

namespace VoiceGreetingApp
{
    class VoiceGreeting
    {
        static void Main(string[] args)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak("Hello! Welcome to our application. We are glad to have you here.");
            }
        }
    }
}