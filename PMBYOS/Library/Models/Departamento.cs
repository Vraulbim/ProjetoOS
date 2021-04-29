using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMBYOS.Library.Models
{
    class Departamento
    {
        public long codigo { get; set; }
        public string nomeDepartamento { get; set; }
        public string responsavel { get; set; }
        public Intituicao Intituicao { get; set; }

    }
}
