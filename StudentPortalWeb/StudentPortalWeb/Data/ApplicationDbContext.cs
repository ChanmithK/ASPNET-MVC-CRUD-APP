using Microsoft.EntityFrameworkCore;
using StudentPortalWeb.Models.Entities;

namespace StudentPortalWeb.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{
			
		}

		//In here Student means the entitity name
		//Students means the table name
		public DbSet<Student> Students { get; set; }

    }
}

