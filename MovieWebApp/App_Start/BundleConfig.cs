using System.Web;
using System.Web.Optimization;

namespace MovieWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //changing the script bundle to  bundle worked fine .
            //bcoz, script bundle tries to load min version even if... bootstrap.js is written.
            bundles.Add(new Bundle("~/bundles/lib").Include(
                      "~/Scripts/jquery-{version}.js",
                      "~/Scripts/bootstrap-lumen.js"
                      //"~/scripts/bootbox.js",
                      //"~/Scripts/respond.js",
                      //"~/scripts/datatables/jquery.datatables.js",
                      //"~/scripts/datatables/datatables.bootstrap.js",
                      //"~/scripts/typeahead.bundle.js",
                      //"~/scripts/toastr.js"
                    ));
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap-lumen.css",
                  "~/Content/bootstrap-theme.css",
                  "~/content/datatables/css/datatables.bootstrap.css",
                  "~/content/typeahead.css",
                  "~/content/toastr.css",
                  "~/Content/site.css"));

            //BundleTable.EnableOptimizations = false;
            //bundles.IgnoreList.Clear();



        }
    }
}
