using InspectionApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

//lots of controllers for managing Location method results

namespace InspectionApp.Controllers
{
    public class LocationController : Controller
    {
        public ActionResult Index()
        {
             using (var inspectionAppCTXT = new InspectionAppCTXT())
             {
                var locationList = new LocationListViewModel
                {
                    //Convert each Location to a LocationViewModel
                    Locations = inspectionAppCTXT.Locations.Select(p => new LocationViewModel
                    {
                        LocationID = p.LocationID,
                        LocationName = p.LocationName,
                        LocationAddress = p.LocationAddress,
                        LocationCity = p.LocationCity,
                        LocationState = p.LocationState,
                        LocationZip = p.LocationZip,
                        LocationType = p.LocationType,
                        LocationInspectionDate = p.LocationInspectionDate,
                        LocationGrade = p.LocationGrade,

                    }).ToList()
                };
                // count how many records
                    locationList.TotalLocations = locationList.Locations.Count;

                    return View(locationList);
             }
        }

        // create a view with data from single Location DETAIL
        public ActionResult LocationDetail(int id)
        {
            using (var inspectionAppCTXT = new InspectionAppCTXT())
            {
                var location = inspectionAppCTXT.Locations.SingleOrDefault(p => p.LocationID == id);
                if (location != null)
                {
                    var locationViewModel = new LocationViewModel
                    {
                        LocationID = location.LocationID,
                        LocationName = location.LocationName,
                        LocationAddress = location.LocationAddress,
                        LocationCity = location.LocationCity,
                        LocationState = location.LocationState,
                        LocationZip = location.LocationZip,
                        LocationType = location.LocationType,
                        LocationInspectionDate = location.LocationInspectionDate,
                        LocationGrade = location.LocationGrade
                    };

                    return View(locationViewModel);
                }
            }
            return new HttpNotFoundResult();
        }

        // add a location
        public ActionResult LocationAdd()
        {
            var locationViewModel = new LocationViewModel();

            return View("AddEditLocation", locationViewModel);
        }

        [HttpPost]
        public ActionResult AddLocation(LocationViewModel locationViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEditLocation", locationViewModel);
            }

            using (var inspectionAppCTXT = new InspectionAppCTXT())
            {
                var location = new Location
                {
                    LocationName = locationViewModel.LocationName,
                    LocationAddress = locationViewModel.LocationAddress,
                    LocationCity = locationViewModel.LocationCity,
                    LocationState = locationViewModel.LocationState,
                    LocationZip = locationViewModel.LocationZip,
                    LocationType = locationViewModel.LocationType,
                    LocationInspectionDate = locationViewModel.LocationInspectionDate,
                    LocationGrade = locationViewModel.LocationGrade
                };

                inspectionAppCTXT.Locations.Add(location);
                inspectionAppCTXT.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // edit a location
        public ActionResult LocationEdit(int id)
        {
            using (var inspectionAppCTXT = new InspectionAppCTXT())
            {
                var location = inspectionAppCTXT.Locations.SingleOrDefault(p => p.LocationID == id);
                if (location != null)
                {
                    var locationViewModel = new LocationViewModel
                    {
                        LocationID = location.LocationID,
                        LocationName = location.LocationName,
                        LocationAddress = location.LocationAddress,
                        LocationCity = location.LocationCity,
                        LocationState = location.LocationState,
                        LocationZip = location.LocationZip,
                        LocationType = location.LocationType,
                        LocationInspectionDate = location.LocationInspectionDate,
                        LocationGrade = location.LocationGrade
                    };

                    return View("AddEditLocation", locationViewModel);
                }
            }

            return new HttpNotFoundResult();
        }


        [HttpPost]
        public ActionResult EditLocation(LocationViewModel locationViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEditLocation", locationViewModel);
            }

            using (var inspectionAppCTXT = new InspectionAppCTXT())
            {
                var location = inspectionAppCTXT.Locations.SingleOrDefault(p => p.LocationID == locationViewModel.LocationID);

                if (location != null)
                {
                    location.LocationName = locationViewModel.LocationName;
                    location.LocationAddress = locationViewModel.LocationAddress;
                    location.LocationCity = locationViewModel.LocationCity;
                    location.LocationState = locationViewModel.LocationState;
                    location.LocationZip = locationViewModel.LocationZip;
                    location.LocationType = locationViewModel.LocationType;
                    location.LocationInspectionDate = locationViewModel.LocationInspectionDate;
                    location.LocationGrade = locationViewModel.LocationGrade;

                    inspectionAppCTXT.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return new HttpNotFoundResult();
        }

        // delete location
        [HttpPost]
        public ActionResult DeleteLocation(LocationViewModel locationViewModel)
        {
            using (var inspectionAppCTXT = new InspectionAppCTXT())
            {
                var location = inspectionAppCTXT.Locations.SingleOrDefault(p => p.LocationID == locationViewModel.LocationID);

                if (location != null)
                {
                    inspectionAppCTXT.Locations.Remove(location);
                    inspectionAppCTXT.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return new HttpNotFoundResult();
        }                     
        
    }
}