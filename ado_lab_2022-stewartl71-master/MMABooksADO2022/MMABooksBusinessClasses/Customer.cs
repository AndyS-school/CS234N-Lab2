using System;
using System.ComponentModel.Design;

namespace MMABooksBusinessClasses
{
    public class Customer
    {
        // there are several warnings in this file related to nullable properties and return values.
        // you can ignore them
        public Customer() { }

        public Customer(int id, string name, string address, string city, string state, string zipcode)
        {
            CustomerID = id;
            Name = name;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipcode;
        }

        //instance variables
        private int customerID;
        private string name;
        private string address;
        private string city;
        private string state;
        private string zipcode;


        public int CustomerID {
            get {  return customerID; }

            set {
                if (value > 0)
                    customerID = value;
                else
                    throw new ArgumentOutOfRangeException("Customer ID must be a possitive intager.");
            }
        }

        public string Name {
            get { return name; }
            set {
                if (value.Trim().Length > 0 && value.Trim().Length <= 100)
                    name = value;
                else throw new ArgumentOutOfRangeException("Name must be 1 to 100 characters long.");
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length <= 50)
                    address = value;
                else throw new ArgumentOutOfRangeException("Address must be 1 to 50 characters long.");
            }
        }

        public string City {
            get { return city; }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length <= 20)
                    city = value;
                else throw new ArgumentOutOfRangeException("Address must be 1 to 20 characters long.");
            }
        }

        //I did not bother rewriting the trim because the codes should have no spaces anyway
        public string State {
            get { return state; }
            set
            {
                if (value.Length != 2)
                    state = value;
                else throw new ArgumentOutOfRangeException("State Code should be 2 characters long.");
            }
        }

        public string ZipCode {
            get { return zipcode; }
            set
            {
                if (value.Length != 5)
                    zipcode = value;
                else throw new ArgumentOutOfRangeException("Zip Code should be 15 characters long.");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
