using System;
using System.Collections.Generic;
using System.Text;

namespace MMABooksBusinessClasses
{
    public class Product
    {
        public Product() { }

        public Product(string productcode, string description, decimal unitprice, int onhandquantity)
        {
            ProductCode = productcode;
            Description = description;
            UnitPrice = unitprice;
            OnHandQuantity = onhandquantity;
        }

        private string productCode;
        private string description;
        private decimal unitPrice;
        private int onHandQuantity;

        public string ProductCode
        {
            get { return productCode; }
            set
            {
                if (value.Length == 10)
                    productCode = value;
                else
                    throw new ArgumentOutOfRangeException("Product Code must be 10 characters long.");

            }
        }
        public string Description 
        {
            get { return description; }
            set
            {
                if (value.Length > 1 && value.Length < 50)
                    Description = value;
                else
                    throw new ArgumentOutOfRangeException("Description must be 1 to 50 characters long.");
            }
        }
        public decimal UnitPrice 
        {
            get { return unitPrice; }
            set
            {
                if (value > 0)
                    UnitPrice = value;
                else
                    new AbandonedMutexException("Unit price must be greater than 0");
            }
        }
        public int OnHandQuantity 
        {
            get { return onHandQuantity; }
            set
            {
                if (value >= 0)
                    OnHandQuantity = value;
                else
                    throw new ArgumentOutOfRangeException("Cannot have less than 0 On Hand Quantity.");
            }
        }
    }

}
