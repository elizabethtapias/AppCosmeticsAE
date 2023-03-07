using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCosmeticsAE
{
    [Activity(Label = "Services")]
    public class Services : Activity
    {
        
        Button btnHome;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
         
            btnHome = FindViewById<Button>(Resource.Id.btnHome);

            btnHome.Click += BtnHome_Click;
            // Create your application here
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var layout_home = new Intent(this, typeof(Home));
            StartActivity(layout_home);
            //throw new NotImplementedException();
        }
    }
}