using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MvuTest.Controls {
    public abstract class MvuPage : Page, IUIElement2 {

        public MvuPage() {
            this.Content = Build().Control;
        }

        protected abstract IUIElement2 Build();

        public UIElement Control => this;
    }
}
