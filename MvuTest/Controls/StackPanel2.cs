using Windows.UI.Xaml.Controls;

namespace MvuTest.Controls {

    public class StackPanel2 : Panel2<StackPanel2, StackPanel> {

        public StackPanel2() {
        }

        protected override StackPanel CreateControl() => new StackPanel();

        public StackPanel2 Spacing(double value) {
            this.Control.Spacing = value;
            return Chain;
        }
    }
}
