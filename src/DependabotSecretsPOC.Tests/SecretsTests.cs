using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DependabotSecretsPOC.Tests;

[TestClass]
public class SecretsTests
{
    [TestMethod]
    public void StringTest()
    {
        //arrange
        string secret = "abc123";

        //assert
        Assert.AreEqual("abc123", secret);
    }

    [TestMethod]
    public void SecretTest()
    {
        //arrange
        IConfigurationBuilder config = new ConfigurationBuilder()
           .SetBasePath(AppContext.BaseDirectory)
           .AddJsonFile("appsettings.json");
        IConfigurationRoot Configuration = config.Build();

        //assert
        Assert.AreEqual("abc123",Configuration["AppSettings:MySecret"]);
    }
}