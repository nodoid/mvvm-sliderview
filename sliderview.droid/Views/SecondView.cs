using Android.App;
using Android.OS;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;

namespace sliderview.droid.Views
{
    [Activity(Label = "SecondView")]			
    public class SecondView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Second);
            var btnNext = FindViewById<Button>(Resource.Id.btnNext);
            var btnBack = FindViewById<Button>(Resource.Id.btnBack);
            var txtTitle = FindViewById<TextView>(Resource.Id.textTitle);
            txtTitle.Text = "Second activity";

            btnNext.Click += delegate
            {
                OverridePendingTransition(Resource.Animation.slide_in_left, Resource.Animation.slide_out_right);
                //StartActivity(typeof(ThirdView));
            };

            btnBack.Click += delegate
            {
                OverridePendingTransition(Resource.Animation.slide_out_left, Resource.Animation.slide_in_right);
                //Finish();
            };
        }
    }
}

