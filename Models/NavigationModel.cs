using System;
using Lab1_Mysko.Views;

namespace Lab1_Mysko.Models
{
    public enum Views
    {
        PickData
    }

    internal class NavigationModel
    {
        private ContentWindow _window;
        private PickDataView _pickDataView;

        public NavigationModel( ContentWindow window)
        {
            _window = window;
            _pickDataView = new PickDataView();

        }

        public void Navigate(Views view)
        {
            switch (view)
            {
                case Views.PickData:
                    _window.MinWidth = 500;
                    _window.MinHeight = 350;
                    _window.ContentControl.Content = _pickDataView;
                    break;
                default:
                    throw new ArgumentException("Inappropriate argument for method Navigate !");
            }
        }
    }
}