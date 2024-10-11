public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal TotalPrice = 0;
        
        foreach (Product product in _products)
        {
            TotalPrice += product.GetTotalPrice();
        }

        if (_customer.isInUsa())
        {
            TotalPrice += 5;
        }

        else
        {
            TotalPrice += 35;
        }

        return TotalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";
        
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()}, ID: {product.GetproductID()}";
            label += "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}, Address: {_customer.GetAddress()}";   
    }

}