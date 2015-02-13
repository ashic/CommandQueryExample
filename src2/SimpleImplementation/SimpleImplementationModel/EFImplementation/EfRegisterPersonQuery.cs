using SimpleImplementationModel.Queries;

namespace SimpleImplementationModel.EFImplementation
{
    public class EfRegisterPersonQuery : RegisterPersonQuery
    {
        private readonly PeopleDbContext _ctx;

        public EfRegisterPersonQuery(PeopleDbContext ctx)
        {
            _ctx = ctx;
        }

        public int Execute(string firstName, string lastName)
        {
            var p = new PersonInStorage() {FirstName = firstName, LastName = lastName};
            _ctx.PeopleInStorage.Add(p);
            _ctx.SaveChanges();

            return p.Id;
        }
    }
}