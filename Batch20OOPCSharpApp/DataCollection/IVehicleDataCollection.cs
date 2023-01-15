using Batch20OOPCSharpApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.DataCollection
{
    internal interface IVehicleDataCollection
    {
        List<AVehicle> FetchAll();
    }
}
