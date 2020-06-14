using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using WebApplication3.Models;
using WebApplication3.DataContext;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class FoundController : Controller
    {
        GetDBtoAPI getDB = new GetDBtoAPI();

        // GET: /<controller>/
        public IActionResult Index(int page = 1)
        {
            getDB.GetSeoul(DateTime.Now);
            getDB.GetPolice(DateTime.Now, DateTime.Now, 1000);
            List<Found> founds = new List<Found>();
            using (NoteDBContext db = new NoteDBContext())
            {
                var a = db.Found;

                foreach (var found in a)
                {
                    founds.Add(new Found
                    {
                        Found_id = found.Found_id,
                        Found_data = found.Found_data,
                        Found_BigCate = found.Found_BigCate,
                        Found_DateTime = found.Found_DateTime,
                        Found_Description = found.Found_Description,
                        Found_GetPosition = found.Found_GetPosition,
                        Found_ImageURL = found.Found_ImageURL,
                        Found_Name = found.Found_Name,
                        Found_SmallCate = found.Found_SmallCate
                    });
                }
            }
            return View(founds.ToPagedList(page, 10));
        }
        public IActionResult search(string name, string place, DateTime date, int page = 1)
        {
            List<Found> founds = new List<Found>();
            using (NoteDBContext db = new NoteDBContext())
            {
                var a = db.Found;

                foreach (var found in a)
                {
                    if (found.Found_BigCate == name && date < found.Found_DateTime && found.Found_GetPosition.Contains(place))
                    {
                        founds.Add(new Found
                        {
                            Found_id = found.Found_id,
                            Found_data = found.Found_data,
                            Found_BigCate = found.Found_BigCate,
                            Found_DateTime = found.Found_DateTime,
                            Found_Description = found.Found_Description,
                            Found_GetPosition = found.Found_GetPosition,
                            Found_ImageURL = found.Found_ImageURL,
                            Found_Name = found.Found_Name,
                            Found_SmallCate = found.Found_SmallCate
                        });
                    }
                }
            }
            return View(founds.ToPagedList(page, 10));
        }
        public IActionResult Detail()
        {
            return View();
        }


    }
}

