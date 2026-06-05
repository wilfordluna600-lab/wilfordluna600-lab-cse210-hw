public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = new List<Product>();
        _products = products;
        // I am going to verify clearly how to use this _products variable later
    }

    public float GetTotalCost()
    {
        float totalCost = 0;
        float shippingCost = 0;

        if (_customer.DoLiveUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

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