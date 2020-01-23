using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Ejer6_AndroidRelations
{
    [Activity]
    class LogicaPantallaAceptado : AppCompatActivity
    {
        ViewPager vp;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pantallaAceptado);

            Toolbar tb = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(tb);

            vp = FindViewById<ViewPager>(Resource.Id.viewPager1);
            SetupViewPager(vp);

            var tablab = FindViewById<TabLayout>(Resource.Id.tabLayout);
            tablab.SetupWithViewPager(vp);
        }
                void SetupViewPager(ViewPager viewPager)
                {
                    var adapter = new FragmentAdapter(SupportFragmentManager);
                    adapter.AddFragment(new Pestana1(), "Pestaña 1");
                    adapter.AddFragment(new Pestana2(), "Pestaña 2");
                    viewPager.Adapter = adapter;
                    vp.Adapter.NotifyDataSetChanged();

                }
    }
}