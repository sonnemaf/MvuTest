using Windows.UI.Xaml.Controls;

namespace MvuTest.Controls {
    public abstract class MvuPage : Page {

        public MvuPage() {
            this.Content = Build().Control;
        }

        protected abstract IUIElement2 Build();

    }
}
