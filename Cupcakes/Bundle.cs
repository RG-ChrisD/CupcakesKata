namespace Cupcakes;

public class Bundle : IConfection
{
    public Bundle(params IConfection[] confections)
    {
        var confectionsList = confections.ToList();

        if (!confectionsList.Any())
        {
            throw new InvalidOperationException("Don't create an empty bundle");
        }
        
        Name = FormatName(confectionsList);

        var bundleConfections = confectionsList.OfType<Bundle>().ToList();
        var unbundled = confectionsList.Except(bundleConfections);

        var discountFactor = confectionsList.Count > 1 ? 0.9M : 1M; 
        
        var confectionsPrice = discountFactor * unbundled.Sum(c => c.Price);
        var unbundledPrice = bundleConfections.Sum(c => c.Price);

        Price = confectionsPrice + unbundledPrice;
    }

    private static string FormatName(IEnumerable<IConfection> confectionsList)
    {
        return "Bundle:" + Environment.NewLine + string.Join(Environment.NewLine, confectionsList.Select(c => c.Name));
    }

    public string Name { get; }
    public decimal Price { get; }
}