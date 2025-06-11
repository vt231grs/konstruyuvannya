using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mediator
{
    using Components;


    public interface ICommandCentre
    {
        void RegisterAircraft(Aircraft aircraft);
        void RegisterRunway(Runway runway);
        void RequestLanding(Aircraft aircraft);
    }
}
