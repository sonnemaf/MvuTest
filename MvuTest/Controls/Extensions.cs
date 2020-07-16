using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace MvuTest.Controls {
    static class Extensions {

        public static StackPanel2 StackPanel(this IUIElement2 parent, params IUIElement2[] childeren) {
            var panel = new StackPanel2();
            foreach (var item in childeren) {
                panel.Add(item);
            }
            return panel;
        }

        public static Button2 Button(this IUIElement2 parent, object content) {
            return new Button2(content);
        }

        public static ToggleButton2 ToggleButton(this IUIElement2 parent, object content, RoutedEventHandler click) {
            return new ToggleButton2(content, click);
        }

        public static ToggleButton2 ToggleButton(this IUIElement2 parent, object content) {
            return new ToggleButton2(content);
        }

        public static Button2 Button(this IUIElement2 parent, object content, RoutedEventHandler click) {
            return new Button2(content, click);
        }
        public static TextBlock2 TextBlock(this IUIElement2 parent, string text) {
            return new TextBlock2(text);
        }

        public static TextBox2 TextBox(this IUIElement2 parent, string text) {
            return new TextBox2(text);
        }
    }
}
