using System;
using BookCatalog.Infrastructure.Business;
using BookCatalog.Initializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Unity
{
    [TestClass]
    public class UnityTests
    {
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void UnityResolve_CreateBookDM_NonImplementException()
        {
            var webCtx = new WebContext(string.Empty);

            var bookDM = webCtx.Factory.GetService<IBookDM>(webCtx);

            var result = bookDM.GetBook(int.MaxValue);
        }
    }
}
