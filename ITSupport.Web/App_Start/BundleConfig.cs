using System.Web;
using System.Web.Optimization;

namespace ITSupport.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-treeview.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        "~/Scripts/waiting-for.js",
                        "~/Scriptsalert-dialog.js",
                        "~/Scripts/datatables.js",
                        "~/Scripts/typeahead.js",
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/jasny-bootstrap.min.js",
                        "~/Scripts/chosen.jquery.min.js"));

   

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/datatables.css",
                      "~/Content/gridview-pagination.css",
                      "~/Content/login.css",
                      "~/Content/submenu.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-treeview.min.css",
                      "~/Content/typehead.css",
                      "~/Content/datepicker.css",
                      "~/Content/jasny-bootstrap.min.css",
                      "~/Content/chosen.css"));
        }
    }
}
