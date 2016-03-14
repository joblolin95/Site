using System.Web.Optimization;

namespace JosephOlin.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
#if !DEBUG
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
#endif

            bundles.Add(new StyleBundle("~/bundles/bootstrapcss", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css")
                .Include("~/Content/bootstrap/bootstrap.css")
                );

            bundles.Add(new StyleBundle("~/bundles/fontawesomecss", "//maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css")
                .Include("~/Content/font-awesome-4.5.0/css/font-awesome.css")
                );
            
            //bundles.Add(new StyleBundle("~/bundles/commoncss")
            //    .Include("~/Content/professional.css", new CssRewriteUrlTransform())
            //    .Include("~/fonts/googleFonts.css")
            //    );

            bundles.Add(new StyleBundle("~/bundles/carme", "//fonts.googleapis.com/css?family=Carme")
               .Include("~/Content/Fonts/carme.css"));

            bundles.Add(new StyleBundle("~/bundles/yesteryear", "//fonts.googleapis.com/css?family=Yesteryear")
                .Include("~/Content/Fonts/yesteryear.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/jqueryjs", "//ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js")
                .Include("~/Scripts/jquery-2.2.1.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js")
                );            
        }
    }
}