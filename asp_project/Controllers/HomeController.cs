using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;
using WebApplication3.DataContext;
using System.Xml;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetDB()
        {
            GetSeoul();
            GetPolice();

            Response.Redirect("Index");
            return View();
        }

        public void GetSeoul()
        {
            string url_Seoul = "http://openapi.seoul.go.kr:8088/76676170526a7268313032484a736978/xml/lostArticleInfo/" +
            1 + "/" +
            1000 + "/";

            XmlDocument xdoc = new XmlDocument();

            xdoc.Load(url_Seoul);
            XmlNodeList xnodeList = xdoc.DocumentElement.SelectNodes("/lostArticleInfo/row");

            foreach (XmlNode xnode in xnodeList)
            {
                if (xnode["STATUS"].InnerText != "수령")
                {
                    if (DateTime.Compare(Convert.ToDateTime("2020-06-01"),
                        Convert.ToDateTime(xnode["REG_DATE"].InnerText)) <= 0)
                    {
                        Found found_Seoul = new Found();

                        found_Seoul.Found_DateTime = xnode["REG_DATE"].InnerText;
                        found_Seoul.Found_BigCate = xnode["CATE"].InnerText;
                        found_Seoul.Found_Name = xnode["GET_NAME"].InnerText;
                        found_Seoul.Found_GetPosition = xnode["GET_AREA"].InnerText;
                        found_Seoul.Found_data = "서울시";

                        using (var db = new NoteDBContext())
                        {
                            db.Found.Add(found_Seoul);
                            db.SaveChanges();
                        }
                    }

                }
            }
        }

        public void GetPolice()
        {
            int index = 0;
            int show_size = 10000;
            int totalCount = 0;
            string url_Police = "http://apis.data.go.kr/1320000/LosfundInfoInqireService/getLosfundInfoAccToClAreaPd?serviceKey=QM218VcrO%2BoL6AOKYNgiEK9fQDAeHaoS3%2F8n8PWz3xVM84Dxv24YMuIAJbmrUFsk2b4HancEzvLVCyNBPsIIyw%3D%3D" +
                "&START_YMD=20200101" +
                "&END_YMD=" + DateTime.Now.ToString("yyyyMMdd") +
                "&pageNo=" + index+1 +
                "&numOfRows=" + show_size;

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(url_Police);
            totalCount = Convert.ToInt32(xdoc.GetElementsByTagName("totalCount")[0].InnerText);


            
            while (index * show_size < totalCount)
            {
                index++;
                url_Police = "http://apis.data.go.kr/1320000/LosfundInfoInqireService/getLosfundInfoAccToClAreaPd?serviceKey=QM218VcrO%2BoL6AOKYNgiEK9fQDAeHaoS3%2F8n8PWz3xVM84Dxv24YMuIAJbmrUFsk2b4HancEzvLVCyNBPsIIyw%3D%3D" +
                "&START_YMD=20200101" +
                "&END_YMD=" + DateTime.Now.ToString("yyyyMMdd") +
                "&pageNo=" + index +
                "&numOfRows=" + show_size;

                xdoc.Load(url_Police);
                XmlNodeList xnodeList = xdoc.DocumentElement.SelectNodes("/response/body/items/item");

                foreach (XmlNode xnode in xnodeList)
                {
                    Found found_police = new Found();
                    found_police.Found_data = "경찰청";
                    found_police.Found_GetPosition = xnode["depPlace"].InnerText;
                    found_police.Found_ImageURL = xnode["fdFilePathImg"].InnerText;
                    found_police.Found_Name = xnode["fdPrdtNm"].InnerText;
                    found_police.Found_Description = xnode["fdSbjt"].InnerText;
                    found_police.Found_DateTime = xnode["fdYmd"].InnerText;
                    string cate = xnode["prdtClNm"].InnerText;
                    string[] catelist = cate.Split(" > ");

                    found_police.Found_BigCate = catelist[0];
                    found_police.Found_SmallCate = catelist[1];

                    if (!(found_police.Found_BigCate == "기타물품" && found_police.Found_SmallCate == "기타" && found_police.Found_Name == "기타물품"))
                    {
                        using (var db = new NoteDBContext())
                        {
                            db.Found.Add(found_police);
                            db.SaveChanges();
                        }
                    }
                }
                index++;
            }
        }
    }
}
