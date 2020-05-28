using Windows.UI.Xaml;

namespace MvuTest.Controls {
    public abstract class FrameworkElement2<TType, TElement> : UIElement2<TType, TElement>
            where TType : UIElement2<TType, TElement>
            where TElement : FrameworkElement {

        protected FrameworkElement2() {
        }

        public TType Width(double value) {
            this.Control.Width = value;
            return Chain;
        }

        public TType HorizontalAlignment(HorizontalAlignment alignment) {
            this.Control.HorizontalAlignment = alignment;
            return Chain;
        }

        public TType VerticalAlignment(VerticalAlignment alignment) {
            this.Control.VerticalAlignment = alignment;
            return Chain;
        }
    }
}
