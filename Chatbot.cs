using System;
using System.Collections.Generic;

namespace CyberChatbot
{
    class Chatbot
    {
        private string userName;
        private Dictionary<string, string> responses;

        public Chatbot()
        {
            responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "how are you", "I'm functioning perfectly! Ready to help you learn about cybersecurity." },
                { "purpose", "I teach South Africans about online safety, phishing, and password security." },
                { "help", "Ask me about: passwords, phishing, safe browsing, scams, or 2FA." },
                { "password", "🔐 Use strong passwords with 12+ characters, numbers, and symbols. Never reuse passwords!" },
                { "phishing", "🎣 Phishing is fake emails/links trying to steal your info. Never click suspicious links!" },
                { "scam", "⚠️ Common scams: fake prizes, fake bank calls, WhatsApp lottery. Never share OTPs!" },
                { "safe browsing", "🌐 Look for 'https://' and the padlock icon. Avoid suspicious downloads." },
                { "2fa", "Two-Factor Authentication adds extra security. Always enable it when available!" }
            };
        }

        public void SetUserName(string name)
        {
            userName = name;
        }

        public string GetResponse(string userInput)
        {
            string input = userInput.ToLower();

            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    return responses[keyword];
                }
            }

            string[] defaultResponses = {
                "I didn't understand. Ask me about passwords or phishing!",
                "Can you rephrase? Try asking about cybersecurity tips.",
                "I'm still learning! Ask me about safe browsing or passwords."
            };
            Random rand = new Random();
            return defaultResponses[rand.Next(defaultResponses.Length)];
        }
    }
}