using System.Globalization;
using System.Threading;
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace CrashingChart.Droid
{
    [Activity(Label = "CrashingChart", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru"); // settings culture

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}