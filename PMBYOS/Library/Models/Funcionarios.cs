using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMBYOS.Library.Models
{
    class Funcionarios
    {
        public long codigo { get; set; }
        public string nome { get; set; }
        public string cargo { get; set; }
        public string encarregado { get; set; }
        public Departamento Departamento { get; set; }
        public Contato Contato { get; set; }

    }
}
