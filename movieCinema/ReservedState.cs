using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    class ReservedState : IState
    {
        public IState cancelled()
        {
            return new CancelState();
        }

        public IState created()
        {
            throw new NotImplementedException();
        }

        public IState paid()
        {
            return new PaidState();
        }

        public IState reserved()
        {
            throw new NotImplementedException();
        }
    }
}
