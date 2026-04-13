using System;
using System.Threading;

namespace CyberChatbot
{
    class UIHelper
    {
        public void TypewriterEffect(string message, int delayMs)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
        }

        public void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string art = @"
╔════════════════════════════════════════════════════════╗
║                                                        ║
║     ██████╗██╗   ██╗██████╗ ███████╗██████╗            ║
║    ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗           ║
║    ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝           ║
║    ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗           ║
║    ╚██████╗   ██║   ██████╔╝███████╗██║  ██║           ║
║     ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝           ║
║                                                        ║
║      🔐  CYBERSECURITY AWARENESS BOT  🔐               ║
║        ""Protecting South Africa Online""               ║
║                                                        ║
╚════════════════════════════════════════════════════════╝";
            Console.WriteLine(art);
            Console.ResetColor();
        }

        public void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine("  🌍 WELCOME TO THE CYBERSECURITY AWARENESS BOT 🌍");
            Console.WriteLine("  Your guide to staying safe online in South Africa");
            Console.WriteLine(new string('=', 60));
            Console.ResetColor();
        }

        public void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] {message}");
            Console.ResetColor();
        }
    }
}