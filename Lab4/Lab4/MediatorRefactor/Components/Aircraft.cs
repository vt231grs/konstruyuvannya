using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    using Mediator;
    using System;

    public class Aircraft
    {
        private readonly ICommandCentre _mediator;
        public string Name { get; }

        public Aircraft(ICommandCentre mediator, string name)
        {
            _mediator = mediator;
            Name = name;
            _mediator.RegisterAircraft(this);
        }

        public void RequestLanding()
        {
            Console.WriteLine($"{Name} просить дозвіл на посадку.");
            _mediator.RequestLanding(this);
        }

        public void Land()
        {
            Console.WriteLine($"{Name} здійснює посадку.");
        }
    }
}

