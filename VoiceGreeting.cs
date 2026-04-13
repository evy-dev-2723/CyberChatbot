using System;
using System.IO;
using System.Media;

namespace CyberChatbot
{
    class VoiceGreeting
    {
        public void PlayGreeting()
        {
            try
            {
                // Get the path to the audio file
                string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "audio", "greeting.wav");

                // Check if the file exists
                if (File.Exists(audioPath))
                {
                    // Play the voice greeting (your real voice)
                    using (SoundPlayer player = new SoundPlayer(audioPath))
                    {
                        player.PlaySync(); // Play and wait for it to finish
                    }
                    // NO success message - just silence after the greeting
                }
                // If no audio file, do nothing (silent fallback)
            }
            catch (Exception)
            {
                // If any error, just continue silently
                // The chatbot will still work with text
            }
        }
    }
}