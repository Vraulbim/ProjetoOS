using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMBYOS.Library.Models
{
    class Intituicao
    {
        public long codigo { get; set; }
        public string nome { get; set; }
        public Contato Contato { get; set; }
    }
}
