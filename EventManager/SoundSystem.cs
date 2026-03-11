using System;
using System.Collections.Generic;
using System.Text;

class SoundSystem
{
    public void Sound(object sender, GameEventArgs e)
    {
        Console.WriteLine($"[Sound] 이벤트: {e.EventName}");
    }
}