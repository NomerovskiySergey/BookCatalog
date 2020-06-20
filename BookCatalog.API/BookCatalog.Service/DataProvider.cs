using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalog.Service
{
    public class DataProvider : IDataProvider
    {
        public string Get()
        {
            return "TestData";
        }
    }
}
