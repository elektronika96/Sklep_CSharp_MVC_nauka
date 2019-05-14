using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
using SportsStore.WebUI.Controllers;
using SportsStore.WebUI.Infrastructure;
using SportsStore.Domain.Entities;
using System.Linq;

namespace SportsStore.UnitTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
            new Product{ProductID=1,Name="P1" },
            new Product{ProductID=2,Name="P2" },
            new Product{ProductID=3,Name="P3" },
            new Product{ProductID=4,Name="P4" },
            new Product{ProductID=5,Name="P5" }
            }.AsQueryable());

            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            IEnumerable<Product> result = (IEnumerable<Product>)controller.List(null,2).Model;

            Product[] prod = result.ToArray();
            Assert.IsTrue(prod.Length == 2);
            Assert.AreEqual(prod[0].Name, "P4");
            Assert.AreEqual(prod[1].Name, "P5");
        }
    }
}
