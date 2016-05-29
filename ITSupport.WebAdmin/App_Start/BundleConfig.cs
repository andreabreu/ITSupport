using System.Web;
using System.Web.Optimization;

namespace ITSupport.WebAdmin
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        "~/assets/plugins/jQuery-lib/2.0.3/jquery.min.js",
                        "~/assets/plugins/jquery-ui/jquery-ui-1.10.2.custom.min.js",
                        "~/assets/plugins/bootstrap/js/bootstrap.min.js",
                        "~/assets/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js",
                        "~/assets/plugins/blockUI/jquery.blockUI.js",
                        "~/assets/plugins/iCheck/jquery.icheck.min.js",
                        "~/assets/plugins/perfect-scrollbar/src/jquery.mousewheel.js",
                        "~/assets/plugins/perfect-scrollbar/src/perfect-scrollbar.js",
                        "~/assets/plugins/less/less-1.5.0.min.js",
                        "~/assets/plugins/jquery-cookie/jquery.cookie.js",
                        "~/assets/js/main.js"));

           

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/plugins/bootstrap/css/bootstrap.min.css",
                      "~/Assets/plugins/font-awesome/css/font-awesome.min.css",
                      "~/assets/fonts/style.css",
                      "~/assets/css/main.css",
                      "~/assets/css/main-responsive.css",
                      "~/assets/plugins/iCheck/skins/all.css",
                      "~/assets/plugins/bootstrap-colorpalette/css/bootstrap-colorpalette.css",
                      "~/assets/plugins/perfect-scrollbar/src/perfect-scrollbar.css",
                      "~/assets/css/theme_light.css"));



            


        }
    }
}
