namespace Week8_Assignment;

public abstract class DeliveryItem
{
    public string TrackingNumber
    {
        get;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Tracking number cannot be empty!");
            }

            field = value;
        }
        
    }

    public double Weight
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Weight should be positive!");
            }

            field = value;
        }
    }

    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Tracking number: {TrackingNumber}, weight - {Weight}kg");
    }
}