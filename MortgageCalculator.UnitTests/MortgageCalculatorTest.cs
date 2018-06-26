namespace MortgageCalculator.UnitTests
{
    using MortgageCalculator.Api.Services;
    using NUnit.Framework;
    [TestFixture]
    public class MortgageCalculatorTest
    {
        [Test]
        public void TestGetMortage()
        {            
            MortgageService Mc = new MortgageService();
            var results=Mc.GetAllMortgages();
        }
    }
}
