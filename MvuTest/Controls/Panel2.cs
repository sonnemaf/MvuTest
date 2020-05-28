using System.Collections;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace MvuTest.Controls {
    public abstract class Panel2<TType, TElement> : FrameworkElement2<TType, TElement>, IEnumerable<IUIElement2>
            where TType : UIElement2<TType, TElement>
            where TElement : Panel {

        private readonly List<IUIElement2> _childeren = new List<IUIElement2>();

        protected Panel2() {
        }

        public IEnumerator<IUIElement2> GetEnumerator() {
            return ((IEnumerable<IUIElement2>)_childeren).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return ((IEnumerable)_childeren).GetEnumerator();
        }

        public void Add(IUIElement2 child) {
            this._childeren.Add(child);
            this.Control.Children.Add(child.Control);
        }


    }
}
