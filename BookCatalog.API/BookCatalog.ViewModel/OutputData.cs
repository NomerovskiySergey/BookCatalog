using System;
using System.Collections.Generic;

namespace BookCatalog.ViewModel
{
    public class OutputData<T> where T: class
    {
        public IEnumerable<T> Data { get; set; }
    }
}
