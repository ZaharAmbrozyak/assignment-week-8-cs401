namespace Week8_Assignment;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _itemList = [];

    public void Add(T item)
    {
        _itemList.Add(item);
    }

    public double GetTotalCost()
    {
        var totalCost = 0.0;
        foreach (var item in _itemList)
        {
            totalCost += item.CalculateCost();
        }

        return totalCost;
    }
}