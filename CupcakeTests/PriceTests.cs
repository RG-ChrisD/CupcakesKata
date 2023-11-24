using Cupcakes;
using FluentAssertions;

namespace CupcakeTests;

[TestFixture]
public class PriceTests
{
    [Test]
    public void PlainCupcake()
    {
        new Cupcake().Price.Should().Be(1M);
    }

    [Test]
    public void PlainCookie()
    {
        new Cookie().Price.Should().Be(2M);
    }

    [Test]
    public void ChocolateCupcake()
    {
        var cookie = new Chocolate(new Cupcake());
        cookie.Price.Should().Be(1.1M);
    }
    
    [Test]
    public void ChocolateCookie()
    {
        var cookie = new Chocolate(new Cookie());
        cookie.Price.Should().Be(2.1M);
    }

    [Test]
    public void CookieWithNuts()
    {
        var cookie = new Nuts(new Cookie());
        cookie.Price.Should().Be(2.2M);
    }
}