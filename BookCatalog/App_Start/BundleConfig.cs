using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BookCatalog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Datatable/js").Include("~/Scripts/DataTables/datatables.min.js"));
            bundles.Add(new StyleBundle("~/Datatable/css").Include("~/Scripts/DataTables/datatables.min.css"));
        }
    }
}