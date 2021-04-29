
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMBYOS.Library.Models
{
    class Equipamento
    {
        public long codigo { get; set; }
        public string serie { get; set; }
        public string patRelacionado { get; set; }
        public string dataAquisicao { get; set; }
        public string garantia { get; set; }
        public string descricao { get; set; }
        public Grupo Grupo { get; set; }
        public Departamento Departamento { get; set; }
        public Local Local { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
