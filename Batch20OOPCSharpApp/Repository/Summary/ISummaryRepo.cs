using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.Repository
{
    internal interface ISummaryRepo
    {
        public int GetTotalVechileAll();
        public int GetTotalVechile(string Vehicle);
        public double GetTotalIncomeVechileAll();
        public double GetTotalIncomeVechile(string vehicle);

    }
}
