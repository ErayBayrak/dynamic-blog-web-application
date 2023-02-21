using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.useremail = usermail;
            Context context = new Context();
            var username = context.Writers.Where(x => x.WriterMail == usermail).Select(x=>x.WriterName).FirstOrDefault();
            ViewBag.un = username;
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            Context context = new Context();
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userID = context.Writers.Where(x => x.WriterMail == usermail).Select(x => x.WriterID).FirstOrDefault();
            var writerProfile = writerManager.GetById(userID);
            return View(writerProfile);
        }
       
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult validationResult = validationRules.Validate(writer);
            if (validationResult.IsValid)
            {
                writerManager.TUpdate(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach(var x in validationResult.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage writer)
        {
            Writer writer1 = new Writer();
            if (writer.WriterImage != null)
            {
                var extension = Path.GetExtension(writer.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                writer.WriterImage.CopyTo(stream);
                writer1.WriterImage = newImageName;
            }
            writer1.WriterMail = writer.WriterMail;
            writer1.WriterName = writer.WriterName;
            writer1.WriterPassword = writer.WriterPassword;
            writer1.WriterStatus = true;
            writer1.WriterAbout = writer.WriterAbout;
            writerManager.TAdd(writer1);
            return RedirectToAction("Index","Dashboard");
        }
    }
}
