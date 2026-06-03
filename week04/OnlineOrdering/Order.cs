public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
        // I am going to verify clearly how to use this _products variable later
    }

    public float GetTotalCost()
    {
        return 0;
    }

    public string GetPackingLabel()
    {
        return "";
    }

    public string GetShippingLabel()
    {
        return "";
    }
}