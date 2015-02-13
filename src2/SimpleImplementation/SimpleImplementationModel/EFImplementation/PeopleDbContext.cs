using System.Data.Entity;

namespace SimpleImplementationModel.EFImplementation
{
    //If we wanted we could have this as an interface
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext(string connectionStringName) : base(connectionStringName)
        {
            
        }

        public DbSet<PersonInStorage> PeopleInStorage { get; set; }         
    }
}