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

namespace Ejer6_AndroidRelations.Resources.layout
{
   public class ClaseLista
    {

        private static ClaseLista _instance = new ClaseLista();

        protected ClaseLista()
        {

        }

        public static ClaseLista Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClaseLista();
                }
                return _instance;
            }
        }

        public List<string> MyList = new List<string>();
    }
}
