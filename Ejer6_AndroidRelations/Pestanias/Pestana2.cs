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
    public class Pestana2 : Android.Support.V4.App.Fragment
    {
        //declaraciones de la lista
        ListView mainList;
        View v;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            //monto y lanzo la pestaña 2
             v = inflater.Inflate(Resource.Layout.Pestana2, container, false);

            
            //listview things
            mainList = v.FindViewById<ListView>(Resource.Id.mainlistview);
            ListViewAdapter adapter = new ListViewAdapter(this.Context, ClaseLista.Instance.MyList);
            mainList.Adapter = adapter;

            adapter.NotifyDataSetChanged();
            
            return v;
        }
    }
}