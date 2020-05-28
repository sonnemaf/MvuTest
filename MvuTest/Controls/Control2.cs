using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace MvuTest.Controls {
    public abstract class Control2<TType, TElement> : FrameworkElement2<TType, TElement>
            where TType : UIElement2<TType, TElement>
            where TElement : Control {

        protected Control2() {
        }

        public TType FontSize(double fontSize) {
            this.Control.FontSize = fontSize;
            return Chain;
        }

        public TType Foreground(Brush brush) {
            this.Control.Foreground = brush;
            return Chain;
        }

        public TType Foreground(Color color) {
            return Foreground(new SolidColorBrush(color));
        }

    }
}
