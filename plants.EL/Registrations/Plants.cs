using System;
using System.Collections.Generic;
using System.Text;

namespace plants.EL.Registrations
{
    public class Plants
    {
        int plantid;
        string plantname;
        string plantscientificname;
        string plantdescription;

        public int Plantid { get => plantid; set => plantid = value; }
        public string Plantname { get => plantname; set => plantname = value; }
        public string Plantscientificname { get => plantscientificname; set => plantscientificname = value; }
        public string Plantdescription { get => plantdescription; set => plantdescription = value; }
    }
}
