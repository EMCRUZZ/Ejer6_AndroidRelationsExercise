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

namespace Ejer6_AndroidRelations.Pestanias
{
    public class ListViewAdapter : BaseAdapter<string>
    {
        public List<string> Lista;
        private Context actualContext;

        public ListViewAdapter(Context context, List<string> items)
        {
            Lista = items;
            actualContext = context;
        }

        public override string this[int position]
        {
            get
            {
                return Lista[position];
            }
        }

        public override int Count
        {
            get
            {
                return Lista.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(actualContext).Inflate(Resource.Layout.Pestana2, null, false);
            }
            /*
            TextView nombre = row.FindViewById<TextView>(Resource.Id.textView1);
            nombre.Text = Lista[position].nombre;
            TextView apellido = row.FindViewById<TextView>(Resource.Id.textView2);
            apellido.Text = Lista[position].apellido;
            TextView sexo = row.FindViewById<TextView>(Resource.Id.textView3);
            sexo.Text = Lista[position].sexo;
            TextView id = row.FindViewById<TextView>(Resource.Id.textView4);
            id.Text = ""+Lista[position].id;
			*/
            return row;
        }
        public override void NotifyDataSetChanged()
        {
            base.NotifyDataSetChanged();
        }

    }
}
