using System;
using System.Collections.Generic;
using System.Text;


class AchievementSystem
{
    public void Achive (object sender, GameEventArgs e)
    {
        if (e.EventName == "Achievement")
        {
            Console.WriteLine($"업적 달성: {e.Data}");
        }
    }
}