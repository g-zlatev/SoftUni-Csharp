using NUnit.Framework;
using System.Collections.Generic;

namespace Store.Tests
{
    public class StoreManagerTests
    {
        private Product product;
        private StoreManager manager;

        [SetUp]
        public void Setup()
        {
            this.product = new Product("product", 1, 10);
            this.manager = new StoreManager();

        }

        [Test]
        public void TestConstructor()
        {
            Assert.IsTrue(this.manager != null);
            Assert.IsTrue(this.manager.Products != null);

        }

        [Test]
        public void TestCount()
        {
            this.manager.AddProduct(product);
            Assert.AreEqual(1, this.manager.Count);
        }

        [Test]
        public void TestCollection()
        {
            var collection = new List<Product>() {product};
            this.manager.AddProduct(product);

            Assert.AreEqual(collection, this.manager.Products);
        }

        [Test]
        public void TestAddArgNull()
        {
            Product newProduct = null;

            Assert.That(() => this.manager.AddProduct(newProduct), Throws.ArgumentNullException);

        }

        [Test]
        public void TestAddZeroQuantity()
        {
            var newProd = new Product("prod", 0, 10);

            Assert.That(() => this.manager.AddProduct(newProd), Throws.ArgumentException);
        }

        [Test]
        public void TestBuyNullProduct()
        {

            Assert.That(() => this.manager.BuyProduct(null, 1), Throws.ArgumentNullException);

        }

        [Test]
        public void TestBuyNotEnoughQuantity()
        {
            var newProduct = new Product("name", 10, 10);
            this.manager.AddProduct(newProduct);

            Assert.That(() => this.manager.BuyProduct("name", 20), Throws.ArgumentException);
        }

        [Test]
        public void TestBuyDecreasesQuantity()
        {
            var newProduct1 = new Product("newProduct1", 1, 10);
            var newProduct = new Product("newProduct", 10, 10);
            var anotherNewProduct = new Product("anotherNewProduct", 10, 100);

            this.manager.AddProduct(newProduct1);
            this.manager.AddProduct(newProduct);
            this.manager.AddProduct(anotherNewProduct);

            this.manager.BuyProduct("newProduct", 5);
           this.manager.BuyProduct("newProduct1", 1);

            Assert.AreEqual(5, newProduct.Quantity);
            Assert.AreEqual(0, newProduct1.Quantity);

        }

        [Test]
        public void Testprice()
        {
            var newProduct1 = new Product("newProduct1", 1, 10);
            var newProduct = new Product("newProduct", 10, 10);
            var anotherNewProduct = new Product("anotherNewProduct", 10, 100);

            this.manager.AddProduct(newProduct1);
            this.manager.AddProduct(newProduct);
            this.manager.AddProduct(anotherNewProduct);

            Assert.AreEqual(50, this.manager.BuyProduct("newProduct", 5));
        }

        [Test]
        public void TestMostExpensiceProd()
        {
            var newProduct1 = new Product("newProduct1", 1, 10);
            var newProduct2 = new Product("newProduct2", 10, 20);
            var newProduct3 = new Product("newProduct3", 10, 30);

            this.manager.AddProduct(newProduct1);
            this.manager.AddProduct(newProduct2);
            this.manager.AddProduct(newProduct3);

            var expensiveProd = this.manager.GetTheMostExpensiveProduct();

            Assert.AreEqual(newProduct3, expensiveProd);
        }

        [Test]
        public void TestOne()
        {
            Assert.Pass();
        }
    }
}