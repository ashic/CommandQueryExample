using System.Linq;

namespace CommandQueryExample.Common.StandardQueries
{
    public class GetAllQuery<T> : BaseQuery<T> where T : class
    {
        public GetAllQuery()
        {
            _query = s => s.AsEnumerable();
        }
    }
}