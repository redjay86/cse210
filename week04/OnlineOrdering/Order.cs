class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public float CalculateCost()
    {
        float totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.CalculateCost();
        }

        float shippingCost;
        if (_customer.LivesInUS())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return (float)Math.Round(totalPrice + shippingCost, 2);
    }

    public string GetPackingLabel()
    {
        List<string> labels = [];
        foreach (Product product in _products)
        {
            labels.Add($"{product.GetName()}-{product.GetProductID()}    QTY({product.GetQuanity()})");
        }
        return String.Join("\n", labels);
    }

    public string GetShippingLabel()
    {
        return _customer.GetName() + "\n" + _customer.GetAddress().DisplayAddress();
    }
}