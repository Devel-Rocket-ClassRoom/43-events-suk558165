//using System;
//using System.Collections.Generic;
//using System.Text;

//class Player
//{
//    public event Action<int> DamageTaken;

//    private int _health = 100;

//    public void TakeDamage(int damage)
//    {
//        _health -= damage;
//        Console.WriteLine($"플레이어 체력: {_health}");
//        DamageTaken?.Invoke(_health);
//    }
//}
//class HealthBar
//{
//    public void OnPlayerDamaged(int currentHealth)
//    {
//        Console.WriteLine($"[UI] 체력바 업데이트: {currentHealth}%");
//    }
//}
//class SoundManager
//{
//    public void OnPlayerDamaged(int currentHealth)
//    {
//        Console.WriteLine("[Sound 피격 효과음 재생");
//    }
//}