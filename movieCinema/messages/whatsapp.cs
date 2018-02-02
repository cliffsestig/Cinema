using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema.messages
{
    class whatsapp : IMessage
    {
        public void sendMessage(string message)
        {
            Console.WriteLine("whatsapp" + message);
        }
    }
}
