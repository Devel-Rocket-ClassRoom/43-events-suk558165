using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();
        InventoryUI Ui = new InventoryUI();
        AutoBuyer autoBuyer = new AutoBuyer();

        inventory.ItemChanged += autoBuyer.Auto;
        inventory.ItemChanged += Ui.youi;

        inventory.AddItem("포션", 5);
        inventory.AddItem("화살", 10);
        inventory.AddItem("포션", 3);
        inventory.RemoveItem("화살", 7);
        inventory.RemoveItem("화살", 3);

    }

 }



