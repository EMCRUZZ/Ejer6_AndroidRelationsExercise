using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4;

namespace Ejer6_AndroidRelations
{

    public class GenericFragmentPagerAdaptor : Android.Support.V4.App.FragmentPagerAdapter
    {
        private List<Android.Support.V4.App.Fragment> _fragmentList = new List<Android.Support.V4.App.Fragment>();

        

        public GenericFragmentPagerAdaptor(Android.Support.V4.App.FragmentManager fm) : base(fm)
        {
        }
        public void AddFragmentView(Func<LayoutInflater, ViewGroup, Bundle, View> view)
        {
            _fragmentList.Add(new GenericViewPagerFragment(view));
        }

        public void AddFragment(GenericViewPagerFragment fragment)
        {
            _fragmentList.Add(fragment);
        }

        public override int Count
        {
            get
            {
                return _fragmentList.Count;
            }
        }
        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return _fragmentList[position];
        }
    }
}

