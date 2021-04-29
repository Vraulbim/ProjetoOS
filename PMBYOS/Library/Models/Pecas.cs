using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMBYOS.Library.Models
{
    class Pecas
    {
        public long codigo { get; set; }
        public string descricao { get; set; }
        public string subGrupo { get; set; }
        public int estoqueMinimo { get; set; }
        public string valor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        


        


    }
}
