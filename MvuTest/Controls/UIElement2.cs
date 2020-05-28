using Windows.UI.Xaml;

namespace MvuTest.Controls {

    public abstract class UIElement2<TType, TElement> : IUIElement2
            where TType : UIElement2<TType, TElement>
            where TElement : UIElement {

        public UIElement2() {
            Control = CreateControl();
        }

        protected TElement Control { get; }

        protected abstract TElement CreateControl();

        UIElement IUIElement2.Control => this.Control;

        protected TType Chain => this as TType;
    }
}
