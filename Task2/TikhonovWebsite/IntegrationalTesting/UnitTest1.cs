using System;
using Xunit;
using Moq;
using TikhonovWebsite;
using TikhonovWebsite.DBContext;
using System.Collections.Generic;
using System.Linq;
using Moq.EntityFrameworkCore;
using TikhonovWebsite.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IntegrationalTesting
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            var myDbContextMock = new Mock<ElectronicsStoreContext>();
            var cat1 = new Category("TestCategory1", "TestPath1", 1);
            var cat2 = new Category("TestCategory2", "TestPath2", 2);
            var cat3 = new Category("TestCategory3", "TestPath3", 3);
            IList<Category> categories = new List<Category>(){
                cat1,
                cat2,
                cat3
            };
            var prod1 = new Product(1, "TestPath1", "TestTitle1", "TestPrice1", "TestSpecifications1", "TestDescription1", 1);
            var prod2 = new Product(2, "TestPath2", "TestTitle2", "TestPrice2", "TestSpecifications2", "TestDescription2", 2);
            var prod3 = new Product(3, "TestPath3", "TestTitle3", "TestPrice3", "TestSpecifications3", "TestDescription3", 3);
            IList<Product> products = new List<Product>(){
                prod1,
                prod2,
                prod3
            };
            myDbContextMock.Setup(x => x.Category).ReturnsDbSet(categories);
            myDbContextMock.Setup(x => x.Product).ReturnsDbSet(products);
            var controller = new ElectronicsController(myDbContextMock.Object);
            var result = controller.Search("TestTitle1");
            Assert.NotNull(result); //проверка, на то, что результат не null

            ViewResult vr = result as ViewResult;
            var prodActual = vr.ViewData["Product"];
            Assert.Equal(new List<Product>() { prod1 }, prodActual); //проверка на то, что во viewbag.product лежит нужный элемент

            var catActual = vr.ViewData["Category"];
            Assert.Equal(new List<Category>() { cat1, cat2, cat3 }, catActual); //проверка на то, что во viewbag.category категории стоят в нужном порядке





        }
    }
}
