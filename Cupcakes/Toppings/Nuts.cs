namespace Cupcakes;

public class Nuts : ToppingBase
{
    public Nuts(IConfection inner) : base(inner, "🥜", 0.2M)
    {
    }
}