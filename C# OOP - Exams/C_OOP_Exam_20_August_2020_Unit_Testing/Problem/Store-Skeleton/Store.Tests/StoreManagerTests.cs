using NUnit.Framework;
using System;
using System.Linq;

namespace Store.Tests
{
    public class StoreManagerTests
    {
        private Product product;
        private StoreManager storeManager;

        [SetUp]
        public void Setup()
        {
            this.product = new Product("TestName", 5, 2.50m);
            this.storeManager = new StoreManager();
        }

        [Test]
        public void Constructor_Test()
        {
            StoreManager currentTestManager = new StoreManager();

            Assert.IsNotNull(currentTestManager);
            Assert.That(currentTestManager.Products.Count, Is.EqualTo(0));

        }

        [Test]
        public void Count_Is_Correct()
        {
            StoreManager currentTestMangaer = new StoreManager();
            currentTestMangaer.AddProduct(product);

            Assert.That(currentTestMangaer.Count, Is.EqualTo(1));
        }

        //[Test]
        //public void Correct_Product_Set()
        //{
        //    Assert.AreEqual("TestName", product.Name);
        //    Assert.AreEqual(5, product.Quantity);
        //    Assert.AreEqual(2.50m, product.Price);
        //}

        [Test]
        public void AddProduct_Exception_Message_When_The_Product_Is_Equal_To_Null()
        {
            StoreManager currentTestManager = new StoreManager();
            currentTestManager.AddProduct(this.product);

            Assert.Throws<ArgumentNullException>(() =>
            currentTestManager.AddProduct(null));
        }

        [Test]
        public void AddProduct_Exception_Message_When_The_Product_Quantity_Is_Equal_To_Zero()
        {
            StoreManager currentTestManager = new StoreManager();

            Assert.Throws<ArgumentException>(() =>
           currentTestManager.AddProduct(new Product("Test", 0, 10)), 
           "Product count can't be equal to zero.");
        }

        [Test]
        public void AddProduct_Exception_Message_When_The_Product_Quantity_Is_Below_From_Zero()
        {
            StoreManager currentTestManager = new StoreManager();

            Assert.Throws<ArgumentException>(() =>
            currentTestManager.AddProduct(new Product("Test", -10, 10m)),
            "Product count can't be less from zero.");
        }

        [Test]
        public void BuyProduct_And_Get_Corrent_Result()
        {
            StoreManager currentTestManager = new StoreManager();
            currentTestManager.AddProduct(new Product("Coffee", 5, 1.50m));

            var currentPrice = currentTestManager.BuyProduct("Coffee", 5);

            Assert.That(currentPrice, Is.EqualTo(7.5m));
        }

        [Test]
        public void BuyProduct_Exception_Msg_When_Is_Null_Or_Not_Found()
        {
            this.storeManager = new StoreManager();
            this.storeManager.AddProduct(new Product("Coffee", 5, 1.50m));

            Assert.Throws<ArgumentNullException>(() =>
            this.storeManager.BuyProduct("Tea", 2), 
            "The product is not found in the collection");
        }

        [Test]
        public void ButProduct_Exception_Msg_When_Quantity_Is_Too_Big()
        {
            this.storeManager = new StoreManager();
            this.storeManager.AddProduct(new Product("Coffee", 5, 1.50m));

            Assert.Throws<ArgumentException>(() =>
            this.storeManager.BuyProduct("Coffee", 200),
            "Is toooo big !!!");
        }

        [Test]
        public void Return_Most_Expensive_Product_From_Collection()
        {
            this.storeManager = new StoreManager();

            this.storeManager.AddProduct(new Product("Test1", 5, 1.50m));
            this.storeManager.AddProduct(new Product("Test2", 6, 0.50m));
            this.storeManager.AddProduct(new Product("Test3", 2, 4.50m));
            this.storeManager.AddProduct(new Product("Test4", 3, 2.50m));

            Assert.That(4.50m, Is.EqualTo(this.storeManager.GetTheMostExpensiveProduct().Price));
        }
    }
}