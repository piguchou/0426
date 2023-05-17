using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411018450.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(string name, string account, string password)
        {
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if (account.IsNullOrWhiteSpace())
            {
                ViewBag.accountMessage = "請輸入帳號";
            }
            if (password.IsNullOrWhiteSpace())
            {
                ViewBag.passwordMessage = "請輸入密碼";
            }
            if (!name.IsNullOrWhiteSpace()&& !account.IsNullOrWhiteSpace()&& !password.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "註冊成功";
            }
            return View();
        }

    }
}