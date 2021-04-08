using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalWinForm
{
    public interface IFrmSelectorControlesMedicos
    {
        void ObtenerControlesMedicos(string codigoControlMedico, string fechaInicioControlMedico, string fechaFinControlMedico);
    }
}
