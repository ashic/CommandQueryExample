using System.Collections;

namespace SimpleImplementationModel.Queries
{
    public interface RegisterPersonQuery
    {
        int Execute(string firstName, string lastName);
    }
}