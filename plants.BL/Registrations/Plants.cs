using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace plants.BL.Registrations
{
    public class Plants
    {
        DL.Registrations.Plants plantDL = new DL.Registrations.Plants();
       
        public DataTable List(int id, string str)
        {
            return plantDL.List(id, str);
        }

        public EL.Registrations.Plants Select(EL.Registrations.Plants plantEL)
        {
            return plantDL.Select(plantEL);
        }

        public long Insert(EL.Registrations.Plants plantEL)
        {
            return plantDL.Insert(plantEL);
        }

        public Boolean Update(EL.Registrations.Plants plantEL)
        {
            return plantDL.Update(plantEL);
        }

        public Boolean Delete(EL.Registrations.Plants plantEL)
        {
            return plantDL.Delete(plantEL);
        }
    }
}
