using System.Collections.Generic;
using System.Linq;
using SimpleImplementationModel.Queries;
using SimpleImplementationModel.ViewModels;

namespace SimpleImplementationModel.EFImplementation
{
    public class EfGetPeopleByFirstNameQuery : GetPeopleByFirstNameQuery
    {
        private readonly PeopleDbContext _ctx;

        public EfGetPeopleByFirstNameQuery(PeopleDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<PeopleListItem> Execute(string firstName)
        {
            return _ctx.PeopleInStorage.Where(x => x.FirstName == firstName)
                .ToList()
                .Select(x => new PeopleListItem(x.Id, string.Format("{0} {1}", x.FirstName, x.LastName)));
        }
    }
}