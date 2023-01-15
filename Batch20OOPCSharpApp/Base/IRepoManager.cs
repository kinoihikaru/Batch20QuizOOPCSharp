using Batch20OOPCSharpApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.Base
{
    internal interface IRepoManager
    {
        public ISummaryRepo Summary { get; }
    }
}
