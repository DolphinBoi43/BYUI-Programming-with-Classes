public class Product
{
    private string _name, _id; private float _price;
    public Product (string name, string id, float price, float quantity)
    {
        _name = name;
        _id = id;
        _price = price * quantity;
    }
    // Returns cost of the amount order of a product
    public float Price()
    {
        return _price;
    }
    public string Name()
    {
        return _name;
    }
    public string ID()
    {
        return _id;
    }
}