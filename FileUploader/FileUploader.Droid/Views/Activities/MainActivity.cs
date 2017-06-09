using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Platform;
using FileUploader.Core.ViewModels;

namespace FileUploader.Droid.Views
{
    [Activity(
        Theme = "@style/FileUploader.Droid",
        WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class MainActivity : BaseActivity<MainContainerViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.layout_activity;
    }
}
