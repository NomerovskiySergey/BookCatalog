using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.DAL.Entities
{
    public class TestModel: BookEM
    {
        public dynamic MyProperty { get; set; }
    }
}
