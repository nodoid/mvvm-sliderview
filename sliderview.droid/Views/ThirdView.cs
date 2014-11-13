using Android.App;
using Android.OS;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;
using sliderview.ViewModels;

namespace sliderview.droid.Views
{
    [Activity(Label = "ThirdView")]			
    public class ThirdView: MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Third);
            var btnNext = FindViewById<Button>(Resource.Id.btnNext);
            var txtTitle = FindViewById<TextView>(Resource.Id.textTitle);
            txtTitle.Text = "Third activity";
            btnNext.Click += delegate
            {
                OverridePendingTransition(Resource.Animation.slide_out_left, Resource.Animation.slide_in_right);
                //Finish();
            };
        }
    }
}

