using System.Web;
using System.Web.Optimization;

namespace Phage
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Content/jquery.min.js",
                        "~/Content/bootstrap-3.3.7-dist/js/bootstrap.min.js"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-3.3.7-dist/css/bootstrap.min.css", 
                      "~/Content/site.css"));
        }
    }
}
