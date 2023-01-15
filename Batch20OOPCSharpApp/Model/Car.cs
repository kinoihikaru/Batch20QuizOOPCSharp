using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.Model
{
    internal class Car : AVehicle
    {
        private string _noPolice;
        private string _year;
        private double _price;
        private double _tax;
        private int _seat;
        private DateOnly _transactionDate;

        public Car(string noPolice, string year, double price, double tax, int seat, DateOnly transactionDate)
        {
            _noPolice = noPolice;
            _year = year;
            _price = price;
            _tax = tax;
            _seat = seat;
            _transactionDate = transactionDate;
        }

        public string NoPolice { get => _noPolice; set => _noPolice = value; }
        public override string Year { get => _year; set => _year = value; }
        public override double Price { get => _price; set => _price = value; }
        public override double Tax { get => _tax; set => _tax = value; }
        public override int Seat { get => _seat; set => _seat = value; }
        public override DateOnly TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        
    }
}
