using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//view model to represent Location List

namespace InspectionApp.Models
{
    public class LocationListViewModel
    {
        public List<LocationViewModel> Locations { get; set; }
                public int TotalLocations { get; set; }
    }

}