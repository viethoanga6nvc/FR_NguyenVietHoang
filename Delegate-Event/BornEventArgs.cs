using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    internal class BornEventArgs : EventArgs
    {
        public string Message { get; set; }

        public BornEventArgs(string message) => Message = message;
    }
}
