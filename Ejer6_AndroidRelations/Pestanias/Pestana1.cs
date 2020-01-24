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
using Ejer6_AndroidRelations.Pestanias;
using Ejer6_AndroidRelations.Resources.layout;

namespace Ejer6_AndroidRelations
{
   public class Pestana1 : Android.Support.V4.App.Fragment
    {
        //declaraciones de la lista
        string filaFormateada = string.Empty;
        ListView mainList;
        View v;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            v = inflater.Inflate(Resource.Layout.Pestana1,container,false);
            
            string genero = " ";

            //referencias de ids
            EditText edNombre = v.FindViewById<EditText>(Resource.Id.idNombre);
            EditText edApellido = v.FindViewById<EditText>(Resource.Id.idApellido);
            Switch switchGenero = v.FindViewById<Switch>(Resource.Id.switchGenero);
            
            if (switchGenero.Activated.ToString().Equals(true))
            {
                genero = "hombre";
            }
            else
            {
                genero = "Mujer";
            }
            
            //Creacion del registro
            filaFormateada = $"Nombre: {edNombre.Text}, Apellido: {edApellido.Text}, Genero: {genero}";

            //ID del boton que realiza la ejecucion de carga de datos en la lista
            Button botonCargar = v.FindViewById<Button>(Resource.Id.botonCargar);
            botonCargar.Click += botonCargaLista;

            return v;
        }

        //Metodo que rellena la lista al pulsar el boton de añadir en pestaña 1
        private void botonCargaLista(object sender, EventArgs e)
        {
            ClaseLista.Instance.MyList.Add(filaFormateada);
        }
    }
}