using System.Data.Entity;

namespace hacktonGeneradorExamen.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}