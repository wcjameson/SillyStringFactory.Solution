using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SillyStringFactory.Models;
using System.Collections.Generic;
using System.Linq;

namespace SillyStringFactory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly SillyStringFactoryContext _db;

    public MachinesController(SillyStringFactoryContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        List<Machine> model = _db.Machines.ToList();
        return View(model);
    }
  }
}