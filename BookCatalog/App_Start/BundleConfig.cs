﻿using System.Web.Optimization;

namespace BookCatalog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Datatable/js").Include("~/Scripts/DataTables/datatables.min.js"));
            bundles.Add(new StyleBundle("~/Datatable/css").Include("~/Scripts/DataTables/datatables.min.css"));

            bundles.Add(new ScriptBundle("~/bootstrap-select/js").Include("~/Scripts/bootstrap-select.min.js"));
            bundles.Add(new StyleBundle("~/bootstrap-select/css").Include("~/Content/bootstrap-select.min.css"));

            bundles.Add(new ScriptBundle("~/bootstrap-datetimepicker/js").Include("~/Scripts/bootstrap-datetimepicker.min.js"));
            bundles.Add(new StyleBundle("~/bootstrap-datetimepicker/css").Include("~/Content/_bootstrap-datetimepicker.less"));





            bundles.Add(new ScriptBundle("~/book-view/js").Include("~/Scripts/Book/createBook.js"));
        }
    }
}