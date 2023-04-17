using static UML_to_Code.Address;
using System.Xml.Linq;
using System;

namespace UML_to_Code
{
    public abstract class Person
    {
        public int ID;
        public string Name;
        protected string Phone;
        public string Email;
        public Address Address;

        public abstract void Persona();
    }
    public class Address
    {
        public string Street;
        public string City;
        public string State;
        public int PostalCode;
        public string Country;

        public bool Validate()
        {
            return true;
        }
        public class Customer : Person
        {
            public DateTime Registration;
            private int CreditScore;
            public List<Account> Accounts;

            public override void Persona()
            {
                Console.WriteLine("");
                return;
            }
        }
        public class Employee : Person
        {
            public enum Departament { }
            private float Salary;

            public override void Persona()
            {
                Console.WriteLine("");
                return;
            }
        }
        public class Account
        {
            public string IBAN;
            protected float Amount;

            public Customer Customer;
            public List<Transaction> Transactions;
            public bool Transaction(string transactions)
            {
                return true;
            }


        }
        public class Transaction
        {

            public string From;
            public string To;
            public float Amount;
            public DateTime Request;
        }
    }
}



