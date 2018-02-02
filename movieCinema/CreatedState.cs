using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    class CreatedState : IState
    {
        public IState cancelled()
        {
            throw new NotImplementedException();
        }

        public IState created()
        {
            throw new NotImplementedException();
        }

        public IState paid()
        {
            throw new NotImplementedException();
        }

        public IState reserved()
        {
            return new ReservedState();
        }
    }
}
