using Microsoft.VisualStudio.TestTools.UnitTesting;
using Irish_Woollens_co_operative_e_commerce.Controllers;
using Irish_Woollens_co_operative_e_commerce.Models;
using System.Web;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Irish_Woolen_co_operative_e_commerce_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ControllerIndexOK()
        {
            //arrange
            HomeController controller = new HomeController();

            //act
            IActionResult result = controller.Index();

            //result
            Assert.IsNotNull(result);

        }
    }
}
