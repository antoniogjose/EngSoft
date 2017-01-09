using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel.Security;
using ImoEstudantePLMetroUi.CRUDImoestudante;

namespace ImoEstudantePLMetroUi.Resources
{
    public class ClasseStatic
    {
        public static UtilizadorRespostaPedido us { get; set; }
        public static Service1Client log { get; set; }
    }
}
