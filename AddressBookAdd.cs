using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookAdd
    {
        public bool add(string name, string address)
        {
            Address addr = new Address(name, address);
            Address result = find(name);

            if (result == null)
            {
                addresses.Add(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    }
