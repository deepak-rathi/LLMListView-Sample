using LLM;
using LLMListView_Sample.Models;
using LLMListView_Sample.ViewModels;
using System.Linq;
using Windows.UI.Xaml.Controls;

namespace LLMListView_Sample.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel _viewModel = new MainPageViewModel();
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = _viewModel;
        }

        private void LLMListView_ItemSwipeBeginTrigger(object sender, LLM.SwipeReleaseEventArgs args)
        {
            if (_viewModel._oldListItem != null && _viewModel._oldListItem != sender)
            {
                //reset old list item
                ((MyCustomClass)_viewModel._oldListItem.Content).IsSwipedLeft = false;
                ((MyCustomClass)_viewModel._oldListItem.Content).IsSwipedRight = false;
            }

            var swipedItem = sender as LLMListViewItem;

            var swipedItemDataContext = swipedItem.Content as MyCustomClass;
            //set new list item in local reference
            _viewModel._oldListItem = swipedItem;

            //Note: Uncomment to see Fix Swipe Mode break's and one of the item's right to left swipe stop's working
            //trying to change swiped item RightSwipeLength
            //if (swipedItemDataContext.IsVisible)
            //{
            //    swipedItem.RightSwipeMaxLength = 80.0;
            //}
            //else
            //{
            //    swipedItem.RightSwipeMaxLength = 180.00;
            //}

            //Set Selected Item
            _viewModel.Selected = _viewModel.MyItemSource.FirstOrDefault(p => p.Text1.Equals(swipedItemDataContext.Text1));
            
        }
    }
}
