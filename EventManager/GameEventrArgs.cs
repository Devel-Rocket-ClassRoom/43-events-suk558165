using System;
using System.Collections.Generic;
using System.Text;


class GameEventArgs : EventArgs
{
    public string EventName { get; set; }

    public object Data{ get; set; }
}


