using System;
using System.Media;

public static class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("Assets/greeting.wav");
            player.PlaySync();
        }
        catch (Exception)
        {
            Console.WriteLine("⚠️ Could not play audio.");
        }
    }
}