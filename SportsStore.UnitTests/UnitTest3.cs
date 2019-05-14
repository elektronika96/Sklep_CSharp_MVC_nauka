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
using SportsStore.WebUI.Models;
using System.Web.Mvc;
using SportsStore.WebUI.HtmlHelpers;

namespace SportsStore.UnitTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Can_Generate_Page_Links()
        {
            HtmlHelper myHelper = null;

            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage = 2,
                TotalItems = 28,
                ItemsPerPage = 10
            };
            Func<int, string> pageUrlDelegate = i => "Strona" + i;

            MvcHtmlString result = myHelper.PageLinks(pagingInfo, pageUrlDelegate);

            Assert.AreEqual(result.ToString(), @"<a href=""Strona1"">1</a>" + @"<a class=""selected""href=""Strona2"">2</a>" + @"<a href=""Strona3"">3</a>");
        }
    }
}
