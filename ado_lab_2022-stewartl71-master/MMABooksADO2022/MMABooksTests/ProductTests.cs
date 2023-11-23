using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using MMABooksBusinessClasses;

namespace MMABooksTests
{
    [TestFixture]
    public class ProductTests
    {
        private Product def;
        private Product c;

        [SetUp]

        public void Setup()
        {
            def = new Product();
            c = new Product("1234567890", "Description", 1.00m, 1);
        }

        [Test]
        public void TestConstructor() 
        {
            Assert.IsNotNull(def);
            Assert.AreEqual(null, def.ProductCode);
            Assert.AreEqual(null, def.Description);
            Assert.AreEqual(null, def.UnitPrice);
            Assert.AreEqual(null, def.OnHandQuantity);

            Assert.IsNotNull(c);
            Assert.AreNotEqual(null, c.ProductCode);
            Assert.AreNotEqual(null, c.Description);
            Assert.AreNotEqual(null, c.UnitPrice);
            Assert.AreNotEqual(null, c.OnHandQuantity);
        }

        [Test]
        public void TestCodeSetter()
        {
            c.ProductCode = "0123456789";

            Assert.AreNotEqual("1234567890", c.ProductCode);
            Assert.AreEqual("0123456789", c.ProductCode);
        }

        [Test]
        public void TestSettersCodeTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.ProductCode = "12345678901");
        }

        [Test]
        public void TestDesctriptionSetter()
        {
            c.Description = "uuuh";

            Assert.AreNotEqual("Description", c.Description);
            Assert.AreEqual("uuuh", c.Description);
        }

        [Test]
        public void TestUnitPriceSetter()
        {
            c.UnitPrice = 2.00m;

            Assert.AreNotEqual(1.00m, c.UnitPrice);
            Assert.AreEqual(2.00m, c.UnitPrice);
        }

        [Test]
        public void TestOnHandQuantitySetter()
        {
            c.OnHandQuantity = 2;

            Assert.AreNotEqual(1, c.OnHandQuantity);
            Assert.AreEqual(2, c.OnHandQuantity);
        }
    }
}
