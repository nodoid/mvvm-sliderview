using Android.App;
using Android.OS;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;

namespace sliderview.droid.Views
{
    [Activity]			
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.First);
            var btnNext = FindViewById<Button>(Resource.Id.btnNext);
            var txtTitle = FindViewById<TextView>(Resource.Id.textTitle);
            txtTitle.Text = "First activity";

            btnNext.Click += delegate
            {
                OverridePendingTransition(Resource.Animation.slide_in_left, Resource.Animation.slide_out_right);
                //StartActivity(typeof(SecondView));
            };
        }
    }
}

