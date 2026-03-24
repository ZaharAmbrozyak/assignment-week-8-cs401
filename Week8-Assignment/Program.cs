namespace Week8_Assignment;

class Program
{
    static void Main(string[] args)
    {
        var letter1 = new Letter("1", 0.5);
        var letter2 = new Letter("2", 0.25);

        var parcel1 = new Parcel("3", 5.0, "20x10x20");
        var parcel2 = new Parcel("4", 6.0, "30x5x40");
        
        letter1.PrintInfo();
        parcel1.PrintInfo();


        var myCargo = new CargoContainer<DeliveryItem>();
        
        myCargo.Add(letter1);
        myCargo.Add(letter2);
        myCargo.Add(parcel1);
        myCargo.Add(parcel2);
        
        Console.WriteLine("Total cost = " + myCargo.GetTotalCost() + "грн.");
    }
}