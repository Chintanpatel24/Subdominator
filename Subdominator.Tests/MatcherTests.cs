namespace Subdominator.Tests;

[TestClass]
public class MatcherTests
{
    [TestMethod]
    public void FingerprintMatchingShouldBeCaseInsensitiveAndNormalizeDnsValues()
    {
        Assert.IsTrue(Subdominator.SubdomainHijack.MatchesFingerprintValue("Foo.Example.COM.", "example.com"));
        Assert.IsTrue(Subdominator.SubdomainHijack.MatchesFingerprintValue("151.101.12.34", "151.101."));
        Assert.IsFalse(Subdominator.SubdomainHijack.MatchesFingerprintValue("foo.example.com", "bar.example.com"));
    }

    [TestMethod]
    public void FingerprintBodyMatchingShouldIgnoreCase()
    {
        Assert.IsTrue(Subdominator.SubdomainHijack.ContainsFingerprintText("You Have Found A Missing Link", "missing link"));
        Assert.IsFalse(Subdominator.SubdomainHijack.ContainsFingerprintText("No matching string here", "missing link"));
    }
}
