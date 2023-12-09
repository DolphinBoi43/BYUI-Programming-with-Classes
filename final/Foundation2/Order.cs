public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public float FinalCost()
    {
        float total = 0.0f;
        foreach (var product in _products)
        {
            total += product.Price();
        }
        if (_customer.IsInUSA() == true)
        {
            total += 5.0f;
        }else{
            total += 35.0f;
        }
        return total;
    }

    public string PackingLabel()
    {
        string label = $"Packing Label for {_customer.Name()}:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name()} - {product.ID()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Ship To:\n{_customer.Name()}\n{_customer.Address()}";
    }
}