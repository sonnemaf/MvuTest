using Windows.UI.Xaml.Controls;

namespace MvuTest.Controls {
    public class TextBox2 : Control2<TextBox2, TextBox> {

        public TextBox2(string text) {
            Text(text);
        }

        public TextBox2 Text(string text) {
            this.Control.Text = text;
            return Chain;
        }

        public TextBox2 Header(object header) {
            this.Control.Header = header;
            return Chain;
        }

        protected override TextBox CreateControl() => new TextBox();
    }
}
