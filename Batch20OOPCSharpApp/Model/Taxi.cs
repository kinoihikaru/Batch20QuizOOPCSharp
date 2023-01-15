using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.Model
{
    internal class Taxi : Car 
    {
        private double _order;
        private double _orderPerKm;
        private double _total;

        public Taxi(string noPolice, string year, double price, double tax, int seat, DateOnly transactionDate, double order, double orderPerKm) : base(noPolice, year, price, tax, seat, transactionDate)
        {
            _order = order;
            _orderPerKm = orderPerKm;
            _total = _order * _orderPerKm;
        }

        public double Order { get => _order; set { _order = value; _total = _order * _orderPerKm; } }
        public double OrderPerKm { get => _orderPerKm; set { _orderPerKm = value; _total = _order * _orderPerKm; } }
        public double Total { get => _total; }


    }
}
