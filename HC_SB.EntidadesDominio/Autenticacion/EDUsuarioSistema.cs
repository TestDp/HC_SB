using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_SB.EntidadesDominio.Autenticacion
{
    public class EDUsuarioSistema
    {
        public string IDUser { get; set; }

        
        public string userName { get; set; }

        
        public string nombreCompleto { get; set; }

        
        public string rol { get; set; }

        public List<EDRol> roles { get; set; }

        
    }
}
