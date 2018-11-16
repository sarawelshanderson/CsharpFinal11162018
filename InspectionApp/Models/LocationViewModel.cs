using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

//view model to represent Location

namespace InspectionApp.Models
{
    public class LocationViewModel
    {
        public int? LocationID { get; set; }

        [DisplayName("Location Name")]
        public string LocationName { get; set; }

        [DisplayName("Loaction Street Address")]
        public string LocationAddress { get; set; }

        [DisplayName("Loaction City")]
        public string LocationCity { get; set; }

        [DisplayName("Loaction State")]
        public string LocationState { get; set; }

        [DisplayName("Loaction Zip Code")]
        public string LocationZip { get; set; }

        [DisplayName("Location Type")]
        public string LocationType { get; set; }

        [DisplayName("Inspection Date")]
        public string LocationInspectionDate { get; set; }

        [DisplayName("Grade")]
        public string LocationGrade { get; set; }

        [DisplayName("Full List Location Information")]
        public string FullLocationInfo => LocationName + ", " + LocationAddress + ", " + LocationCity + ", " + LocationState + " " + LocationZip + " has a grade of  " + LocationGrade;
    }
}