

namespace APIStudentAut.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {         

        }

        public System.Data.Entity.DbSet<APIStudentAut.Models.Student> Students { get; set; }
    }
}