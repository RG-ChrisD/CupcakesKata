using Cupcakes;
using FluentAssertions;

namespace CupcakeTests;

[TestFixture]
public class NameTests
{
    [Test]
    public void PlainCupcake()
    {
        new Cupcake().Name.Should().Be("🧁");
    }

    [Test]
    public void PlainCookie()
    {
        new Cookie().Name.Should().Be("🍪");
    }

    [Test]
    public void ChocolateCupcake()
    {
        var cookie = new Chocolate(new Cupcake());
        cookie.Name.Should().Be("🧁 with 🍫");
    }
    
    [Test]
    public void ChocolateCookie()
    {
        var cookie = new Chocolate(new Cookie());
        cookie.Name.Should().Be("🍪 with 🍫");
    }

    [Test]
    public void CookieWithChocolateAndNuts()
    {
        var cookie = new Nuts(new Chocolate(new Cookie()));
        cookie.Name.Should().Be("🍪 with 🍫 and 🥜");
    }

    [Test]
    public void CookieWithNutsAndChocolate()
    {
        var cookie = new Chocolate(new Nuts(new Cookie()));
        cookie.Name.Should().Be("🍪 with 🥜 and 🍫");
    }
}