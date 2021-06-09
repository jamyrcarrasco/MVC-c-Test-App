using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_app_uepaticket.Context;

namespace Test_app_uepaticket.Controllers
{
    public class EventController : Controller
    {
        db_uepaticketEntities DbEntity = new db_uepaticketEntities();
        // GET: Event
        public ActionResult Event(@event obj)
        {
            ViewBag.CategoryList = new SelectList(DbEntity.event_categories, "id", "name");
            ViewBag.LocationList = new SelectList(DbEntity.event_location, "id", "name");
            return View(obj);
        }

        /// <summary>
        /// ADD OR EDIT EVENT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddOrEditEvent(@event model)
        {
            if (ModelState.IsValid)
            {
                @event tbl = new @event();
                tbl.id = model.id;
                tbl.name = model.name;
                tbl.description = model.description;
                tbl.image_url = model.image_url;
                tbl.event_category_id = model.event_category_id;
                tbl.event_location_id = model.event_location_id;

                if (model.id == 0)
                {
                    DbEntity.events.Add(tbl);
                    DbEntity.SaveChanges();
                }
                else
                {
                    DbEntity.Entry(tbl).State = System.Data.Entity.EntityState.Modified;
                    DbEntity.SaveChanges();
                }


            }
            ModelState.Clear();
            return RedirectToAction("EventList");
        }

        /// <summary>
        /// HTTP GET THAT RETURNS EVENTS
        /// </summary>
        /// <returns>LIST</returns>
        public ActionResult EventList()
        {
            var response = DbEntity.events.ToList();
            return View(response);
        }

        /// <summary>
        /// HTTP DELETE: DELETES EVENT BY ITS ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //[HttpDelete]
        public ActionResult Delete(int id)
        {
            var obj = DbEntity.events.Where(x => x.id == id).First();
            DbEntity.events.Remove(obj);
            DbEntity.SaveChanges();

            var response = DbEntity.events.ToList();
            return View("EventList", response);
        }


        public ActionResult HomeEventList(string searchValue)
        {
            //var response = DbEntity.events.ToList();
            //return View(response);

            var result = from r in DbEntity.events select r;
            if (!String.IsNullOrEmpty(searchValue))
            {
                result = result.Where(x => x.name.Contains(searchValue));
            }

            return View(result.ToList());
        }


    }
}