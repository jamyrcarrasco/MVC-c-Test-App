using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_app_uepaticket.Context;

namespace Test_app_uepaticket.Controllers
{
    public class CategoryController : Controller
    {
        //Entity

        db_uepaticketEntities DbEntity = new db_uepaticketEntities();
        // GET: Category
        public ActionResult Category(event_categories obj)
        {        
                return View(obj);

        }
        /// <summary>
        /// ADD OR EDIT CATEGORY
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddOrEditCategory(event_categories model)
        {
           
            if (ModelState.IsValid)
            {
                event_categories tbl = new event_categories();
                tbl.id = model.id;
                tbl.name = model.name;
                tbl.description = model.description;

                if(model.id == 0)
                {
                    DbEntity.event_categories.Add(tbl);
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
            return RedirectToAction("CategoryList");
        }
        /// <summary>
        /// HTTP GET THAT RETURNS LIST OF CATEGORIES
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CategoryList()
        {
            var response = DbEntity.event_categories.ToList();
            return View(response);
        }
        /// <summary>
        /// HTTP DELETE: DELETES CATEGORY BY ITS ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //[HttpDelete]
        public ActionResult Delete(int id)
        {
            var obj = DbEntity.event_categories.Where(x => x.id == id).First();
            DbEntity.event_categories.Remove(obj);
            DbEntity.SaveChanges();

            var response = DbEntity.event_categories.ToList();
            return View("CategoryList",response);
        }
    }
}