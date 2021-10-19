using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hobbyHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace hobbyHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Context _context;
        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("User_id") == null)
            {
                return View();
            }
            ViewBag.user = _context.User.SingleOrDefault(d => d.id == HttpContext.Session.GetInt32("User_id"));
            ViewBag.Hobbies = _context.Hobby
                .Include(d => d.User_)
                .ThenInclude(d => d.User)
                .OrderByDescending(d => d.User_.Count)
                .ToList();
            ViewBag.topNovice = _context.Hobby
                .Include(d => d.User_)
                .Where(d => d.User_.Any(d => d.level == "Novice"))
                .OrderByDescending(d => d.User_.Count)
                .Take(2);
            ViewBag.topIntermediate = _context.Hobby
                .Include(d => d.User_)
                .Where(d => d.User_.Any(d => d.level == "Intermediate"))
                .OrderByDescending(d => d.User_.Count)
                .Take(2);
            ViewBag.topExpert = _context.Hobby
                .Include(d => d.User_)
                .Where(d => d.User_.Any(d => d.level == "Expert"))
                .OrderByDescending(d => d.User_.Count)
                .Take(2);
            return View("landingPage");
        }

        [HttpPost("submitUser")]
        public IActionResult submitUser(User user)
        {
            var newUser = _context.User.SingleOrDefault(u => u.username == user.username);
            if (newUser != null)
            {
                ModelState.AddModelError("username", "That username is already in use!");
            }
            if (ModelState.IsValid)
            {
                PasswordHasher<User> hash = new PasswordHasher<User>();
                user.password = hash.HashPassword(user, user.password);
                _context.Add(user);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("User_id", user.id);
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpPost("loginUser")]
        public IActionResult loginUser(loginUser user)
        {
            var newUser = _context.User.SingleOrDefault(u => u.username == user.loginUsername);
            var hash = new PasswordHasher<User>();
            if (newUser == null)
            {
                ModelState.AddModelError("loginUsername", "No email found in database!");
            }
            else if (hash.VerifyHashedPassword(newUser, newUser.password, user.loginPass) == 0)
            {
                ModelState.AddModelError("loginPass", "Incorrect password!");
            }
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetInt32("User_id", newUser.id);
                return RedirectToAction("Index");
            }
            return View("Index");

        }

        [HttpGet("newHobby")]
        public IActionResult newHobby()
        {
            ViewBag.user = _context.User.SingleOrDefault(d => d.id == HttpContext.Session.GetInt32("User_id"));
            return View();
        }

        [HttpPost]
        public IActionResult submitHobby(Hobby hobby)
        {
            var newHobby = _context.Hobby.SingleOrDefault(d => d.name == hobby.name);
            if (newHobby != null)
            {
                ModelState.AddModelError("name", "Must be a new Hobby!");
            }
            if (ModelState.IsValid)
            {
                _context.Add(hobby);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.user = _context.User.SingleOrDefault(d => d.id == HttpContext.Session.GetInt32("User_id"));
            return View("newHobby");
        }

        [HttpGet("view/{id}")]
        public IActionResult view(int id)
        {
            Hobby hobby = _context.Hobby
                .Include(d => d.User_)
                .ThenInclude(d => d.User)
                .SingleOrDefault(d => d.id == id);
            ViewBag.user = _context.User.SingleOrDefault(d => d.id == HttpContext.Session.GetInt32("User_id"));
            return View(hobby);
        }

        [HttpPost("add/{id}")]
        public IActionResult add(int id, association assoc)
        {
            assoc.id = _context.association.Select(a => a.id + 1).OrderByDescending(a => a).ToArray()[0];
            assoc.Hobby_id = id;
            assoc.User_id = (int)HttpContext.Session.GetInt32("User_id");
            _context.association.Add(assoc);
            _context.SaveChanges();
            return RedirectToAction("view", new { id = id });
        }
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
