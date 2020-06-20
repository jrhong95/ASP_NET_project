using System;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using WebApplication3.Models;
using WebApplication3.DataContext;

namespace WebApplication3.Controllers
{
    public class FoundController : Microsoft.AspNetCore.Mvc.Controller
    {
        GetDBtoAPI getDB = new GetDBtoAPI();

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> cateList = new List<string>(); //분ㅔ
            using (NoteDBContext db = new NoteDBContext())
            {
                var dv = db.Found;
                foreach (var a in dv)
                    cateList.Add(a.Found_BigCate);
            }
            cateList = cateList.Distinct().ToList();
            List<SelectListItem> selectlist = new List<SelectListItem>();
            foreach (string s in cateList)
            {
                selectlist.Add(new SelectListItem
                {
                    Value = s,
                    Text = s
                });
            }
            SearchValue sv = new SearchValue();

            sv.cateList = selectlist;

            return View(sv);
        }

        public IActionResult Search(SearchValue model = null, int page = 1)
        {
            getDB.GetSeoul(DateTime.Now);
            getDB.GetPolice(DateTime.Now, DateTime.Now, 100);
            if(model == null)
            {
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
            else
            {

            }
            return View();
        }


        public IActionResult Detail()
        {
            return View();
        }


    }
}

