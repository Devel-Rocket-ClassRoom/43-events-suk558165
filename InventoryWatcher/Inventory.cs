using System;
using System.Collections.Generic;
using System.Text;


class Inventory
{
    public event Action<string, int, int> ItemChanged;

    private Dictionary<string, int> items = new Dictionary<string, int>();

    public void AddItem(string name, int count)
    {
        int oldCount = items.ContainsKey(name) ? items[name] : 0;
        if (items.ContainsKey(name))
            items[name] += count;  
        else
            items[name] = count;
        ItemChanged?.Invoke(name, oldCount, items[name]);
    }
    public void RemoveItem(string name, int count)
    {
        int oldCount = items[name];
        if (items.ContainsKey(name))
            items[name] -= count;
        else
            items[name] = Math.Max(0, items[name] - count);
        ItemChanged?.Invoke(name, oldCount, items[name]);
    }
}