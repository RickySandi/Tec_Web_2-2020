using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment_1
{
    /*
    public enum InstitutionType
    {
        asociacionAtletismo,
        psg,
        bayernMunchen
    }
    */
    public class Institution
     {
        public int AthleteId { get; set; }
        public string InstitutionCountry { get; set; }
        //public int AthleteAge { get; set; }
        public string InstitutionName { get; set; }
    }
    
}
