using JS_Grid_dynamic.Models;
using Microsoft.AspNetCore.Mvc;

namespace JS_Grid_dynamic.Controllers
{
    public class DataController : Controller
    {
        private DataDbcontext context;

        public DataController(DataDbcontext context)
        {
            this.context = context;
        }
        public IActionResult AllData()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetData()
        {
            var result = context.Datas.ToList();
            return Json(result);
        }


        [HttpPost]
        public IActionResult CreateList(Data model)
        {
            if (model != null)
            {
                context.Datas.Add(model);
                context.SaveChanges();
            }
            return Json(model);
        }
        [HttpPost]
        public IActionResult UpdateList(Data model)
        {
            if (model != null)
            {
                context.Datas.Update(model);
                context.SaveChanges();
            }
            return Json(model); 
            
        }
        public IActionResult DeleteList(Data model)
        {
            if (model != null)
            {
                context.Datas.Remove(model);
                context.SaveChanges();
            }
            return Json(model); ;
        }
    }
}
