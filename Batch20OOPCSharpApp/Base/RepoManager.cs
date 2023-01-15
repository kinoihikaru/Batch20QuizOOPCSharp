using Batch20OOPCSharpApp.DataCollection;
using Batch20OOPCSharpApp.Model;
using Batch20OOPCSharpApp.Repository;
using Batch20OOPCSharpApp.Repository.Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.Base
{
    internal class RepoManager : IRepoManager
    {
        private IVehicleDataCollection _vehicles;
        private ISummaryRepo? _summary;

        public RepoManager(IVehicleDataCollection vehicles)
        {
            _vehicles = vehicles;
        }

        public ISummaryRepo Summary
        {
            get
            {
                if (_summary is null)
                    _summary = new SummaryRepo(_vehicles);
                return _summary;
            }
        }

    }
}
