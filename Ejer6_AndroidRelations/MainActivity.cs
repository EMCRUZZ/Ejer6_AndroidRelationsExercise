using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using AlertDialog = Android.App.AlertDialog;

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

            // Mis ID

            inputTexto = FindViewById<EditText>(Resource.Id.inputTexto);

            Button idboton = FindViewById<Button>(Resource.Id.idboton1);
            idboton.Click += Idboton_Click;

            Button idboton2 = FindViewById<Button>(Resource.Id.idboton2);
            idboton2.Click += Idboton_Click;

            Button idboton3 = FindViewById<Button>(Resource.Id.idboton3);
            idboton3.Click += Idboton_Click;

            Button idboton4 = FindViewById<Button>(Resource.Id.idboton4);
            idboton4.Click += Idboton_Click;

            Button idboton5 = FindViewById<Button>(Resource.Id.idboton5);
            idboton5.Click += Idboton_Click;

            Button idboton6 = FindViewById<Button>(Resource.Id.idboton6);
            idboton6.Click += Idboton_Click;

            Button idboton7 = FindViewById<Button>(Resource.Id.idboton7);
            idboton7.Click += Idboton_Click;

            Button idboton8 = FindViewById<Button>(Resource.Id.idboton8);
            idboton8.Click += Idboton_Click;

            Button idboton9 = FindViewById<Button>(Resource.Id.idboton9);
            idboton9.Click += Idboton_Click;

            Button idboton0 = FindViewById<Button>(Resource.Id.idboton0);
            idboton0.Click += Idboton_Click;

            var idbotonOK = FindViewById<Button>(Resource.Id.idbotonOK);
            idbotonOK.Click += IdbotonOK_Click;
            /*
            //ID COMBOBOX
            Spinner comboboxAndroid = FindViewById<Spinner>(Resource.Id.comboboxAndroid);

            comboboxAndroid.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(this,0,2);
          //var adapter = ArrayAdapter.CreateFromResource (this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            comboboxAndroid.Adapter = adapter;
            */
        }
        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string toast = string.Format("El genero seleccionado tiene numero: {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
        private void IdbotonOK_Click(object sender, EventArgs e)
        {
            if (inputTexto.Text.ToString().Equals("1234"))
            {
                //invoco la siguiente pantalla
                guardarSettings();//guardo el evento de que se haya conseguido loguear
                //manera rechulona de invocar a la siguiente pantalla
                StartActivity(typeof(LogicaPantallaAceptado));
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
            recuperarSettings();
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

        protected void guardarSettings()
        {
            //Guardar datos
            var preferencias = Application.Context.GetSharedPreferences("MyApp", Android.Content.FileCreationMode.Private);
            var editorPreferencias = preferencias.Edit();
            editorPreferencias.PutBoolean("inicioHecho",true);
            editorPreferencias.Commit();
        }

        protected void recuperarSettings()
        {// Funcion llamada desde OnCreate
            //recuperar datos 
            var preferencias = Application.Context.GetSharedPreferences("MyApp", Android.Content.FileCreationMode.Private);
            bool editorPreferencias = preferencias.GetBoolean("inicioHecho", false);
            if (editorPreferencias==true)
            {
                //invoco la siguiente pantalla de manera PRO gracias a la envoltura que le creo con la clase
                StartActivity(typeof(LogicaPantallaAceptado));
            }
        }

    }
}

