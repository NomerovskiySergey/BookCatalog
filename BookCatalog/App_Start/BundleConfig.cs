using System.Web.Optimization;

namespace BookCatalog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/global/js")
                .Include("~/Scripts/jquery-1.10.2.min.js")
                .Include("~/Scripts/bootstrap.min.js")
                .Include("~/Scripts/modernizr-2.6.2.js")
                .Include("~/Scripts/moment.js")
                .Include("~/Scripts/knockout-3.4.2.js")
                .Include("~/Scripts/knockout-mapping.js")
                .Include("~/Scripts/knockout.validation.min.js")
                .Include("~/Scripts/DataTables/datatables.min.js")
                .Include("~/Scripts/bootstrap-select.js")
                .Include("~/Scripts/bootstrap-datepicker.min.js"));

            bundles.Add(new ScriptBundle("~/global/css")
                .Include("~/Content/Site.css")
                .Include("~/Content/bootstrap.min.css")
                .Include("~/Scripts/DataTables/datatables.min.css")
                .Include("~/Content/bootstrap-select.min.css")
                .Include("~/Content/bootstrap-datetimepicker.min.css"));

            bundles.Add(new ScriptBundle("~/book-view/js").Include("~/Scripts/Book/book.js"));
            bundles.Add(new ScriptBundle("~/author-view/js").Include("~/Scripts/Author/author.js"));
        }
    }
}