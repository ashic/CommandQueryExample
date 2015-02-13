using System.Collections.Generic;
using SimpleImplementationModel.ViewModels;

namespace SimpleImplementationModel.Queries
{
    public interface GetPeopleByFirstNameQuery
    {
        IEnumerable<PeopleListItem> Execute(string firstName);
    }
}