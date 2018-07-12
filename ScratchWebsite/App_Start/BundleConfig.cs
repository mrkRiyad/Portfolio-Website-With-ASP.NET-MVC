using System.Web;
using System.Web.Optimization;

namespace ScratchWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/Admin/adminScript").Include(
                        "~/Areas/Admin/Assets/js/popper.min.js",
                        "~/Areas/Admin/Assets/js/bootstrap.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/Admin/adminPlugin").Include(
                        "~/Areas/Admin/Assets/js/plugins/jquery-ui.custom.min.js",
                        "~/Areas/Admin/Assets/js/plugins/bootstrap-datepicker.min.js",
                        "~/Areas/Admin/Assets/js/plugins/bootstrap-notify.min.js",
                        "~/Areas/Admin/Assets/js/plugins/jquery.dataTables.min.js",
                        "~/Areas/Admin/Assets/js/plugins/dataTables.bootstrap.min.js",
                        "~/Areas/Admin/Assets/js/plugins/moment.min.js",
                        "~/Areas/Admin/Assets/js/plugins/pace.min.js",
                        "~/Areas/Admin/Assets/js/plugins/select2.min.js",
                        "~/Areas/Admin/Assets/js/plugins/sweetalert.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/Admin/adminPluginActivator").Include(
                        "~/Areas/Admin/Assets/js/main.js"
                        ));

            bundles.Add(new StyleBundle("~/Admin/AdminCss").Include(
                      "~/Areas/Admin/Assets/css/main.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

        }
    }
}
