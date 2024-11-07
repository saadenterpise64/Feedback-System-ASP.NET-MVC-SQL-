using Annual_Dinner_Feedback.Models;
using Annual_Dinner_Feedback.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace Annual_Dinner_Feedback.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FeedbackController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Display the form
        public IActionResult Create()
        {
            return View(new Feedback());
        }

        // Handle form submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Feedback feedback)
        {
            using (var connection = new SqlConnection(_context.Database.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex.Message);
                }
            }
            if (ModelState.IsValid)
            {
                // Save feedback to the database
                _context.Feedbacks.Add(feedback);
                await _context.SaveChangesAsync();  // Save changes asynchronously to the database

                return RedirectToAction("ThankYou");
            }

            // If model is invalid, redisplay form with validation messages
            return View(feedback);
        }

        // Thank You page after form submission
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
