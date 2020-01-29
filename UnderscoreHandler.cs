using System;
using System.Collections.Generic;
using System.Text;

namespace netBot
{
    class UnderscoreHandler : ChatMessageHandler
    {
        public string Handle(string message)
        {
            if (message.Substring(0, 1) != "_")
                return null;
            
            return "UnderscoreHandler activated! :D";
        }
    }
}
