
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using product_catalog.Controllers;
using product_catalog.Models;
using product_catalog.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace product_catalog.UnitTests
{
    [TestFixture]
    class ProductControllerTests
    {
        private ProductProviderFake productProvider;
        private ProductsController productController;


        [SetUp]
        public void SetUp()
        {
            productProvider = new ProductProviderFake();
            productController = new ProductsController(productProvider);
        }

        [Test]
        public async Task AskingForAllProductsShouldReturnANonEmptyList()
        {
            var result = await productController.GetAllProducts();
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var products = okResult.Value.Should().BeAssignableTo<IEnumerable<Product>>().Subject;
            products.Should().NotBeEmpty();

        }

        [Test]
        public async Task AskingForAnExistingProductIdShouldReturnAProduct()
        {
            var result = await productController.GetProduct(1);
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var product = okResult.Value.Should().BeAssignableTo<Product>().Subject;
            product.Should().NotBeNull();
        }

        [Test]
        public async Task AskingForAnNonExistingProductIdShouldReturnA404()
        {
            var result = await productController.GetProduct(-1);
            result.Should().BeOfType<NotFoundObjectResult>();
        }
    }
}
