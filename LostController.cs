using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class LostController : Controller
    {
        public IActionResult Index()
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
            return View(losts);
        }
    }
}
