using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;

namespace FissalBL
{
    public class RegionBL
    {
        private RegionDA objRegionDA;
        
        // constructor
        public RegionBL()
        {
            objRegionDA = new RegionDA();
        }

        public DataTable GetAllRegiones()
        {
            return objRegionDA.GetAllRegiones();
        }

    }
}
