using System;
using System.Collections.Generic;
using System.Text;

class InventoryUI
{
    public void youi(string name, int oldCount, int newCount)
    {
       if (newCount == 0)
        {
            Console.WriteLine($"[자동구매] {name} 재고 소진!자동 구매 요청");
        }
    
    }
 }