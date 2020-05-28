using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MvuTest.Controls {
    public class Button2 : ButtonBase2<Button2, Button> {

        public Button2(object content) : base(content) {
        }

        public Button2(object content, RoutedEventHandler click) : this(content) {
            Click(click);
        }

        protected override Button CreateControl() => new Button();
    }
}
