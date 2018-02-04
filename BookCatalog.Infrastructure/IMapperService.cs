using System.Collections.Generic;

namespace BookCatalog.Infrastructure
{
    public interface IMapperService
    {
        TOut MapTo<TOut,TIn>(TIn entity) 
            where TOut : class
            where TIn: class;

        IEnumerable<TOut> MapTo<TOut, TIn>(IEnumerable<TIn> entity)
            where TOut : class
            where TIn : class;
    }
}
