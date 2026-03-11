using System;
using System.Collections.Generic;
using System.Text;

static class EventManager
{
    public static event EventHandler<GameEventArgs> OnGameEvent;

    public static void TriggerEvent(string eventName, object data = null)
    {
        GameEventArgs args = new GameEventArgs();
        args.EventName = eventName;
        args.Data = data;
        OnGameEvent?.Invoke(null, args);
    }
}
