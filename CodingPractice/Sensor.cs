//using System;
//using System.Collections.Generic;
//using System.Text;

//class Sensor
//{
//    public event Action<string> Alert;

//    public void Detect(string message)
//    {
//        Console.WriteLine($"감지: {message}");
//        Alert?.Invoke(message);
//    }
//}