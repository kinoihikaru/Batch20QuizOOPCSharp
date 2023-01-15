using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.Model
{
    internal abstract class AVehicle
    {
        public abstract string Year { get; set; }
        public abstract double Price { get; set; }
        public abstract double Tax { get; set; }
        public abstract int Seat { get; set; }
        public abstract DateOnly TransactionDate { get; set; }
    }
}
