using System;
using System.Net.Http;
using System.Xml.Serialization;


//## 1. 대리자 복습
//class Progarm
//{
//    static void Main()
//    {
//        Notify notify = SayHello;
//        notify += SayGoodbye;

//        notify();
//    }
//    static void SayHello()
//    {
//        Console.WriteLine("안녕하세요!");
//    }
//    static void SayGoodbye()
//    {
//        Console.WriteLine("안녕하세요!");
//    }  
//}

//## 2. 기본 이벤트 선언
//class Program
//{ 
//  static void Main()
//    {
//        Button button = new Button();

//        button.Click += HandleClick;
//        button.Click += HandleClickAgain;

//        button.OnClick();
//    }
//    static void HandleClick()
//    {
//        Console.WriteLine("버튼이 클릭되었습니다!");
//    }
//    static void HandleClickAgain()
//    {
//        Console.WriteLine("클릭 처리 완료");
//    }

//}

//## 3. 이벤트 구독
//class Progarm
//{
//    static void Main()
//    {
//        Player player = new Player();
//        HealthBar healthBar = new HealthBar();
//        SoundManager soundManager = new SoundManager();

//        player.DamageTaken += healthBar.OnPlayerDamaged;
//        player.DamageTaken += soundManager.OnPlayerDamaged;

//        player.TakeDamage(30);
//    }
//}

//## 4. 이벤트 해제
//class Peogarm
//{
//    static void Main()
//    {
//        Timer timer = new Timer();
//        Logger logger = new Logger();

//        timer.Tick += logger.OnTick;

//        Console.WriteLine("=== 구독 상태 ===");
//        timer.Start();


//        timer.Tick -= logger.OnTick;

//        Console.WriteLine("\n=== 구독 해제 후 ===");
//        timer.Start();
//    }
//}

//## 5. 람다식 이벤트 핸들러
//class Progarm
//{
//    static void Main()
//    {
//        Sensor sensor = new Sensor();

//        sensor.Alert += message =>
//        {
//            Console.WriteLine($"[경보] {message}");
//        };

//        sensor.Alert += message =>
//            {
//                Console.WriteLine($"[로그] {DateTime.Now}: {message}");
//            };
//        sensor.Detect("움직임 감지됨");
//        sensor.Detect("온도 상승");
//    }
//}

//## 6. Action 대리자 활용
//class Program
//{
//    static void Main()
//    {
//        GameCharacter hero = new GameCharacter("용사");

//        // Action (매개변수 없음)
//        hero.OnDeath += () => Console.WriteLine("캐릭터가 사망했습니다");

//        // Action<int> (매개변수 1개)
//        hero.OnDamaged += health => Console.WriteLine($"남은 체력: {health}");

//        // Action<int, string> (매개변수 2개)
//        hero.OnAttack += (damage, target) =>
//            Console.WriteLine($"{target}에게 {damage} 데미지!");

//        hero.Attack(50, "슬라임");
//        hero.TakeDamage(30);
//        hero.TakeDamage(80);
//    }
//}

//## 7. 표준 이벤트 패턴 (EventArgs)
//class Program
//{
//    static void Main()
//    {
//        Stock msStock = new Stock("MSFT", 100.00m);

//        // 표준 패턴: sender와 EventArgs를 받음
//        msStock.PriceChanged += (sender, e) =>
//        {
//            Stock stock = (Stock)sender;
//            Console.WriteLine($"[{stock}]");
//            Console.WriteLine($"  이전 가격: {e.OldPrice:C}");
//            Console.WriteLine($"  현재 가격: {e.NewPrice:C}");
//            Console.WriteLine($"  변동률: {e.ChangePercent:F2}%");
//            Console.WriteLine();
//        };

//        msStock.Price = 110.00m;
//        msStock.Price = 105.50m;
//        msStock.Price = 120.00m;
//    }
//}

//## 8. 실전 예제 - 연료 경고 시스템
//class Program
//{
//    static void Main()
//    {
//        Car car = new Car(50);
//        Dashboard dashboard = new Dashboard();

//        // 구독
//        dashboard.Subscribe(car);

//        // 운전 시뮬레이션
//        for (int i = 0; i < 7; i++)
//        {
//            car.Drive();
//            Console.WriteLine();
//        }

//        // 구독 해제
//        dashboard.Unsubscribe(car);
//    }
//}
//## 9. 이벤트 접근자
//class Program
//{
//    static void Main()
//    {
//        SecurePublisher publisher = new SecurePublisher();

//        publisher.MyEvent += Handler1;
//        publisher.MyEvent += Handler2;

//        Console.WriteLine("\n이벤트 발생:");
//        publisher.RaiseEvent();

//        Console.WriteLine();
//        publisher.MyEvent -= Handler1;

//        Console.WriteLine("\n이벤트 발생:");
//        publisher.RaiseEvent();
//    }

//    static void Handler1(object sender, EventArgs e)
//    {
//        Console.WriteLine("Handler1 실행됨");
//    }

//    static void Handler2(object sender, EventArgs e)
//    {
//        Console.WriteLine("Handler2 실행됨");
//    }
//}


//## 10. static 이벤트
class GlobalNotifier
{
    public static event Action<string> OnGlobalMessage;

    public static void SendMessage(string message)
    {
        Console.WriteLine($"[Global] 메시지 전송: {message}");
        OnGlobalMessage?.Invoke(message);
    }
}

class Module1
{
    public Module1()
    {
        GlobalNotifier.OnGlobalMessage += HandleMessage;
    }

    private void HandleMessage(string message)
    {
        Console.WriteLine($"[Module1] 수신: {message}");
    }
}

class Module2
{
    public Module2()
    {
        GlobalNotifier.OnGlobalMessage += HandleMessage;
    }

    private void HandleMessage(string message)
    {
        Console.WriteLine($"[Module2] 수신: {message}");
    }
}

class Program
{
    static void Main()
    {
        Module1 m1 = new Module1();
        Module2 m2 = new Module2();

        GlobalNotifier.SendMessage("시스템 시작");
        Console.WriteLine();
        GlobalNotifier.SendMessage("데이터 로드 완료");
    }
}

//delegate void Notify();
//delegate void EventHandler();
