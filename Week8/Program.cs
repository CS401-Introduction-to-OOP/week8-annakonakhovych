// See https://aka.ms/new-console-template for more information

namespace Generics;

class Program
{
    static void Main(string[] args)
    {

        Letter l1 = new Letter("1A", 0.5);
        Letter l2 = new Letter("2B", 0.3);
        Parcel p1 = new Parcel("CB", 10, "20*10*30");
        Parcel p2 = new Parcel("KM", 23.4, "40*30*50");

        l1.PrintInfo();
        p2.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem> ();
        myCargo.AddItem(l1);
        myCargo.AddItem(l2);
        myCargo.AddItem(p1);
        myCargo.AddItem(p2);
        
        Console.WriteLine($"Total sum of all your sendings is {myCargo.GetTotalCost()} uah");

        
        


    }
}
