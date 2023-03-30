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
        EditText txtName;
        EditText txtLastName ;
        EditText txtNumber ;
        EditText txtEmail;
        EditText txtNeed ;
        Button btnHome ;
        Button btnSend;

        protected override void OnCreate(Bundle savedInstanceState)
        {
             base.OnCreate(savedInstanceState);
             SetContentView(Resource.Layout.Contact);
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
            try
            {
                //cuando las variables estan declaradas dentro de un metodo protegido por ende solo se pueden usar en ese método para ser utilizadas en otros metodos 
               // deben ser declaradas en el método público
                //El String en mayuscula es para llamar la clase y el string en minuscula crear la variable
                if (!string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    new Auxiliar().GuardarMensaje(new contact()
                    {
                        Name = txtName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        Number = (int)double.Parse( txtNeed.Text.Trim()),
                        Email = txtEmail.Text.Trim(),
                        Need = txtNeed.Text.Trim()
                    });

                    Toast.MakeText(this, "Message Send", ToastLength.Long).Show();
                    //Para vaciar los campos
                     txtName.Text = "";
                     txtLastName.Text = "";
                     txtNumber.Text = "";
                     txtEmail.Text = "";
                     txtNeed.Text = "";
                }
                else
                {
                    Toast.MakeText(this, "Please enter the required fields",ToastLength.Long ).Show();
                }
            }
            catch(System.Exception ex)
            {
                Toast.MakeText(this, ex.ToString(),ToastLength.Short).Show();
            }

            }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var layout_home = new Intent(this, typeof(MainActivity));
            StartActivity(layout_home);
            //throw new NotImplementedException();
        }
    }
}