using Annual_Dinner_Feedback.Models;
using Microsoft.EntityFrameworkCore;

namespace Annual_Dinner_Feedback.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
