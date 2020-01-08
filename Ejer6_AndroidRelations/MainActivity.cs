using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Ejer6_AndroidRelations
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText inputTexto;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            //Mis ID

            inputTexto = FindViewById<EditText>(Resource.Id.inputTexto);

            Button idboton = FindViewById<Button>(Resource.Id.idboton1);
            idboton.Click += Idboton_Click;

            /* Al igual que los otros finds este tampoco me encuentra el id en el resource.id 
             
            var idbotonOK = FindViewById<Button>(Resource.Id.idbotonOK);
            idboton.Click += IdbotonOK_Click;
            */

            //he omitido de esta rama los otros FindViewById comentados mientras que no sepa el porque no funcionan.
        }

        private void IdbotonOK_Click(object sender, EventArgs e)
        {
            if (inputTexto.Text.ToString().Equals("1234"))
            {
                //Creo y levanto la siguiente pantalla de codigo correcto
            }
            else
            {
                //cambio el color a rojo si esta mal
                inputTexto.SetTextColor(Android.Graphics.Color.Red);
            }
        }

        private void Idboton_Click(object sender, EventArgs e)
        {
            //obtengo el numero de boton que sea pulsado para poder reutilizar la función
            Button temp = (Button)sender;
            inputTexto.Text = inputTexto.Text.ToString() + temp.Text.ToString();
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

