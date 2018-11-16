using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InspectionApp.Models
{
    // create a class to get-set all data associated with specific location
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public string LocationZip { get; set; }
        public string LocationType { get; set; }
        public string LocationInspectionDate { get; set; }
        public string LocationGrade { get; set; }
    }

}