namespace Cupcakes;

public class ToppingBase : IConfection
{
    protected ToppingBase(IConfection inner, string emoji, decimal price)
    {
        Price = inner.Price + price;
        
        if (inner is ICake)
        {
            Name = inner.Name + " with " + emoji;
            return;
        }
        
        Name = inner.Name + " and " + emoji;
    }
    
    public string Name { get; }
    public decimal Price { get; }
}