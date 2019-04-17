using Lab1_Mysko.Models;

namespace Lab1_Mysko.Managers
{
    class NavigationManager
    {
        private static NavigationManager _instance;
        private static readonly object _lock = new object();
        private NavigationModel _navigation;

        public static NavigationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance = new NavigationManager();
                    }
                }

                return _instance;
            }
        }

        public void Initialise(NavigationModel model)
        {
            _navigation = model;
        }

        public void Navigate(Models.Views view)
        {
            _navigation?.Navigate(view);
        }
    }
}