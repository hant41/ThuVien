using Luyentap3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Luyentap3.Controllers
{
    public class QuanLySachController : Controller
    {
        List<Sach> sachs = new List<Sach>();
        public QuanLySachController()
        {
            Sach s1 = new Sach("S1", "Trên đường băng", 10, 100);
            sachs.Add(s1);
            Sach s2 = new Sach("S2", "Trên đường băng", 10, 80000);
            sachs.Add(s2);
            Sach s3 = new Sach("S3", "Trên đường băng", 10, 80000);
            sachs.Add(s3);
            Sach s4 = new Sach("S4", "Trên đường băng", 10, 100);
            sachs.Add(s4);
            Sach s5 = new Sach("S5", "Trên đường băng", 2, 80000);
            sachs.Add(s5);
            Sach s6 = new Sach("S6", "Trên đường băng", 10, 80000);
            sachs.Add(s6);
            Sach s7 = new Sach("S7", "Trên đường băng", 2, 80000);
            sachs.Add(s7);
            Sach s8 = new Sach("S8", "Trên đường băng", 10, 80000);
            sachs.Add(s8);
            Sach s9 = new Sach("S9", "Trên đường băng", 2, 80000);
            sachs.Add(s9);
            Sach s10 = new Sach("S10", "Trên đường băng", 10, 80000);
            sachs.Add(s10);
        }
        // GET: QuanLySach
        public ActionResult HienThiListSach(Sach s)
        {
            if (s.masach != null)
                sachs.Add(s);
            ViewBag.List = sachs;
            return View(s);
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HienThiMotSach(Sach s)
        {
            return View(s);
        }
        public ActionResult Them()
        {
            return View();
        }
        public ActionResult HienThiHaiDS(Sach s)
        {
            ViewBag.List = sachs;
            return View(s);
        }
    }
}