using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProj
{
    public class Person
    {
        public string Name {get;set;}
        public string Email { get;set;}
        public string Address { get;set;}
        public string PhoneNumber { get;set;}
        public string PersonalCode { get; set; }

        public Person(string name, string email, string address, string phoneNumber, string personalCode)
        {
            Name = name;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            PersonalCode = personalCode;
        }
        public Person()
        {

        }

        public void showData(Person person)
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Phone number: {0}", PhoneNumber);
            Console.WriteLine("IDNP: {0}", PersonalCode);
        }
    }
}
