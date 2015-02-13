using System.Data.Entity;

namespace SimpleImplementationModel.EFImplementation
{
    public class PeopleDbContextInitialiser : DropCreateDatabaseIfModelChanges<PeopleDbContext>
    {
        protected override void Seed(PeopleDbContext context)
        {
            context.PeopleInStorage.Add(new PersonInStorage { FirstName = "Alan", LastName = "Stevens" });
            context.PeopleInStorage.Add(new PersonInStorage { FirstName = "Alan", LastName = "Turing" });
            context.PeopleInStorage.Add(new PersonInStorage { FirstName = "Ashic", LastName = "Mahtab" });

            context.SaveChanges();
        }
    }
}