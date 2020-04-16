using System.Web.Optimization;

namespace BookCatalog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/global/js")
                .Include("~/Scripts/jquery-3.4.1.min.js")
                .Include("~/Scripts/bootstrap.min.js")
                .Include("~/Scripts/modernizr-2.8.3.js")
                .Include("~/Scripts/moment.js")
                .Include("~/Scripts/knockout-3.4.2.js")
                .Include("~/Scripts/knockout-mapping.js")
                .Include("~/Scripts/knockout.validation.min.js")
                .Include("~/Scripts/DataTables/datatables.min.js")
                .Include("~/Scripts/bootstrap-select.js")
                .Include("~/Scripts/bootstrap-datepicker.min.js")
                .Include("~/Scripts/toastr.min.js"));

            bundles.Add(new Bundle("~/global/css")
                .Include("~/Content/Site.css")
                .Include("~/Content/bootstrap.min.css")
                .Include("~/Scripts/DataTables/datatables.min.css")
                .Include("~/Content/bootstrap-select.min.css")
                .Include("~/Content/bootstrap-datetimepicker.min.css")
                .Include("~/Content/toastr.min.css"));

            bundles.Add(new Bundle("~/book-view/js").Include("~/Scripts/Book/book.js"));
            bundles.Add(new Bundle("~/author-view/js").Include("~/Scripts/Author/author.js"));
            bundles.Add(new Bundle("~/main-page/js").Include("~/Scripts/MainPage/main-page.js"));
        }
    }
}