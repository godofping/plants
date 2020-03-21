using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace plants.DL.Registrations
{
    public class Plantcategories
    {
        public EL.Registrations.Plantcategories Select(EL.Registrations.Plantcategories plantcategoryEL)
        {

            DataTable dt = null;

            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "select * from plantcategories where plantcategoryid = @plantcategoryid";

                cmd.Parameters.AddWithValue("@plantcategoryid", plantcategoryEL.Plantcategoryid);

                dt = methods.executeQuery(cmd);
            }

            if (dt.Rows.Count > 0)
            {
                plantcategoryEL.Plantcategoryid = Convert.ToInt32(dt.Rows[0]["plantcategoryid"]);
                plantcategoryEL.Plantcategory = dt.Rows[0]["plantcategory"].ToString();

                return plantcategoryEL;
            }
            else
            {
                return null;
            }
        }
    }
}
