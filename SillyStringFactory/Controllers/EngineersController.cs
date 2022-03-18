using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using SillyStringFactory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SillyStringFactory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly SillyStringFactoryContext _db;
    public EngineersController(SillyStringFactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Description");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Engineer engineer, int MachineId)
    {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      if (MachineId != 0)
      {
        _db.MachineEngineer.Add(new MachineEngineer() { MachineId = MachineId, EngineerId = engineer.EngineerId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisEngineer = _db.Engineers
        .Include(thisEngineer => thisEngineer.JoinEntities)
        .ThenInclude(join => join.Machine)
        .FirstOrDefault(thisEngineer => thisEngineer.EngineerId == id);
      return View(thisEngineer);
    }
  }
}