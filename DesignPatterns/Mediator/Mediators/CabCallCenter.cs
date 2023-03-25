using System.Collections.Generic;
using System.Linq;

namespace Mediator.Mediators
{
    public class CabCallCenter : ICabCallCenter
    {
        private readonly Dictionary<string, ICab> Cabs = new Dictionary<string, ICab>();    

        public void BookCab(IPassenger passenger)
        {
            IEnumerable<ICab> freeCabs = Cabs.Values.Where(c => c.IsFree);
            foreach (ICab cab in freeCabs)
            {
                if (cab.IsWithinReach(passenger.Location))
                {
                    cab.Assign(passenger);
                    passenger.Inform(cab);
                }
            }
        }

        public ICabCallCenter Register(ICab cab)
        {
            if (!Cabs.ContainsValue(cab)) Cabs.Add(cab.Name, cab);

            return this;
        }
    }
}
