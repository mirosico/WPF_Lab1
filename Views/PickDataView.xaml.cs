using Lab1_Mysko.ViewModels;
using UserControl = System.Windows.Controls.UserControl;

namespace Lab1_Mysko.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class PickDataView : UserControl
    {
        private PickDataViewModel _model;

        public PickDataView()
        {
            InitializeComponent();
            _model = new PickDataViewModel();
            DataContext = _model;
            
        }
    }
}