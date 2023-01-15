using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.Model
{
    internal class PrivateJet : Plane
    {
        private double _rent;
        private double _driver;
        private double _total;

        public PrivateJet(string noRegister, string year, double price, double tax, int seat, DateOnly transactionDate, double rent, double driver) : base(noRegister, year, price, tax, seat, transactionDate)
        {
            _rent = rent;
            _driver = driver;
            _total = _rent + _driver;
        }

        public double Rent { get => _rent; set { _rent = value; _total = _rent * _driver; } }
        public double Driver { get => _driver; set { _driver = value; _total = _rent * _driver; } }
        public double Total { get => _total; }

    }
}
