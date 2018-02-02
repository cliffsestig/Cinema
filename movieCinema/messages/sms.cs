using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema.messages
{
    class Sms : IMessage
    {
        public void sendMessage(string message)
        {
            Console.WriteLine("sms" + message);
        }
    }
}
