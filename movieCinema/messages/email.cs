using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema.messages
{
    class email : IMessage
    {
        public void sendMessage(string message)
        {
            Console.WriteLine("email" + message);
        }
    }
}
