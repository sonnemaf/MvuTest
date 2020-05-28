using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace MvuTest.Controls {

    public class TextBlock2 : FrameworkElement2<TextBlock2, TextBlock> {

        public TextBlock2(string text) {
            Text(text);
        }

        public TextBlock2 Text(string text) {
            this.Control.Text = text;
            return Chain;
        }

        public TextBlock2 FontSize(double fontSize) {
            this.Control.FontSize = fontSize;
            return Chain;
        }

        public TextBlock2 Foreground(Brush brush) {
            this.Control.Foreground = brush;
            return Chain;
        }

        public TextBlock2 Foreground(Color color) => Foreground(new SolidColorBrush(color));

        protected override TextBlock CreateControl() => new TextBlock();
    }
}
