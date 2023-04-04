using DOAN_WEB.Models.KantanjiModel;
using DOAN_WEB.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOAN_WEB.Controllers
{
    public class kantanjiController : Controller
    {
        // GET: kantanji
        KantanjiContext kantanjiDb = new KantanjiContext();
       
        //--------------------HOME------------------
        public ActionResult Home()
        {
            return View();
        }

        //---------------------CHU DE-----------------
        public ActionResult Cap_Do()
        {
            List<CAPDO> listCD = kantanjiDb.CAPDOes.ToList();
            return PartialView(listCD);
        }

        public ActionResult ChuDe()
        {
            List<CHUDECHINH> listCD = kantanjiDb.CHUDECHINHs.ToList();
            return View(listCD);
        }

        public ActionResult NguCanh(int idcapdo)
        {
            List<NGUCANH> listNC = kantanjiDb.NGUCANHs.Where(a => a.IDCAPDO == idcapdo ).ToList();
            string tenCAPDO = kantanjiDb.CAPDOes.Where(a => a.IDCAPDO == idcapdo).Single().TENCAPDO.ToString();
            ViewBag.TenCAPDO = tenCAPDO;
            return View(listNC);
        }

        public ActionResult ListKJ()
        {
            List<KANJI> listkanji = kantanjiDb.KANJIs.ToList();
            return View(listkanji);
        }

        public ActionResult ChitietKJ(int id)
        {
            KANJI kanji = kantanjiDb.KANJIs.SingleOrDefault(n => n.IDKANJI == id);

            return View(kanji);
        }

        //--------------LUYEN TAP-------------------
        public ActionResult LuyenTap()
        {
            List<CHUDECHINH> listCD = kantanjiDb.CHUDECHINHs.ToList();
            return View(listCD);
        }
        public ActionResult Trochoi()
        {
          
            return View();
        }
        public ActionResult Trochoi2()
        {

            return View();
        }

        //-------------------FLASHCARD--------------
        public ActionResult MenuChuyenNganh()
        {
            List<CHUDECHINH> listCD = kantanjiDb.CHUDECHINHs.ToList();
            return PartialView(listCD);
        }

        public ActionResult FlashCard(int id)
        {
            List<FLASHCARD> listFC = kantanjiDb.FLASHCARDs.Where(a => a.IDCHUDE == id).ToList();
            string tenCN = kantanjiDb.CHUDECHINHs.Where(a => a.IDCHUDE == id).Single().TENCHUDE.ToString();
            ViewBag.TenCN = tenCN;
            return View(listFC);
        }

        public ActionResult FAQ()
        {
            return View();
        }
    
        //------------------THI NGAY----------------
        public ActionResult Cautruc()
        {       
            return View();
        }
        public ActionResult XacMinh()
        {
            //danh sách giảng viên được theo dõi bởi người dùng (đăng nhập) hiện tại
            /*var listFollwee = kantanjiDb..Where(p => p.FollowerId ==
            currentUser.Id).ToList();*/
            Account data = TempData["mydata"] as Account;
            THONGTIN tam = kantanjiDb.THONGTINs.SingleOrDefault(p=> p.IDUSER==data.AccountId);
            return PartialView(tam);
        }
        public ActionResult BaiThiTV()
        {
            List<DETVNP> listTV = kantanjiDb.DETVNPs.ToList();
            return View(listTV);
        }

        public ActionResult DeDoc()
        {
            List<DOCHIEU> listDD = kantanjiDb.DOCHIEUx.ToList();
            return PartialView(listDD);
        }

        public ActionResult BaiThiDocHieu()
        {
            List<DEDOC> listDH = kantanjiDb.DEDOCs.ToList();
            return View(listDH);
        }
        public ActionResult DeNghe()
        {
            List<AUDIO> listDN = kantanjiDb.AUDIOs.ToList();
            return PartialView(listDN);
        }

        public ActionResult BaiThiNghe()
        {
            List<DENGHE> lisTNH = kantanjiDb.DENGHEs.ToList();
            return View(lisTNH);
        }
        public ActionResult Camera()
        {
            return View();
        }
        public ActionResult HoanThanh()
        {
            return View();
        }
    }
}