using System;
using System.Collections.Generic;
using System.Text;

namespace plants.BL.Registrations
{

    public class Plantcategories
    {
        DL.Registrations.Plantcategories plantcategoryDL = new DL.Registrations.Plantcategories();
        public EL.Registrations.Plantcategories Select(EL.Registrations.Plantcategories plantcategoryEL)
        {
            return plantcategoryDL.Select(plantcategoryEL);
        }
    }
}
