using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    internal class Child
    {
        public string childName { get; set; }

        public DateTime dateBirth = DateTime.Now.AddDays(-1);

        public string Hospital { get; set; }

        public Child(string name, string hospital)
        {
            this.childName = name;
            this.Hospital = hospital;
        }

        public event EventHandler<BornEventArgs> RaiseBornEvent;

        public void Send()
        {
            OnRaiseBornEvent(new BornEventArgs("Message: "));
        }

        public void OnRaiseBornEvent(BornEventArgs e)
        {
            EventHandler<BornEventArgs> handler = RaiseBornEvent;
            if (handler != null)
            {
                e.Message += $"My child is {childName}, was borned {dateBirth:dd/MM/yyyy} in {Hospital}.";
                handler(this, e);
            }
        }
    }
}
s