using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidRotation1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
   public class rotation : AppCompatActivity 
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var rl = new RelativeLayout(this);

            // set layout parameters
            var layoutParams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.FillParent);
            rl.LayoutParameters = layoutParams;

            // get the initial orientation
            var surfaceOrientation = WindowManager.DefaultDisplay.Rotation;
            // create layout based upon orientation
            RelativeLayout.LayoutParams tvLayoutParams;

            if (surfaceOrientation == SurfaceOrientation.Rotation0 || surfaceOrientation == SurfaceOrientation.Rotation180)
            {
                tvLayoutParams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);
            }
            else
            {
                tvLayoutParams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);
                tvLayoutParams.LeftMargin = 100;
                tvLayoutParams.TopMargin = 100;
            }

            // create TextView control
            var tv = new TextView(this);
            tv.LayoutParameters = tvLayoutParams;
            tv.Text = "Programmatic layout";

            // add TextView to the layout
            rl.AddView(tv);

            // set the layout as the content view
            SetContentView(rl);
        }
    }
}