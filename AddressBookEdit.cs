using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookEdit
    {
        public void list(Action<Address> action)
        {
            Address.ForEach(action);
        }

        public Address find(string name)
        {
            Address addr = addresses.Find((a) => a.name == name);
            return addr;
        }

    }
}
