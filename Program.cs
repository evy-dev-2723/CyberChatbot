using System;

namespace CyberChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            UIHelper ui = new UIHelper();
            Chatbot bot = new Chatbot();
            VoiceGreeting voice = new VoiceGreeting();

            // Play voice greeting (your real voice)
            voice.PlayGreeting();

            // Small natural pause (optional - makes it feel more natural)
            System.Threading.Thread.Sleep(500);

            // Show ASCII art logo
            ui.DisplayAsciiArt();

            // Show welcome message
            ui.DisplayWelcomeMessage();

            // Ask for name
            Console.Write("\n\n[?] What is your name? ");
            string userName = Console.ReadLine();

            // Keep asking until name is entered
            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[!] Please enter your name.");
                Console.ResetColor();
                Console.Write("[?] Your name: ");
                userName = Console.ReadLine();
            }

            bot.SetUserName(userName);
            ui.TypewriterEffect($"\n[Bot] Hello, {userName}! Welcome to the Cybersecurity Bot!", 30);
            ui.TypewriterEffect("[Bot] Ask me about passwords, phishing, or safe browsing!", 30);

            // Main chat loop
            bool running = true;
            while (running)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n[{userName}]: ");
                Console.ResetColor();
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    ui.DisplayError("Please type something!");
                    continue;
                }

                if (userInput.ToLower() == "exit" || userInput.ToLower() == "quit")
                {
                    ui.TypewriterEffect($"\n[Bot] Goodbye, {userName}! Stay safe online! 🔐", 30);
                    break;
                }

                string response = bot.GetResponse(userInput);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("[Bot]: ");
                Console.ResetColor();
                ui.TypewriterEffect(response, 30);
            }
        }
    }
}