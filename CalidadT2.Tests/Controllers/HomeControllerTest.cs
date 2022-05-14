using CalidadT2.Controllers;
using CalidadT2.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace CalidadT2.Tests.Controllers
{
    public class HomeControllerTest
    {

        [Test]
        public void Index()
        {
            var Mock = new Mock<AppBibliotecaContext>();
            
            var controller = new HomeController(Mock.Object);
            var view = controller.Index() as ViewResult;
            Assert.AreEqual("Index", view.ViewName);
        }

    }
}
