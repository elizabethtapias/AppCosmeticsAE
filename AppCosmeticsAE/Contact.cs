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
    [Activity(Label = "Contact")]
    public class Contact : Activity
    {
        EditText txtContact;
        EditText txtName;
        EditText txtLastName;
        EditText txtNumber;
        EditText txtEmail;
        EditText txtNeed;
        Button btnHome;
        Button btnSend;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            txtContact = FindViewById<EditText>(Resource.Id.txtContact);
            txtName = FindViewById<EditText>(Resource.Id.txtName);
            txtLastName = FindViewById<EditText>(Resource.Id.txtLastName);
            txtNumber = FindViewById<EditText>(Resource.Id.txtNumber);
            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtNeed = FindViewById<EditText>(Resource.Id.txtNeed);
            btnHome = FindViewById<Button>(Resource.Id.btnHome);
            btnSend = FindViewById<Button>(Resource.Id.btnSend);

            btnHome.Click += BtnHome_Click;
            btnSend.Click += BtnSend_Click;
            // Create your application here
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var layout_home = new Intent(this, typeof(MainActivity));
            StartActivity(layout_home);
            //throw new NotImplementedException();
        }
    }
}