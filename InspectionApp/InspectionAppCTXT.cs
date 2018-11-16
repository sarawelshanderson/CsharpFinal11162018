using InspectionApp.Models;
using System.Data.Entity;

namespace InspectionApp
{
    public class InspectionAppCTXT : DbContext
    {
        public InspectionAppCTXT() : base("name=InspectionAppCTXT") { }

        public virtual DbSet<Location> Locations { get; set; }
    }
}
