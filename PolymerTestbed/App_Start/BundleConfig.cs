using System.Web.Optimization;
using Scripts = Links.Scripts;

namespace PolymerTestbed
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/polymer")
                //.IncludeDirectory("~/Content/bower_components/webcomponentsjs", "*.js", true)
                .Include("~/Content/bower_components/webcomponentsjs/webcomponents.min.js"));

            bundles.Add(new ScriptBundle("~/polymerTestbed/webComponents")
                .IncludeDirectory("~/Scripts/polymerTestbed", "*.js", true));
        }
    }
}