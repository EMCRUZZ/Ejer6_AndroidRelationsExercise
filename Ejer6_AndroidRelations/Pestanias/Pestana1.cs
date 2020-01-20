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


namespace Ejer6_AndroidRelations
{
   public class Pestana1 : Android.Support.V4.App.Fragment
    {
        View v;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            v = inflater.Inflate(Resource.Layout.Pestana1,container,false);

            return v;
        }
    }
}