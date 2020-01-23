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

namespace Ejer6_AndroidRelations
{
    public class Pestana2 : Android.Support.V4.App.Fragment
    {
        //declaraciones de la lista
        string[] items;
        ListView mainList;
        View v;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

             v = inflater.Inflate(Resource.Layout.Pestana2, container, false);

            //Lista things
            items = new string[] {
            "Xamarin",
            "Android",
            "IOS",
            "Windows",
            "Xamarin-Native",
            "Xamarin-Forms"
        };

            mainList = v.FindViewById<ListView>(Resource.Id.mainlistview);
            mainList.Adapter = new ArrayAdapter(this.Context, Android.Resource.Layout.SimpleListItem1, items);

            return v;
        }
        
    }
}