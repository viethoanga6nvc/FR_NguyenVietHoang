using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    internal class Friend
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public bool SubscribeToEvent { get; set; }

        public Friend( string name, string phone, bool subscribe, Child child)
        {
            this.Name = name;
            this.PhoneNumber = phone;
            this.SubscribeToEvent = subscribe;
            if (subscribe)
            {
                child.RaiseBornEvent += HandleBornEvent;
            }
        }

        void HandleBornEvent(object sender,BornEventArgs e)
        {
            Console.WriteLine($"{e.Message}\n\tInvite {Name} to the hospital to visit mother and baby.");
        }
    }
}
