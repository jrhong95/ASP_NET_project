using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList;
using WebApplication3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class LostController : Controller
    {
        public IActionResult Index(int page = 1)
        {
            string url = "http://apis.data.go.kr/1320000/LostGoodsInfoInqireService/getLostGoodsInfoAccToClAreaPd?serviceKey=NWOxLHFs7YrxdPu2caTYxawT1IP1aY%2B2aL7UKm2IuwSuoUYaMLvPxScxP4CeFl%2Fs5vMLnVzKnjAVqqkqNVznMw%3D%3D" +
        "&START_YMD=20200501" +
        "&END_YMD=20200601" +
        "&LST_LCT_CD=LCA000" +
        "&pageNo=1" +
        "&numOfRows=100";
            XmlDocument xdoc = new XmlDocument();
            List<Lost> losts = new List<Lost>();
            xdoc.Load(url);
            XmlNodeList xnodeList = xdoc.DocumentElement.SelectNodes("/response/body/items/item");

            foreach (XmlNode xnode in xnodeList)
            {
                losts.Add(new Lost
                {
                    location = xnode["lstPlace"].InnerText,
                    goods = xnode["lstPrdtNm"].InnerText,
                    description = xnode["lstSbjt"].InnerText,
                    date = xnode["lstYmd"].InnerText,
                    
                });
            }
           
            list_sort(losts);
            return View(losts.ToPagedList(page, 5));
        }
        public static void list_sort(List<Lost> a)
        {
            string next;
            if (a.Count == 0) return;
            for (int i = 0; i < a.Count; i++)
            {
              a[i].date=  a[i].date.Replace("-","");
            }
            
            
            for (int i = 1; i < a.Count; i++)
            {
                next = a[i].date;
                int j = i;
                while (j > 0 && Int32.Parse(next) < Int32.Parse(a[j - 1].date))
                {
                    a[j].date = a[j - 1].date;
                    
                    j--;
                }
                a[j].date = next;
            }
            for (int i = 0; i < a.Count; i++)
            {
                a[i].date = a[i].date.Insert(4,"-");
                a[i].date = a[i].date.Insert(7, "-");
            }

            a.Reverse();
        }

    }
}