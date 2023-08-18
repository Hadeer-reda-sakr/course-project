using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using presentence.Context;
using presentence.Migrations;
using presentence.Repository;
using ServiceLayer.CourseService;
using Web.ViewModel;

namespace Web.Controllers
{
    public class CourseController : Controller


    {
       //private readonly ICourseService courseService;

       private ICourseService _courseService;

        private readonly UserManager<ApplicationUser> _userManager;

       private    PresistanceContext  _context;

        public CourseController(ICourseService courseService , UserManager<ApplicationUser> userManager, PresistanceContext context)
        {
            _courseService = courseService;

            _userManager = userManager;



        }

        //public CourseController(PresistanceContext context)
        //{
        //    _context = context;


        //}

        // GET: CourseController
        public   IActionResult Index()
        {
            var course =   _courseService.GetCourses();

            
            return View(course);
        }

        // GET: CourseController/Details/5
        
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }

           
            var coursedetails = _courseService.GetCourse(id);

            if (coursedetails == null)
            {
                return NotFound();
            }
            return View("Details", coursedetails);
        }
        [Authorize(Roles = "Admin")]
        // GET: CourseController/Create
        public ActionResult Add()
        {

            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(CourseViewModel courseViewModel)
        {
            var Admin = _userManager.GetUserAsync(User);
            var course = new Course
            {
                Id = courseViewModel.Id,
                Appointment = courseViewModel.Appointment,
                Title = courseViewModel.Title,
                Details = courseViewModel.Details,
                CreatedAt = DateTime.Now,
                IsActive = true,
                CreatedBy = Admin.Id
                

            };
            _courseService.InsertCourse(course);



             return RedirectToAction(nameof(Index));
          
        }



        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {

            if(id==null)
                return BadRequest();

           
            var admin = _courseService.GetCourse(id);


            if (admin==null)
                return NotFound();

          

            return View("Edit",admin);
        }

        //POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Course model)

        {

            var admin = _courseService.GetCourse(model.Id);


            if (admin == null)
                return NotFound();


            model.Title = admin.Title;
            model.Appointment = admin.Appointment;
            model.CreatedAt = admin.CreatedAt;
            model.IsActive = admin.IsActive;
            model.CreatedBy = admin.CreatedBy;

            
            _courseService.UpdateCourse(model);
            //_context.SaveChanges(); 


            return View(model);

        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Course model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View("Edit", model);
        //    }
        //    var admin = await _userManager.GetUserAsync(User);
        //    var course = _courseService.GetCourse(model.Id);
        //    if (course == null)
        //        return NotFound();
        //    course.Title = model.Title;
        //    course.Appointment = model.Appointment;
        //    course.Details = model.Details;
        //    course.ModifiedAt = model.ModifiedAt;
        //    course.ModifiedBy = model.ModifiedBy;

        //    _courseService.UpdateCourse(course);
        //    _context.SaveChanges();

        //    return View(model);
        //  //  return RedirectToAction(nameof(Index));
        //}

        // GET: CourseController/Delete/5
        public ActionResult Delete(CourseViewModel course)
        {
            

            var admin = _courseService.GetCourse(course.Id);

            
            if (admin==null )
                return NotFound();

            return View("Delete",admin);
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            if (id == null)
                return BadRequest();
             var admin = _courseService.GetCourse(id);
             
            
               _courseService.DeleteCourse(admin.Id);
            //_context.SaveChanges();

            return RedirectToAction(nameof(Index));
           
          
               
            
        }
    }
}
