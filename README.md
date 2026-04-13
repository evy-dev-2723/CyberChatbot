# Cybersecurity Awareness Chatbot - Part 1

![Status](https://img.shields.io/badge/status-completed-brightgreen)
![.NET Version](https://img.shields.io/badge/.NET-10.0-blue)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)

## 📋 Project Overview

This is **Part 1** of the Cybersecurity Awareness Chatbot project for the Department of Cybersecurity. The application is a console-based chatbot that educates South African citizens about online security threats including phishing scams, password safety, and safe browsing practices.

## ✅ Requirements Implemented

| # | Requirement | Status |
|---|-------------|--------|
| 1 | Voice greeting using WAV file | ✅ Complete |
| 2 | ASCII art logo/image display | ✅ Complete |
| 3 | Text-based greeting with name personalization | ✅ Complete |
| 4 | Basic response system for cybersecurity topics | ✅ Complete |
| 5 | Input validation for empty/invalid entries | ✅ Complete |
| 6 | Enhanced console UI with colors and typing effect | ✅ Complete |
| 7 | Clean code structure with multiple classes | ✅ Complete |
| 8 | GitHub version control with CI workflow | ✅ Complete |

## 🎯 Chatbot Capabilities

The chatbot can respond to the following cybersecurity topics:

| User Says | Bot Response |
|-----------|--------------|
| `password` | Strong password tips (12+ characters, numbers, symbols) |
| `phishing` | How to recognize fake emails and suspicious links |
| `scam` | Common South African scams (fake prizes, bank calls) |
| `safe browsing` | HTTPS, padlock icon, avoiding suspicious downloads |
| `2fa` | Two-Factor Authentication benefits |
| `help` | List of available topics |
| `how are you` | General greeting response |
| `purpose` | Explanation of bot's mission |
| `exit` / `quit` | Exit the program |

## 📁 Project Structure
CyberChatbot/
│
├── Program.cs # Main entry point and conversation loop
├── Chatbot.cs # Bot logic, keyword responses, random defaults
├── UIHelper.cs # Console visuals (ASCII art, colors, typing effect)
├── VoiceGreeting.cs # Audio playback for voice greeting
├── CyberChatbot.csproj # Project configuration
│
├── audio/
│ └── greeting.wav # Voice greeting audio file
│
├── .github/
│ └── workflows/
│ └── dotnet-build.yml # GitHub Actions CI pipeline
│
└── README.md # This file

## 🚀 How to Run the Application

### Prerequisites
- **Operating System:** Windows (required for System.Media audio playback)
- **.NET SDK:** Version 10.0 or later
- **Git:** For cloning the repository (optional)

### Step 1: Clone the Repository
```bash
git clone https://github.com/evy-dev-2723/CyberChatbot.git
cd CyberChatbot

dotnet build
dotnet run
[Your voice plays: "Hello! Welcome to the Cybersecurity Awareness Bot..."]

#Logo

============================================================
  🌍 WELCOME TO THE CYBERSECURITY AWARENESS BOT 🌍
============================================================

[?] What is your name? Evelyne

[Bot] Hello, Evelyne! Welcome to the Cybersecurity Bot!
[Bot] Ask me about passwords, phishing, or safe browsing!

[Evelyne]: tell me about password
[Bot]: 🔐 Use strong passwords with 12+ characters, numbers, and symbols. Never reuse passwords!

[Evelyne]: what is phishing
[Bot]: 🎣 Phishing is fake emails/links trying to steal your info. Never click suspicious links!

[Evelyne]: exit
[Bot]: Goodbye, Evelyne! Stay safe online! 🔐

🎨 Visual Features
ASCII Art Logo: Displays a cybersecurity-themed banner at startup

Colored Text:

Cyan for bot responses

Green for user input

Yellow for warnings

Red for errors

Typing Effect: Simulates natural conversation with character-by-character delay

Decorative Borders: Section dividers for improved readability

🔧 Technical Details
Voice Greeting
Uses System.Media.SoundPlayer class

Plays WAV file from audio/greeting.wav

Falls back to text greeting if audio file not found

Keyword Recognition
Uses Dictionary<string, string> for response storage

Case-insensitive matching with StringComparer.OrdinalIgnoreCase

Random default responses for unrecognized queries

Input Validation
Rejects empty or whitespace-only input

Prompts user to re-enter valid name

Handles exit commands gracefully

📹 Video Presentation
Click here to watch the Part 1 demonstration video :https://youtu.be/kpxm-0NPs0U

The video includes:

Code walkthrough (all 4 classes)

Live demonstration of the running application

Explanation of logic and flow

Voice greeting demonstration

🔗 GitHub Repository
Repository URL: https://github.com/evy-dev-2723/CyberChatbot

CI/CD Status
https://github.com/evy-dev-2723/CyberChatbot/actions/workflows/dotnet-build.yml/badge.svg

The repository includes:

Minimum 6 commits with meaningful messages

GitHub Actions CI workflow for automated builds

Proper .gitignore for Visual Studio files

👨‍💻 Author
Field	Information
Name: Evelyne Filloi
Course C#- Cybersecurity Awareness Chatbot Project
Part 1 - Basic Chatbot Interaction
Date	April 2026
📚 References
Pieterse, H. 2021. The Cyber Threat Landscape in South Africa: A 10-Year Review. The African Journal of Information and Communication, 28. doi: https://doi.org/10.23962/10539/32213


