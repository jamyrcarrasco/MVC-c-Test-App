using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_app_uepaticket.Context;

namespace Test_app_uepaticket.Controllers
{
    public class LocationController : Controller
    {
        db_uepaticketEntities DbEntity = new db_uepaticketEntities();
        // GET: Location
        public ActionResult Location(event_location obj)
        {
            return View(obj);
        }

        /// <summary>
        /// ADD OR EDIT EVENT LOCATION
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddOrEditLocation(event_location model)
        {
            if (ModelState.IsValid)
            {
                event_location tbl = new event_location();
                tbl.id = model.id;
                tbl.name = model.name;
                tbl.description = model.description;

                if (model.id == 0)
                {
                    DbEntity.event_location.Add(tbl);
                    DbEntity.SaveChanges();
                }
                else
                {
                    DbEntity.Entry(tbl).State = System.Data.Entity.EntityState.Modified;
                    DbEntity.SaveChanges();
                }


            }
            ModelState.Clear();
            //return View("Category");
            return RedirectToAction("LocationList");
        }

        /// <summary>
        /// HTTP GET THAT RETURNS EVENT LOCATIONS
        /// </summary>
        /// <returns>LIST</returns>
        public ActionResult LocationList()
        {
            var response = DbEntity.event_location.ToList();
            return View(response);
        }

        /// <summary>
        /// HTTP DELETE: DELETES LOCATION BY ITS ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //[HttpDelete]
        public ActionResult Delete(int id)
        {
            var obj = DbEntity.event_location.Where(x => x.id == id).First();
            DbEntity.event_location.Remove(obj);
            DbEntity.SaveChanges();

            var response = DbEntity.event_location.ToList();
            return View("LocationList", response);
        }
    }
}