using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Support.V4.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ejer6_AndroidRelations
{
    public class GenericViewPagerFragment : Android.Support.V4.App.Fragment
    {
        private Func<LayoutInflater, ViewGroup, Bundle, View> _view;
        public GenericViewPagerFragment(Func<LayoutInflater,ViewGroup,Bundle,View> view)
        {
            _view = view;
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstance)
        {
            base.OnCreateView(inflater, container, savedInstance);
            return _view(inflater, container, savedInstance);
        }
    }
}