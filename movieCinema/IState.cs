using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    public interface IState
    {
        IState created();
        IState paid();
        IState cancelled();
        IState reserved();
    }
}
