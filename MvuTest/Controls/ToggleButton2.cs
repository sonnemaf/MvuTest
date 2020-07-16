using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;

namespace MvuTest.Controls {

    public class ToggleButton2 : ButtonBase2<ToggleButton2, ToggleButton> {

        public ToggleButton2(object content) : base(content) {
        }

        public ToggleButton2(object content, RoutedEventHandler click) : this(content) {
            Click(click);
        }

        public ToggleButton2 IsChecked(bool? value) {
            this.Control.IsChecked = value;
            return Chain;
        }

        protected override ToggleButton CreateControl() => new ToggleButton();

    }
}
