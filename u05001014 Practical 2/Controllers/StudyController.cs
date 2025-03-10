using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u05001014_Practical_2.Models;

namespace u05001014_Practical_2.Controllers
{
    public class StudyController : Controller
    {
        // GET: Study
        public ActionResult Index()
        {
            List<Person> students = new List<Person>
    {
        new Person { StudentNumber = 12345678, Name = "Aabha", Surname = "Joshi", Email = "12345678@tuks.co.za", myLink = "/html/Aabha.html" },
        new Person { StudentNumber = 11223344, Name = "Cristiano", Surname = "Ronaldo", Email = "11223344@tuks.co.za", myLink = "/html/Cristiano.html" },
        new Person { StudentNumber = 55667788, Name = "David", Surname = "Beckham", Email = "55667788@tuks.co.za", myLink = "/html/David.html" },
        new Person { StudentNumber = 36912151, Name = "Virat", Surname = "Kohli", Email = "36912151@tuks.co.za", myLink = "/html/Virat.html" },
        new Person { StudentNumber = 24681012, Name = "Lionel", Surname = "Messi", Email = "24681012@tuks.co.za", myLink = "/html/Lionel.html" }
    };

            return View(students);
        }


    }
}
