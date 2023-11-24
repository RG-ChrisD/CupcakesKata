namespace Cupcakes;

public class Chocolate : ToppingBase
{
    public Chocolate(IConfection inner) : base(inner, "🍫", 0.1M)
    {
    }
}