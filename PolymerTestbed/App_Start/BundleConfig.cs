using System.Web.Optimization;
using Scripts = Links.Scripts;

namespace PolymerTestbed
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/utility")
                .Include("~/Scripts/jquery/jquery-2.1.4.min.js")
                .Include("~/Scripts/lodash/lodash.min.js"));

            bundles.Add(new ScriptBundle("~/polymer")
                .Include("~/Content/bower_components/webcomponentsjs/webcomponents.min.js"));

            bundles.Add(new ScriptBundle("~/polymerTestbed/webComponents")
                .IncludeDirectory("~/Scripts/polymerTestbed", "*.js", true));
        }
    }
}