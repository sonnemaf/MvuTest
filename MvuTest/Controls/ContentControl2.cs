using Windows.UI.Xaml.Controls;

namespace MvuTest.Controls {
    public abstract class ContentControl2<TType, TElement> : Control2<TType, TElement>
        where TType : UIElement2<TType, TElement>
        where TElement : ContentControl {

        protected ContentControl2(object content) {
            this.Control.Content = content;
        }


    }
}