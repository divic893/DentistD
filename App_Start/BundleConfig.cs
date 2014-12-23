using System.Web;
using System.Web.Optimization;

namespace DentistD
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {


            /// JS


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"

                       ));
            bundles.Add(new ScriptBundle("~/bundles/GlobalJS").Include(
                "~/Content/assets/js/application.js",
                "~/Content/assets/js/bootstrap.min.js",
                "~/Content/assets/js/html5shiv.js",
                "~/Content/assets/js/prettify.js",
                "~/Content/assets/js/jquery-1.10.2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/applicatonJS").Include(
                "~/Content/assets/js/application/application-blog-list.min.js",
                "~/Content/assets/js/application/application.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/AppsourceJS").Include(
                "~/Content/assets/js/application/source/application-blog-list.js",
                "~/Content/assets/js/application/source/application.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapJS").Include(
                     "~/Content/assets/js/bootstrap/source/bootstrap.js",
                     "~/Content/assets/js/bootstrap/bootstrap.min.js",
                     "~/Content/assets/js/bootstrap/html5shiv.js"));


            bundles.Add(new ScriptBundle("~/bundles/pluginsJS").Include(
                "~/content/assets/js/plugins/jquery.bxslider.min.js",
                "~/content/assets/js/plugins/jquery.centralized.js",
                "~/content/assets/js/plugins/jquery.fixedonlater.min.js",
                "~/content/assets/js/plugins/jquery.fixedonlater.min.js",
                "~/content/assets/js/plugins/jquery.hashloader.min.js",
                "~/content/assets/js/plugins/jquery.mixitup.min.js",
                "~/content/assets/js/plugins/jquery.nav.min.js",
                "~/content/assets/js/plugins/jquery.parallax-1.1.3.min.js",
                "~/content/assets/js/plugins/jquery.responsivevideos.min.js",
                "~/content/assets/js/plugins/jquery.scrollTo.min.js",
                "~/content/assets/js/plugins/jquery.tweet.min.js",
                "~/content/assets/js/plugins/jquery.tweetCarousel.min.js"
                     ));
            bundles.Add(new ScriptBundle("~/bundles/pluginsSourceJS").Include(
                "~/Content/assets/js/plugins/source/jquery.bxslider.js",
                "~/Content/assets/js/plugins/source/jquery.centralized.js",
                "~/Content/assets/js/plugins/source/jquery.fixedonlater.js",
                "~/Content/assets/js/plugins/source/jquery.hashloader.js",
                "~/Content/assets/js/plugins/source/jquery.mixitup.js",
                "~/Content/assets/js/plugins/source/jquery.nav.js",
                "~/Content/assets/js/plugins/source/jquery.parallax-1.1.3.js",
                "~/Content/assets/js/plugins/source/jquery.responsivevideos.js",
                "~/Content/assets/js/plugins/source/jquery.scrollTo-1.4.3.1.js",
                "~/Content/assets/js/plugins/source/jquery.tweet.js",
                "~/Content/assets/js/plugins/source/jquery.tweetCarousel.js"

                ));
         


            /// CSS
            bundles.Add(new StyleBundle("~/Content/cssGlobal").Include(
                      "~/Content/assets/style/bootstrap.css",
                      "~/Content/assets/style/docs.css",
                      "~/Content/assets/style/prettify.css"
                      ));


            BundleTable.EnableOptimizations = true;
        }
    }
}
