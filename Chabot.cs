using System;

public class ChatBot
{
    private string userName;

    public void Start()
    {
        ShowHeader();
        AudioPlayer.PlayGreeting();

        AskName();
        MainChat();
    }

    private void ShowHeader()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"
   ██████╗ ██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝ ╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
  ██║       ╚████╔╝ ██████╔╝█████╗  ██████╔╝
  ██║        ╚██╔╝  ██╔═══╝ ██╔══╝  ██╔══██╗
  ╚██████╗    ██║   ██║     ███████╗██║  ██║
   ╚═════╝    ╚═╝   ╚═╝     ╚══════╝╚═╝  ╚═╝

     CYBERSECURITY AWARENESS BOT
        ");

        Console.ResetColor();
        UIHelper.Divider();
    }

    private void AskName()
    {
        UIHelper.TypeText("🤖 What is your name?", ConsoleColor.Yellow);
        userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            UIHelper.TypeText("⚠️ Please enter a valid name:", ConsoleColor.Red);
            userName = Console.ReadLine();
        }

        UIHelper.TypeText($"👋 Welcome, {userName}! Stay safe online.", ConsoleColor.Cyan);
        UIHelper.Divider();
    }

    private void MainChat()
    {
        while (true)
        {
            UIHelper.TypeText("Ask me something (or type 'exit'):", ConsoleColor.White);
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                UIHelper.TypeText("⚠️ Input cannot be empty.", ConsoleColor.Red);
                continue;
            }

            if (input == "exit")
            {
                UIHelper.TypeText("👋 Goodbye! Stay cyber safe!", ConsoleColor.Green);
                break;
            }

            Respond(input);
        }
    }

    private void Respond(string input)
    {
        if (input.Contains("how are you"))
        {
            UIHelper.TypeText("😊 I'm good thanks, but I'm here to help you!", ConsoleColor.Cyan);
        }
        else if (input.Contains("purpose"))
        {
            UIHelper.TypeText("🎯 My purpose is to educate you about cybersecurity.", ConsoleColor.Cyan);
        }
        else if (input.Contains("password"))
        {
            UIHelper.TypeText("🔐 Use strong passwords with symbols, numbers, and never share them.", ConsoleColor.Magenta);
        }
        else if (input.Contains("phishing"))
        {
            UIHelper.TypeText("🎣 Be careful of suspicious emails asking for personal info.", ConsoleColor.Magenta);
        }
        else if (input.Contains("safe browsing"))
        {
            UIHelper.TypeText("🌐 Always check for HTTPS and avoid unknown links.", ConsoleColor.Magenta);
        }
        else if (input.Contains("what can i ask"))
        {
            UIHelper.TypeText("💬 Ask about passwords, phishing, or safe browsing.", ConsoleColor.Cyan);
        }
        else
        {
            UIHelper.TypeText("❓ I didn't understand that. Try asking about cybersecurity topics.", ConsoleColor.Red);
        }
    }
}