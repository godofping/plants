using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace plants.DL.Registrations
{
    public class Plants
    {
        public DataTable List(int id, string str)
        {
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "select plantid, plantcommonname, plantscientificname from plants where plantcategoryid = @id and (plantcommonname like @str or plantscientificname like @str)";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@str", "%" + str + "%");
                return methods.executeQuery(cmd);
            }
        }

        public EL.Registrations.Plants Select(EL.Registrations.Plants plantEL)
        {

            DataTable dt = null;

            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "select * from plants where plantid = @plantid";

                cmd.Parameters.AddWithValue("@plantid", plantEL.Plantid);

                dt = methods.executeQuery(cmd);
            }

            if (dt.Rows.Count > 0)
            {
                plantEL.Plantid = Convert.ToInt32(dt.Rows[0]["plantid"]);
                plantEL.Plantcategoryid = Convert.ToInt32(dt.Rows[0]["plantcategoryid"]);
                plantEL.Plantcommonname = dt.Rows[0]["plantcommonname"].ToString();
                plantEL.Plantscientificname = dt.Rows[0]["plantscientificname"].ToString();
                plantEL.Plantfamily = dt.Rows[0]["plantfamily"].ToString();
                plantEL.Plantmorphology = dt.Rows[0]["plantmorphology"].ToString();
                plantEL.Planteconomicimportance = dt.Rows[0]["planteconomicimportance"].ToString();
                plantEL.Plantwholeimage = (byte[])dt.Rows[0]["plantwholeimage"];
                plantEL.Plantflowerimage = (byte[])dt.Rows[0]["plantflowerimage"];
                plantEL.Plantleavesimage = (byte[])dt.Rows[0]["plantleavesimage"];

                return plantEL;
            }
            else
            {
                return null;
            }
        }

        public long Insert(EL.Registrations.Plants plantEL)
        {
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "insert into  plants set plantcategoryid = @plantcategoryid, plantcommonname = @plantcommonname, plantscientificname = @plantscientificname, plantfamily = @plantfamily, plantmorphology = @plantmorphology, planteconomicimportance = @planteconomicimportance, plantwholeimage = @plantwholeimage, plantflowerimage = @plantflowerimage, plantleavesimage = @plantleavesimage";

                cmd.Parameters.AddWithValue("@plantcategoryid", plantEL.Plantcategoryid);
                cmd.Parameters.AddWithValue("@plantcommonname", plantEL.Plantcommonname);
                cmd.Parameters.AddWithValue("@plantscientificname", plantEL.Plantscientificname);
                cmd.Parameters.AddWithValue("@plantfamily", plantEL.Plantfamily);
                cmd.Parameters.AddWithValue("@plantmorphology", plantEL.Plantmorphology);
                cmd.Parameters.AddWithValue("@planteconomicimportance", plantEL.Planteconomicimportance);
                cmd.Parameters.AddWithValue("@plantwholeimage", plantEL.Plantwholeimage);
                cmd.Parameters.AddWithValue("@plantflowerimage", plantEL.Plantflowerimage);
                cmd.Parameters.AddWithValue("@plantleavesimage", plantEL.Plantleavesimage);
                return methods.executeNonQueryLong(cmd);
            }
        }

        public Boolean Update(EL.Registrations.Plants plantEL)
        {
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "update plants set plantcategoryid = @plantcategoryid, plantcommonname = @plantcommonname, plantscientificname = @plantscientificname, plantfamily = @plantfamily, plantmorphology = @plantmorphology, planteconomicimportance = @planteconomicimportance, plantwholeimage = @plantwholeimage, plantflowerimage = @plantflowerimage, plantleavesimage = @plantleavesimage where plantid = @plantid";

                cmd.Parameters.AddWithValue("@plantid", plantEL.Plantid);
                cmd.Parameters.AddWithValue("@plantcategoryid", plantEL.Plantcategoryid);
                cmd.Parameters.AddWithValue("@plantcommonname", plantEL.Plantcommonname);
                cmd.Parameters.AddWithValue("@plantscientificname", plantEL.Plantscientificname);
                cmd.Parameters.AddWithValue("@plantfamily", plantEL.Plantfamily);
                cmd.Parameters.AddWithValue("@plantmorphology", plantEL.Plantmorphology);
                cmd.Parameters.AddWithValue("@planteconomicimportance", plantEL.Planteconomicimportance);
                cmd.Parameters.AddWithValue("@plantwholeimage", plantEL.Plantwholeimage);
                cmd.Parameters.AddWithValue("@plantflowerimage", plantEL.Plantflowerimage);
                cmd.Parameters.AddWithValue("@plantleavesimage", plantEL.Plantleavesimage);
                return methods.executeNonQueryBool(cmd);
            }
        }

        public Boolean Delete(EL.Registrations.Plants plantEL)
        {
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "delete from plants where plantid = @plantid";

                cmd.Parameters.AddWithValue("@plantid", plantEL.Plantid);
                return methods.executeNonQueryBool(cmd);
            }
        }
    }
}
