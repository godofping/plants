using System;
using System.Collections.Generic;
using System.Text;

namespace plants.EL.Registrations
{
    public class Plantimages
    {
        int plantimageid;
        int plantid;
        Byte[] plantimage;
        string plantimageshortdescription;

        public int Plantimageid { get => plantimageid; set => plantimageid = value; }
        public int Plantid { get => plantid; set => plantid = value; }
        public byte[] Plantimage { get => plantimage; set => plantimage = value; }
        public string Plantimageshortdescription { get => plantimageshortdescription; set => plantimageshortdescription = value; }
    }
}
