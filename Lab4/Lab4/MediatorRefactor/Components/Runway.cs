using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    using Mediator;
    using System;

    public class Runway
    {
        private readonly ICommandCentre _mediator;
        public bool IsFree { get; private set; } = true;

        public Runway(ICommandCentre mediator)
        {
            _mediator = mediator;
            _mediator.RegisterRunway(this);
        }

        public void PermitLanding(Aircraft aircraft)
        {
            if (IsFree)
            {
                Console.WriteLine($"Runway: дозволено посадку для {aircraft.Name}");
                IsFree = false;
                aircraft.Land();
                IsFree = true;
            }
            else
            {
                Console.WriteLine($"Runway: зайнята. Відмова {aircraft.Name}");
            }
        }
    }
}

