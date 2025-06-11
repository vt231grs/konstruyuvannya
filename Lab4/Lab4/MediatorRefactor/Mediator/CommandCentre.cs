using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components;

namespace Mediator
{

 
   


    public class CommandCentre : ICommandCentre
    {
        private readonly List<Aircraft> _aircrafts = new();
        private Runway _runway;

        public void RegisterAircraft(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public void RegisterRunway(Runway runway)
        {
            _runway = runway;
        }

        public void RequestLanding(Aircraft aircraft)
        {
            if (_runway == null)
            {
                Console.WriteLine("Смугу не зареєстровано.");
                return;
            }

            Console.WriteLine($"CommandCentre: отримано запит від {aircraft.Name}");
            _runway.PermitLanding(aircraft);
        }
    }
}

