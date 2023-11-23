using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using MMABooksBusinessClasses;

namespace MMABooksTests
{
    [TestFixture]
    public class CustomerTests
    {
        private Customer def;
        private Customer c;

        [SetUp]

        public void Setup()
        {
            def = new Customer();
            c = new Customer(1, "First, Last", "111 Real Place", "New York", "NY", "10001");
        }

        [Test]

        public void TestConstructor()
        {
            Assert.IsNotNull(def);
            Assert.AreEqual(null, def.Name);
            Assert.AreEqual(null, def.Address);
            Assert.AreEqual(null, def.City);
            Assert.AreEqual(null, def.State);
            Assert.AreEqual(null, def.ZipCode);

            Assert.IsNotNull(c);
            Assert.AreNotEqual(null, c.Name);
            Assert.AreNotEqual(null, c.Address);
            Assert.AreNotEqual(null, c.City);
            Assert.AreNotEqual(null, c.State);
            Assert.AreNotEqual(null, c.ZipCode);
        }

        [Test]

        public void TestNameSetter() 
        {
            c.Name = "Alpha, Beta";

            Assert.AreNotEqual("First, Last", c.Name);
            Assert.AreEqual("Alpha, Beta", c.Name);
        }

        [Test]
        public void TestSettersNameTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.Name = "12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890");
        }

        [Test]
        public void TestAddressSetter()
        {
            c.Address = "222 Fake St.";

            Assert.AreNotEqual("111 Real Place", c.Address);
            Assert.AreEqual("222 Fake St.", c.Address);
        }

        [Test]
        public void TestSetterAddressTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.Address = "123456789012345678901234567890123456789012345678901"); //51 characters
        }

        [Test]
        public void TestCitySetter()
        {
            c.City = "San Diego";

            Assert.AreNotEqual("New York", c.City);
            Assert.AreEqual("San Diego", c.City);
        }

        [Test]
        public void TestSettersCityTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.City = "123456789012345678901"); //21 characters
        }

        [Test]
        public void TestStateSetter()
        {
            c.State = "WY";

            Assert.AreNotEqual("NY", c.State);
            Assert.AreEqual("WY", c.State);
        }

        [Test]
        public void TestStateSetterNotTwo()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.State = "ABC");
            Assert.Throws<ArgumentOutOfRangeException>(() => c.State = "A");
        }

        [Test]
        public void TestZipCodeSetter()
        {
            c.ZipCode = "01110";

            Assert.AreNotEqual("10001", c.ZipCode);
            Assert.AreEqual("10001", c.ZipCode);
        }

        [Test]
        public void TestSettersZipNotFive()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.ZipCode = "123456");
            Assert.Throws<ArgumentOutOfRangeException>(() => c.ZipCode = "1234");
        }
    }
}
