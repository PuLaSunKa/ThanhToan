using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace layoutadmin.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DeTai()
        {
            return View();
        }

        public ActionResult ThongTin()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult SendMail()
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ngluan161121@gmail.com", "xujblbzyltgzpqbk");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("ngluan161121@gmail.com");
            mail.To.Add("taikhoanrac14789@gmail.com");
            mail.Subject = "Thông báo xác nhận";
            mail.IsBodyHtml = true;
            mail.Body = "Bạn đã được thêm vào danh sách tác giả bài báo";
            mail.Priority = MailPriority.High;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ngluan161121@gmail.com", "xujblbzyltgzpqbk");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            return RedirectToAction("Index", "Article");
        }
    }
}