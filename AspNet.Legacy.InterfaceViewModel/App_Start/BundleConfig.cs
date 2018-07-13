using System.Web.Optimization;

namespace AspNet.Legacy.InterfaceViewModel
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/bootstrap").Include("~/Scripts/bootstrap.bundle.js"));
            bundles.Add(new StyleBundle("~/css/bootstrap").Include("~/Content/bootstrap.css"));
        }
    }
}