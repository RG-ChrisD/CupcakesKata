using Cupcakes;
using FluentAssertions;

namespace CupcakeTests;

[TestFixture]
public class BundleTests
{
    [Test]
    public void BundleWithSingleCupcake()
    {
        var bundle = new Bundle(new Cupcake());
        bundle.Price.Should().Be(1M);
        bundle.Name.Should().EndWith("🧁");
    }

    [Test]
    public void BundleWithTwoCupcakes()
    {
        var cake1 = new Cupcake();
        var cake2 = new Cupcake();
        var bundle = new Bundle(cake1, cake2);
        bundle.Price.Should().Be(1.8M);
    }
}