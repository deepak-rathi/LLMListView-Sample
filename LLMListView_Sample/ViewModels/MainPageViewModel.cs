using LLMListView_Sample.Models;
using LLMListView_Sample.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMListView_Sample.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        //Store ListviewItem
        public LLM.LLMListViewItem _oldListItem;

        #region Constructor
        public MainPageViewModel()
        {
            MyItemSource = new ObservableCollection<MyCustomClass>();
            //dummy data for list
            MyItemSource.Add(new MyCustomClass() { IsVisible = false, Text1="Item 1 Some long large text 1", Text2 = "Item 1 Some long large text 2", Text3= "Item 1 Some long large text 3" });
            MyItemSource.Add(new MyCustomClass() { IsVisible = true, Text1 = "Item 2 Some long large text 1", Text2= "Item 2 Some long large text 2", Text3= "Item 2 Some long large text 3" });
        }
        #endregion

        #region ItemsSource
        private ObservableCollection<MyCustomClass> _itemSource;

        public ObservableCollection<MyCustomClass> MyItemSource
        {
            get { return _itemSource; }
            set {Set(ref  _itemSource, value); }
        }

        #endregion

        #region SelectedItem
        private MyCustomClass _selected;

        public MyCustomClass Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        #endregion

    }
}
