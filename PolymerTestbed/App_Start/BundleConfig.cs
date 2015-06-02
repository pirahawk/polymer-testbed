using System.Web.Optimization;

namespace PolymerTestbed
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/polymer")
                .Include("~/Content/bower_components/webcomponentsjs/webcomponents-lite.js"));
        }
    }
}