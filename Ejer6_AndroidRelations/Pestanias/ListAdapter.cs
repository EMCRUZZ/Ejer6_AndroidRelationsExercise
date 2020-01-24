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
                row = LayoutInflater.From(actualContext).Inflate(Resource.Layout.lista, null, false);
            }

            TextView vistaLista = row.FindViewById<TextView>(Resource.Id.vistaLista);
            vistaLista.Text = Lista[position];

            return row;
        }
        public override void NotifyDataSetChanged()
        {
            base.NotifyDataSetChanged();
        }

    }
}
