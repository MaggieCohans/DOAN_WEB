using DOAN_WEB.Models.KantanjiModel;
using DOAN_WEB.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DOAN_WEB.Controllers
{
    public class UserController : Controller
    {
        // GET: kantanji
        //Database Kantanji
        KantanjiContext kantanjiDb = new KantanjiContext();
        Account ac = new Account();
        //Mã hóa Password
        public static string EncodePassword(string originalPassword)
        {

            MD5 md5 = new MD5CryptoServiceProvider();
            // Compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(originalPassword));
            // Get hash result after compute it
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }


        //Đăng nhập và đăng xuất
        public ActionResult Login()
        {
            if (Session["Taikhoan"] != null)
            {
                return RedirectToAction("Home", "kantanji");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            //Gán các giá trị người dùng nhập liệu cho các biến
            var tendn = collection["name"];
            var matkhau = collection["pass"];
            string en = EncodePassword(EncodePassword(matkhau));
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Vui lòng nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Vui lòng nhập mật khẩu";
            }
            else
            {
                //Gán giá trị cho đối tượng được tạo mới (kh)
                USER tk = kantanjiDb.USERs.SingleOrDefault(n => n.TAIKHOAN == tendn && n.ENPASSWORD == en);
                
                if (tk != null)
                {
                    ac.AccountId = tk.IDUSER;
                    ac.AccountTk = tk.TAIKHOAN;
                    ViewBag.Thongbao = "Chúc mừng đăng nhập thành công";
                    Session["Taikhoan"] = tk;
                    if (tk.TYPE==true) //true la Admin
                    {
                        return RedirectToAction("CreateAccount", "Home");   
                    }
                    else
                    {
                        TempData["mydata"] = ac;
                        return RedirectToAction("Home", "kantanji");                
                    }
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }

        public ActionResult LoginPartial()
        {
            if (Session["Taikhoan"] != null)
            {
                USER taikhoan = (USER)Session["Taikhoan"];
                ViewBag.TenDN = taikhoan.TAIKHOAN;
            }
            else
            {
                ViewBag.TenDN = "Đăng nhập";
            }

            return PartialView();
        }

        public ActionResult Logout()
        {
            Session["Taikhoan"] = null;

            return RedirectToAction("Login", "User");
        }

    }
}