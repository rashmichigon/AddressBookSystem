using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Address
    {
        public string name;
        public string address;
        public int phone_no;
        public string city;
        public string state;
        public string zipcode;
        public string email_id;

        public Address(string name, string address)
        {
            this.name = name;
            this.address = address;
            this.phone_no = phone_no;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.email_id = email_id;

        }




    }
}
