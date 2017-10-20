using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Mono.Samples.Snake
{
    [Activity(Label = "مار دیوانه", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main);
            var btnEnter = FindViewById<Button>(Resource.Id.btnLogin);
            btnEnter.Click += (sender, e) =>
            {
               
                Intent intent = new Intent(this, typeof(SnakeActivity));
                StartActivity(intent);
            };

        }
    }
}