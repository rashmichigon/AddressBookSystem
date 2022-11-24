using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<Address> addresses;

        public AddressBook()
        {
            addresses = new List<Address>();
        }

        public bool add(string name, string address)
        {
            Address addr = new Address(name, address);
            Address result = find(name);
        }

        if (Result == null) 
            {
                   AddressBook.Add(addr);
                    return true;
               }
        else 
             {
                     return false;
             }
  }
}
