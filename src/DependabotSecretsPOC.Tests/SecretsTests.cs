using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DependabotSecretsPOC.Tests;

[TestClass]
public class SecretsTests
{
    [TestMethod]
    public void SecretTest()
    {
        //arrange
        string secret = "abc123";

        //assert
        Assert.AreEqual("abc123", secret);
    }
}