using Microsoft.AspNetCore.Mvc;
using Police_Eye_Witness_Tracker.Data;
using Police_Eye_Witness_Tracker.Models;

namespace Police_Eye_Witness_Tracker.Controllers
{
    public class EyeWitnessReportController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EyeWitnessReportController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EyeWitnessReport> objEyeWitnessReportList = _db.EyeWitnessReports;
            return View(objEyeWitnessReportList);
        }
        //GET
        public IActionResult ReportanIncidence()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReportanIncidence(EyeWitnessReport obj)
        {
            if (obj.FirstName == obj.IncidenceReportNarration.ToString())
            {
                ModelState.AddModelError("First", "Narration cannot exactly match the First Name");
            }
            if (ModelState.IsValid)
            {
                _db.EyeWitnessReports.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "We have received your incidence report, " +
                    "our rapid response team will take actions immediately. " +
                    "Thank you for helping the police to fight crime and protect lives and properties";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var EyeWitnessReportFromDb = _db.EyeWitnessReports.Find(id);
            //var EyeWitnessReportFromDbFirst = _db.EyeWitnessReports.FirstOrDefault(u=>u.Id==id);
            //var EyeWitnessReportFromDbSingle = _db.EyeWitnessReports.SingleOrDefault(u => u.Id == id);

            if (EyeWitnessReportFromDb == null)
            {
                return NotFound();
            }
            return View(EyeWitnessReportFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EyeWitnessReport obj)
        {
            if (obj.FirstName == obj.IncidenceReportNarration.ToString())
            {
                ModelState.AddModelError("First", "Narration cannot exactly match the First Name");
            }
            if (ModelState.IsValid)
            {
                _db.EyeWitnessReports.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Incidence Report updated Successfully";
                return RedirectToAction("Index");

            }
            return View(obj);
        }
        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var EyeWitnessReportFromDb = _db.EyeWitnessReports.Find(id);
            //var EyeWitnessReportFromDbFirst = _db.EyeWitnessReports.FirstOrDefault(u=>u.Id==id);
            //var EyeWitnessReportFromDbSingle = _db.EyeWitnessReports.SingleOrDefault(u => u.Id == id);

            if (EyeWitnessReportFromDb == null)
            {
                return NotFound();
            }
            return View(EyeWitnessReportFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.EyeWitnessReports.Find(id);   
            if (obj == null)
            {
                return NotFound();
            }
                _db.EyeWitnessReports.Remove(obj);
                _db.SaveChanges();
                TempData["success"] = "Incidence Report deleted Successfully";
            return RedirectToAction("Index");
            
            
        }
    }
}
