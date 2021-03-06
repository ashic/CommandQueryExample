﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IDispatcher
    {
        IEnumerable<T> Get<T>(BaseQuery<T> query) where T : class;

        Task<IEnumerable<T>> GetAsync<T>(BaseAsyncQuery<T> query) where T : class;

        T GetScalar<T>(BaseScalarQuery<T> query) where T : class;

        Task<T> GetScalarAsync<T>(BaseAsyncScalarQuery<T> query) where T : class;

        void QueueCommand<T>(BaseCommand<T> command) where T : class;
    }
}