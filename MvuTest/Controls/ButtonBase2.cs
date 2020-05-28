using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;

namespace MvuTest.Controls {

    public abstract class ButtonBase2<TType, TElement> : ContentControl2<TType, TElement>
        where TType : UIElement2<TType, TElement>
        where TElement : ButtonBase {

        protected ButtonBase2(object content) : base(content) {
        }

        protected ButtonBase2(object content, RoutedEventHandler click, Windows.UI.Xaml.Controls.Primitives.ButtonBase control) : this(content) {
            Click(click);
        }

        public TType Click(RoutedEventHandler action) {
            this.Control.Click += action;
            return Chain;
        }
    }
}