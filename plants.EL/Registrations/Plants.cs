using System;
using System.Collections.Generic;
using System.Text;

namespace plants.EL.Registrations
{
    public class Plants
    {
        int plantid;
        int plantcategoryid;
        string plantcommonname;
        string plantscientificname;
        string plantfamily;
        string plantmorphology;
        string planteconomicimportance;
        string plantwholeimage;
        string plantflowerimage;
        string plantleavesimage;

        public int Plantid { get => plantid; set => plantid = value; }
        public int Plantcategoryid { get => plantcategoryid; set => plantcategoryid = value; }
        public string Plantcommonname { get => plantcommonname; set => plantcommonname = value; }
        public string Plantscientificname { get => plantscientificname; set => plantscientificname = value; }
        public string Plantfamily { get => plantfamily; set => plantfamily = value; }
        public string Plantmorphology { get => plantmorphology; set => plantmorphology = value; }
        public string Planteconomicimportance { get => planteconomicimportance; set => planteconomicimportance = value; }
        public string Plantwholeimage { get => plantwholeimage; set => plantwholeimage = value; }
        public string Plantflowerimage { get => plantflowerimage; set => plantflowerimage = value; }
        public string Plantleavesimage { get => plantleavesimage; set => plantleavesimage = value; }
    }
}
