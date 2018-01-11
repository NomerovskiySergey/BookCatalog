using System.Collections.Generic;
using BookCatalog.DAL.Entities;
using BookCatalog.ViewModel;

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
