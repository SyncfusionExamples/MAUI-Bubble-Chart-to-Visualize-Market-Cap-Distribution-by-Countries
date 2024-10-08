using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Dow30
{
    [Activity(Theme = "@style/Maui.SplashTheme" ,MainLauncher = true, ScreenOrientation = ScreenOrientation.Landscape, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}
