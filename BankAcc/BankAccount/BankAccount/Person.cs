using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProj
{
    public class Person
    {
        private string name;
        private string email;
        private string address;
        private string phoneNumber;
        private string idnp;

        public Person(string name, string email, string address, string phoneNumber, string idnp)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.idnp = idnp;
        }
        public Person()
        {

        }

        public void showData(Person person)
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Email: {0}", email);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Phone number: {0}", phoneNumber);
            Console.WriteLine("IDNP: {0}", idnp);
        }
    }
}
