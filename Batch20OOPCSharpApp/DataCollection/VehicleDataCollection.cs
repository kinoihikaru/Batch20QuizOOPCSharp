using Batch20OOPCSharpApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.DataCollection
{
    internal class VehicleDataCollection : IVehicleDataCollection
    {
        private readonly List<AVehicle> _vehicle;

        public VehicleDataCollection()
        {
            _vehicle = new List<AVehicle>()
            {
                new SUV("D 1001 UM", "2010", 350_000_000, 3500_000, 4, new DateOnly(2023, 01, 10), 500_000, 150_000)
               ,new SUV("D 1002 UM", "2010", 350_000_000, 3500_000, 4, new DateOnly(2023, 01, 10), 500_000, 150_000)
               ,new SUV("D 1003 UM", "2015", 350_000_000, 3500_000, 5, new DateOnly(2023, 01, 12), 500_000, 150_000)
               ,new SUV("D 1004 UM", "2015", 350_000_000, 3500_000, 5, new DateOnly(2023, 01, 13), 500_000, 150_000)
               ,new Taxi("D 11 UK", "2002", 175_000_000, 1750_000, 4, new DateOnly(2023, 01, 12), 45, 4500)
               ,new Taxi("D 12 UK", "2015", 225_000_000, 2250_000, 4, new DateOnly(2023, 01, 13), 75, 4500)
               ,new Taxi("D 13 UK", "2020", 275_000_000, 2750_000, 4, new DateOnly(2023, 01, 13), 90, 4500)
               ,new PrivateJet("ID8089", "2015", 150_000_000_000, 1500_000_000, 12, new DateOnly(2023, 12, 23), 35_000_000, 15_000_000)
               ,new PrivateJet("ID8099", "2018", 175_000_000_000, 1750_000_000, 15, new DateOnly(2023, 12, 25), 55_000_000, 25_000_000)
            };
        }
        public List<AVehicle> FetchAll()
        {
            return _vehicle;
        }
    }
}
