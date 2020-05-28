using MvuTest.Controls;
using System;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace MvuTest {

    public class MainPage : MvuPage {

        protected override IUIElement2 Build() {

            return new StackPanel2()
            {
                new ToggleButton2("Toggle it")
                    .Width(200)
                    .FontSize(30)
                    .Click((sender, e) => {
                        _ = new MessageDialog("Test 1").ShowAsync();
                    }),
                new Button2("Small Button", (sender, e) => {
                    _ = new MessageDialog("Test 2").ShowAsync();
                }).HorizontalAlignment(HorizontalAlignment.Center),
                new TextBlock2("Hello World")
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