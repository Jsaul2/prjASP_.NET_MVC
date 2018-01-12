using GestionCentreFormation_Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionCentreFormation_IHM.Controllers
{
    public class ThemeFormationController : Controller
    {
        // GET: ThemeFormation
        public ActionResult Index()
        {
            FormationEntities oContexteDonnees = new FormationEntities(); 
            return View(new FormationEntities().Theme);
        }

        
    }
}