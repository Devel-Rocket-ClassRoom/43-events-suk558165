using System;

class Progarm
{
    static void Main()
    {
        ScoreSystem scoreSystem = new ScoreSystem();
        AchievementSystem achievement = new AchievementSystem();
        SoundSystem soundSystem = new SoundSystem();

        EventManager.OnGameEvent += soundSystem.Sound;
        EventManager.OnGameEvent += scoreSystem.ScoreChanged;
        EventManager.OnGameEvent += achievement.Achive;

        EventManager.TriggerEvent("ScoreChanged", 100);
        EventManager.TriggerEvent("Achievement", "첫 번째 적 처치");
        EventManager.TriggerEvent("GameOver", null);

    }
}
