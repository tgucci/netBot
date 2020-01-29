using System;
using System.Collections.Generic;
using System.Text;

namespace netBot
{
    interface IChatMessageHandler
    {
        public string Handle(string message);
    }
}
