using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMSweb.Models;

namespace LMSweb.Controllers
{
    public class LearningJourneyController : Controller
    {
        // GET: LearningJourney
        private LMSmodel db = new LMSmodel();
        public ActionResult ClassJourney()
        {
            return View(db.LearnB.ToList());
        }

        public ActionResult GroupJourney()
        {
            return View(db.LearnB.ToList());
        }

        public ActionResult PersonalJourney()
        {
            var results = db.LearnB
                .Where(j => j.StudentMissions.SID == "S001")
                .Select(j => new { j.ActionType, j.subAction, j.Detail, j.Time, j.StudentMissions.SID });
            return View(results);
        } 
    }
}