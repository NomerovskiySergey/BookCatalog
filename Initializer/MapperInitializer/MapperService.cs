using System.Collections.Generic;
using AutoMapper;
using BookCatalog.Infrastructure;

namespace BookCatalog.Initializer.MapperInitializer
{
    public class MapperService : IMapperService
    {
        private IMapper _mapperInstance;

        #region Constructors
        public MapperService()
        {
            _mapperInstance = Mapper.Instance;
        }

        public MapperService(IMapper instance)
        {
            _mapperInstance = instance;
        }
        #endregion

        public TOut MapTo<TOut, TIn>(TIn entity) where TOut : class where TIn : class
        {
            return _mapperInstance.Map<TOut>(entity);
        }

        public IEnumerable<TOut> MapTo<TOut, TIn>(IEnumerable<TIn> entity) where TOut : class where TIn : class
        {
            return _mapperInstance.Map<IEnumerable<TOut>>(entity);
        }
    }
}
