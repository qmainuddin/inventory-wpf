using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ShopInventory.Pages.Common
{
    /// <summary>
    /// Interaction logic for ModalContainer.xaml
    /// </summary>
    public partial class ModalContainer : UserControl
    {
        private bool _hideRequest = false;
        private bool _result = false;
        private UIElement _parent;
        private static ModalContainer currentInstance = null;
        public ModalContainer()
        {
            InitializeComponent();
            currentInstance = this;
        }
        public static ModalContainer getInstance()
        {
            if(currentInstance == null)
            {
                currentInstance = new ModalContainer();
            }
            return currentInstance;
        }
        public void SetParent(UIElement parent)
        {
            _parent = parent;
        }
        public bool ShowHandlerDialog()
        {
            //Message = message;
            Visibility = Visibility.Visible;

            _parent.IsEnabled = false;

            _hideRequest = false;
            while (!_hideRequest)
            {
                // HACK: Stop the thread if the application is about to close
                if (this.Dispatcher.HasShutdownStarted ||
                    this.Dispatcher.HasShutdownFinished)
                {
                    break;
                }

                // HACK: Simulate "DoEvents"
                object obj = this.Dispatcher.Invoke(
                    DispatcherPriority.Background,
                    new ThreadStart(delegate { }));
                if (obj != null)
                {
                    MessageBox.Show(obj.ToString());
                }
                //Thread.Sleep(20);
            }

            return _result;
        }
        private void HideHandlerDialog()
        {
            _hideRequest = true;
            Visibility = Visibility.Hidden;
            _parent.IsEnabled = true;
        }
        public void CloseModal()
        {
            _result = true;
            HideHandlerDialog();
        }
    }
}
