using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMBYOS.Library.db
{
    interface Connection
    {
        public DbConnection conexao();
    }
}
