public class Product
{
    private string _name, _id; private float _price, _orderAmount;
    public Product (name, id, price, orderAmount)
    {
        _name = name;
        _id = id;
        _price = price;
        _orderAmount = orderAmount;
    }
    // Returns cost of the amount order of a product
    public float FinalPrice()
    {
        return _price * _orderAmount;
    }
}