using LLMListView_Sample.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMListView_Sample.Models
{
    public class MyCustomClass : BindableBase
    {
        #region IsVisible
        private bool _isVisible;

        public bool IsVisible
        {
            get { return _isVisible; }
            set { Set(ref _isVisible, value); }
        }
        #endregion

        #region EnableSwipeRight
        private bool _enableSwipeRight = true;
        public bool EnableSwipeRight
        {
            get { return _enableSwipeRight; }
            set
            {
                _enableSwipeRight = value;
                if (IsSwipedRight)
                {
                    _isSwipedRight = value;
                    RaisePropertyChanged(nameof(IsSwipedRight));
                }
                RaisePropertyChanged(nameof(EnableSwipeRight));
            }
        }
        #endregion

        #region EnableSwipeLeft
        private bool _enableSwipeLeft = true;
        public bool EnableSwipeLeft
        {
            get { return _enableSwipeLeft; }
            set
            {
                _enableSwipeLeft = value;
                if (IsSwipedLeft)
                {
                    _isSwipedLeft = value;
                    RaisePropertyChanged(nameof(IsSwipedLeft));
                }
                RaisePropertyChanged(nameof(EnableSwipeLeft));
            }
        }
        #endregion

        #region IsSwipedRight
        private bool _isSwipedRight;
        public bool IsSwipedRight
        {
            get { return _isSwipedRight; }
            set
            {
                if (!EnableSwipeRight)
                    return;
                _isSwipedRight = value;
                RaisePropertyChanged(nameof(IsSwipedRight));
            }
        }
        #endregion

        #region IsSwipedLeft
        private bool _isSwipedLeft;
        public bool IsSwipedLeft
        {
            get { return _isSwipedLeft; }
            set
            {
                if (!EnableSwipeLeft)
                    return;
                _isSwipedLeft = value;
                RaisePropertyChanged(nameof(IsSwipedLeft));
            }
        }
        #endregion

        #region Property
        private string _text1;

        public string Text1
        {
            get { return _text1; }
            set { Set(ref _text1, value); }
        }


        private string _text2;

        public string Text2
        {
            get { return _text2; }
            set { Set(ref _text2, value); }
        }

        private string _text3;

        public string Text3
        {
            get { return _text3; }
            set { Set(ref _text3, value); }
        }

        #endregion
    }
}
