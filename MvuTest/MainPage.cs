using MvuTest.Controls;
using System;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace MvuTest {

    public class MainPage : MvuPage {

        private TextBlock2 _tb;

        private int _count;

        protected override IUIElement2 Build() {

            return new StackPanel2()
            {
                new ToggleButton2("Toggle it")
                    .Width(200)
                    .FontSize(30),
                new Button2("Increment", (sender, e) => {
                    _tb.Text($"Count {++_count}");
                }).HorizontalAlignment(HorizontalAlignment.Center),
                (_tb = new TextBlock2("Count 0"))
                    .FontSize(20)
                    .Foreground(Colors.Red),
                new TextBox2("Fons Sonnemans")
                    .Header("Name"),
            }.Spacing(12)
             .HorizontalAlignment(HorizontalAlignment.Center)
             .VerticalAlignment(VerticalAlignment.Center);
        }
    }


}