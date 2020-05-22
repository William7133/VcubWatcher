using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VclubWatcher.Models
{
  public class Tri
  {
    public async Task<IActionResult> Index(string sortOrder, object _context)
{
    ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
    ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
    var velo = from s in _context.Velo
                   select s;
    switch (sortOrder)
    {
        case "name_desc":
            velo = velo.OrderByDescending(s => s.LastName);
            break;
        case "date_desc":
          velo = velo.OrderByDescending(s => s.EnrollmentDate);
            break;
        default:
          velo = velo.OrderBy(s => s.LastName);
            break;
    }
    return View(await velo.AsNoTracking().ToListAsync());
}
  }
}
