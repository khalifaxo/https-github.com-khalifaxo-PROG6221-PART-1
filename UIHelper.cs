using System;
using System.Threading;

public static class UIHelper
{
    public static void TypeText(string message, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;

        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }

        Console.WriteLine();
        Console.ResetColor();
    }

    public static void Divider()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("===============================================");
        Console.ResetColor();
    }
}