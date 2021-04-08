using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FissalDA;
using FissalBE;

namespace FissalBL
{
    public class TipoDocumentoBL
    {
        TipoDocumentoDA ObjTipoDocumentoDA = new TipoDocumentoDA();

        public DataTable TipoDocumento_listar()
        {
            return ObjTipoDocumentoDA.TipoDocumento_listar();
        }

        public DataTable Documento_listar()
        {
            return ObjTipoDocumentoDA.Documento_listar();
        }
    }
}
