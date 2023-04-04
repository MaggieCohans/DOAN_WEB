using DOAN_WEB.Models.KantanjiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace DOAN_WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: kantanji
        KantanjiContext kantanjiDb = new KantanjiContext();
        //Bam Mat Khau
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


        public ActionResult Index()
        {
            return View();
        }

        //-------------------List Account--------------
        public ActionResult ListAccount()
        {
            List<USER> listUser = kantanjiDb.USERs.ToList();
            return View(listUser);
        }

        //-------------------Create Account--------------
        public ActionResult CreateAccount()
        {
            return View();
        }

        //THEM USERACCOUNT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAccount(USER obj)
        {
            string tam = obj.ENPASSWORD;
            obj.ENPASSWORD = EncodePassword(EncodePassword(tam));

            ModelState.Remove("Id");
            if (!ModelState.IsValid)
            {
                return View("Create", obj);
            }
            kantanjiDb.USERs.Add(obj);
            kantanjiDb.SaveChanges();

            return RedirectToAction("ListAccount", "Home");
        }


        //-------------------Edit Account--------------
        public ActionResult Edit(int id)
        {
           
            USER user = kantanjiDb.USERs.FirstOrDefault(p => p.IDUSER == id);

            return View(user);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( USER objuser)
        {
            string tam = objuser.ENPASSWORD;
            objuser.ENPASSWORD = EncodePassword(EncodePassword(tam));
            if (ModelState.IsValid)
            {
                kantanjiDb.Entry(objuser).State = EntityState.Modified;
                kantanjiDb.SaveChanges();
                return RedirectToAction("ListAccount", "Home");

            }

            return View(objuser);
        }
        //-------------------Delete Account--------------
        public ActionResult Delete(int id)
        {
            
            USER user = kantanjiDb.USERs.FirstOrDefault(p => p.IDUSER == id);
            if (user == null)
            {
                return HttpNotFound();
            }


            return View(user);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            USER user = kantanjiDb.USERs.FirstOrDefault(p => p.IDUSER == id);
            kantanjiDb.USERs.Remove(user);
            kantanjiDb.SaveChanges();
            return RedirectToAction("ListAccount", "Home");


        }
        //-------------------Account Details--------------
        public ActionResult Details(int id)
        {

            USER user = kantanjiDb.USERs.FirstOrDefault(p => p.IDUSER == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

    }
}