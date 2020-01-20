using Android.App;
using Android.Support.V4.View;

namespace Ejer6_AndroidRelations
{
    public class ViewPageListenerForActionBar : ViewPager.SimpleOnPageChangeListener
    {
        private ActionBar _bar;
        public ViewPageListenerForActionBar(ActionBar bar)
        {
            _bar = bar;
        }
        public override void OnPageSelected(int position)
        {
            _bar.SetSelectedNavigationItem(position);
        }
    }
    public static class ViewPagerExtensions
    {
        public static ActionBar.Tab GetViewPageTab(this ViewPager viewPager, ActionBar actionBar,string name)
        {
            var tab = actionBar.NewTab();
            tab.SetText(name);
            tab.TabSelected += (o, e) =>
              {
                  viewPager.SetCurrentItem(actionBar.SelectedNavigationIndex, false);
              };
            return tab;
        }
    }
}

