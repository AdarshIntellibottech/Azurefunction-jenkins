using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionApp1;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            try
            {
                var result = Function1.Run(TestCase.CreateHttpRequest("name", " adarsh"));
                Assert.AreEqual("Hello adarsh", ((OkObjectResult)result.Result).Value); 
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
            

        }
    }
}
